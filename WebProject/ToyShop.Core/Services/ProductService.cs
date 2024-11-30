﻿using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.Data.Models.Enumerations;
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


        public async Task<StoreViewModel> GetStoreViewModelAsync(string sortBy, int pageNumber = 1, int pageSize = 9, string filter = "")
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

        public async Task AddProductAsync(UIProductViewModel p, string? newCategoryName)
        {
            int categoryId = await GetCategoryId(p, newCategoryName);

            var product = new Product
            {
                Name = p.ProductName,
                Price = p.Price!.Value,
                Quantity = p.Quantity!.Value,
                Description = p.Description,
                ShortDescription = p.ShortDescription,
                Size = p.Size,
                ImageUrl = p.ImageUrl ?? "img/no_img.png",
                GlobalCategory = Enum.TryParse(p.GlobalCategory, true, out GlobalCategory globalCategory) ? globalCategory : GlobalCategory.Други,
                CategoryId = categoryId,
            };

            await repo.AddAsync(product);

            await repo.SaveChangesAsync();
        }

        public async Task EditProductAsync(UIProductViewModel p, string? newCategoryName)
        {           
            var product = await repo.GetByIdAsync<Product>(p.Id);

            if (product == null)
            {
                throw new ArgumentException("Невалидна операция");
            }

            // Get or create the category ID
            int categoryId = await GetCategoryId(p, newCategoryName);

            // Update the properties of the existing product
            product.Name = p.ProductName;
            product.Price = p.Price!.Value;
            product.Quantity = p.Quantity!.Value;
            product.Description = p.Description;
            product.ShortDescription = p.ShortDescription;
            product.Size = p.Size;
            product.ImageUrl = p.ImageUrl ?? "img/no_img.png";
            product.GlobalCategory = Enum.TryParse(p.GlobalCategory, true, out GlobalCategory globalCategory) ? globalCategory : GlobalCategory.Други;
            product.CategoryId = categoryId;

            await repo.UpdateAsync(product);

            await repo.SaveChangesAsync();
        }



        public async Task<UIProductViewModel> GetproductForEditAsync(Guid id)
        {
            var p = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.Id == id)
                .Include(p => p.Category)
                .FirstOrDefaultAsync();


            if (p == null)
            {
                throw new ArgumentNullException();
            }

            var product = new UIProductViewModel
            {
                Id = p.Id,
                ProductName = p.Name,
                ImageUrl = p.ImageUrl,
                Quantity = p.Quantity,
                Price = p.Price,
                Size = p.Size,
                Category = p.Category.Id.ToString(),
                GlobalCategory = p.GlobalCategory.ToString(),
                ShortDescription = p.ShortDescription,
                Description = p.Description
            };

            return product;
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

        public async Task<ProductInfoViewModel> GetProductForDetailsAsync(Guid id)
        {
            var p = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.Id == id)
                .Include(p => p.Category)
                .Include(p => p.Reviews)
                .Include(p => p.Promotion)
                .FirstOrDefaultAsync();


            if (p == null)
            {
                throw new ArgumentNullException();
            }

            var product = new ProductInfoViewModel
            {
                Id = p.Id,
                ProductName = p.Name,
                ImageUrl = p.ImageUrl,
                Quantity = p.Quantity,
                Price = p.Price,
                Size = p.Size,
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

        public async Task<ProductInfoViewModel> GetproductForDeleteAsync(Guid id)
        {
            var p = await repo.GetByIdAsync<Product>(id);

            if (p == null)
            {
                throw new ArgumentNullException();
            }

            var product = new ProductInfoViewModel
            {
                Id = p.Id,
                ProductName = p.Name,
                ReleasedOn = p.ReleasedOn.ToString("dd.MM.yyyy"),
                GlobalCategory = p.GlobalCategory.ToString(),
            };

            return product;
        }

        public async Task DeleteProductAsync(Guid id)
        {
            var product = await repo.GetByIdAsync<Product>(id);

            if (product == null)
            {
                throw new ArgumentNullException();
            }

            product.IsAvailable = false;

            await repo.SaveChangesAsync();
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

        private async Task<int> GetCategoryId(UIProductViewModel p, string? newCategoryName)
        {
            if (newCategoryName == null && p.Category == "new")
            {
                throw new ArgumentException("Това поле е задължително!");
            }
            else if (newCategoryName == null && p.Category != "new")
            {
                return int.Parse(p.Category);
            }

            var categories = await repo.AllReadonlyAsync<Category>().ToListAsync();

            if (categories.Any(c => c.Name.ToLower() == newCategoryName!.ToLower()))
            {
                throw new ArgumentException("Този вид вече съществува!");
            }

            var newCategory = new Category
            {
                Name = newCategoryName!
            };

            await repo.AddAsync(newCategory);
            await repo.SaveChangesAsync();

            return newCategory.Id;
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
                else if (!string.IsNullOrEmpty(filterArray[2]))
                {
                    productsQuery = productsQuery.Where(p => (int)p.GlobalCategory == int.Parse(filteringValue));
                }
            }

            return productsQuery;
        }
    }
}
