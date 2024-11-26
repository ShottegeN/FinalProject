using System.Diagnostics;
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


        public async Task<StoreViewModel> GetStoreViewModel(string sortBy, int pageNumber = 1, int pageSize = 9, int? categoryId = null)
        {

            var totalProductsQuery = TotalProductsAfterCategoryFilter(categoryId);
            var totalProductsCount = await totalProductsQuery.CountAsync();

            var totalPages = (int)Math.Ceiling(totalProductsCount / (double)pageSize);

            var paginatedProducts = await GetAllProductsWithFilterSorted(sortBy, pageNumber, pageSize, categoryId);

            return new StoreViewModel
            {
                AllProducts = await GetAllProductsWithFilterSorted(sortBy, pageNumber, pageSize, categoryId),
                TotalPages = totalPages,
                TotalProductsCount = totalProductsCount,
                CurrentPage = pageNumber,
                PageSize = pageSize,
                SortBy = sortBy,

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

            return products;
        }


        //private
        private async Task<IEnumerable<ProductInfoViewModel>> GetAllProductsWithFilterSorted(string sortBy, int pageNumber = 1, int pageSize = 9, int? categoryId = null)
        {
            // Base query
            IQueryable<Product> productsQuery = TotalProductsAfterCategoryFilter(categoryId);

            // Paginate and project
            var products = await productsQuery
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
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
                "price_asc" => [.. products.OrderBy(p => p.Price)],
                "price_desc" => [.. products.OrderByDescending(p => p.Price)],
                "name_asc" => [.. products.OrderBy(p => p.ProductName)],
                "name_desc" => [.. products.OrderByDescending(p => p.ProductName)],
                _ => [.. products.OrderByDescending(p => p.Rating)] // Default: by rating
            };

            return products;
        }

        private IQueryable<Product> TotalProductsAfterCategoryFilter(int? categoryId)
        {
            var productsQuery = repo.AllReadonlyAsync<Product>().Where(p => p.IsAvailable);

            if (categoryId.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.CategoryId == categoryId.Value);
            }

            return productsQuery;
        }

        private static void CalculatePromotionalPrice(List<ProductInfoViewModel> products)
        {
            foreach (var p in products)
            {
                p.PromotionalPrice = p.Price - p.Price * p.DiscountPercentage / 100;
            }
        }        
    }
}
