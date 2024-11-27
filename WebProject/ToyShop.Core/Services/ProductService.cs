using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.ViewModels;

namespace ToyShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repo;

        public ProductService(IRepository _repo)
        {
            repo = _repo;
        }


        public async Task<StoreViewModel> GetStoreViewModel(string sortBy, int pageNumber = 1, int pageSize = 9, string filter = "")
        {
            var allProductsQuery = TotalProductsAfterCategoryFilter(filter);

            var totalProductsCount = await allProductsQuery.CountAsync();

            var totalPages = (int)Math.Ceiling(totalProductsCount / (double)pageSize);

            pageNumber = pageNumber > totalPages ? totalPages : pageNumber;

            var paginatedProducts = await GetAllProductsWithFilterSorted(allProductsQuery, sortBy, pageNumber, pageSize);

            return new StoreViewModel
            {
                AllProducts = paginatedProducts,
                TotalPages = totalPages,
                TotalProductsCount = totalProductsCount,
                CurrentPage = pageNumber,
                PageSize = pageSize,
                SortBy = sortBy,
                Filter = filter
            };
        }


        public async Task<IEnumerable<ProductInfoViewModel>> GetNewest10ProductsAsync()
        {
            var products = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.IsAvailable)
                .Where(p => p.ReleasedOn >= DateTime.Now.AddDays(-30))
                .OrderByDescending(p => p.ReleasedOn)
                .Take(10)
                .Select(p => new ProductInfoViewModel
                {
                    Id = p.Id,
                    ProductName = p.Name,
                    ImageUrl = p.ImageUrl,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    Category = p.Category.Name,
                    DiscountPercentage = p.Promotion != null && p.Promotion.StartDate < DateTime.Now && p.Promotion.EndDate > DateTime.Now ? p.Promotion.DiscountPercentage : 0,
                    ShortDescription = p.ShortDescription,
                    Rating = p.Reviews.Sum(r => r.Rating),
                    Description = p.Description
                })
                .ToListAsync();

            CalculatePromotionalPrice(products);

            return products;
        }

        public async Task<ProductInfoViewModel> GetProductByIdAsync(Guid id)
        {
            var p = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.Id == id)
                .Include(p => p.Category)
                .Include(p => p.Reviews)
                .Include(p => p.Promotion)
                .FirstOrDefaultAsync();


            if (p != null)
            {
                var product = new ProductInfoViewModel
                {
                    Id = p.Id,
                    ProductName = p.Name,
                    ImageUrl = p.ImageUrl,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    ReleasedOn = p.ReleasedOn.ToString("dd.MM.yyyy"),
                    Category = p.Category.Name,
                    GlobalCategory = p.GlobalCategory.ToString(),
                    DiscountPercentage = p.Promotion != null && p.Promotion.StartDate < DateTime.Now && p.Promotion.EndDate > DateTime.Now ? p.Promotion.DiscountPercentage : 0,
                    ShortDescription = p.ShortDescription,
                    Rating = p.Reviews.Sum(r => r.Rating),
                    Description = p.Description
                };

                CalculateSingleProductPromotionalPrice(product);

                return product;
            }

            throw new NotImplementedException();
        }



        //private
        private async Task<IEnumerable<ProductInfoViewModel>> GetAllProductsWithFilterSorted(IQueryable<Product> productsQuery, string sortBy, int pageNumber = 1, int pageSize = 9)
        {
            var products = await productsQuery
                .Select(p => new ProductInfoViewModel
                {
                    Id = p.Id,
                    ProductName = p.Name,
                    ImageUrl = p.ImageUrl,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    Category = p.Category.Name,
                    DiscountPercentage = p.Promotion != null && p.Promotion.StartDate < DateTime.Now && p.Promotion.EndDate > DateTime.Now ? p.Promotion.DiscountPercentage : 0,
                    ShortDescription = p.ShortDescription,
                    Rating = p.Reviews.Sum(r => r.Rating),
                    Description = p.Description
                })
                .ToListAsync();

            CalculatePromotionalPrice(products);

            products = sortBy.ToLower() switch
            {
                "price_asc" => [.. products.OrderBy(p => p.PromotionalPrice)],
                "price_desc" => [.. products.OrderByDescending(p => p.PromotionalPrice)],
                "name_asc" => [.. products.OrderBy(p => p.ProductName)],
                "name_desc" => [.. products.OrderByDescending(p => p.ProductName)],
                _ => [.. products.OrderByDescending(p => p.Rating)] // Default: by rating
            };

            return products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }

        private static void CalculatePromotionalPrice(List<ProductInfoViewModel> products)
        {
            foreach (var p in products)
            {
                CalculateSingleProductPromotionalPrice(p);
            }
        }

        private static void CalculateSingleProductPromotionalPrice(ProductInfoViewModel p)
        {
            p.PromotionalPrice = p.Price - p.Price * p.DiscountPercentage / 100;
        }

        private IQueryable<Product> TotalProductsAfterCategoryFilter(string filter)
        {
            var productsQuery = repo.AllReadonlyAsync<Product>().Where(p => p.IsAvailable);

            if (filter == "")
            {
                return productsQuery;
            }
            var filterArray = filter.Split('-').ToArray();

            var filteringType = filterArray[0];
            var filteringValue = filterArray[1];

            if (filteringType == "category")
            {
                productsQuery = productsQuery.Where(p => p.CategoryId == int.Parse(filteringValue));
            }
            else if (filteringType == "promotion")
            {
                if (filteringValue == "all")
                {
                    return productsQuery.Where(p => p.PromotionId > 0);
                }

                productsQuery = productsQuery.Where(p => p.PromotionId == int.Parse(filteringValue));
            }
            else if (filteringType == "globalCategory")
            {
                if (filterArray.Length > 2 && !string.IsNullOrEmpty(filterArray[2]))
                {
                    var searchQuery = filterArray[2];

                    productsQuery = productsQuery
                        .Where(p =>
                        (int)p.GlobalCategory == int.Parse(filteringValue) &&
                        EF.Functions.Like(p.Name, "%" + searchQuery + "%"));
                }
                else
                {
                    productsQuery = productsQuery.Where(p => (int)p.GlobalCategory == int.Parse(filteringValue));
                }
            }

            return productsQuery;
        }


    }
}
