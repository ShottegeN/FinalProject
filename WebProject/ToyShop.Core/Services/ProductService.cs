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

        public async Task<IEnumerable<ProductInfoViewModel>> GetAllProductsAsync(
             string sortBy = "rating", // Default sort by name
             bool ascending = true,  // Default sort direction ascending
             int pageNumber = 1,     // Default to first page
             int pageSize = 9)      // Default page size of 9
        {
            // Determine the sorting expression
            IQueryable<Product> query = repo.AllReadonlyAsync<Product>()
                .Where(p => p.IsAvailable);  // Only include available products

            // Apply sorting
            query = sortBy.ToLower() switch
            {
                "price" => ascending ? query.OrderBy(p => p.Price) : query.OrderByDescending(p => p.Price),
                "rating" => ascending ? query.OrderBy(p => p.Reviews.Sum(r => r.Rating)) : query.OrderByDescending(p => p.Reviews.Sum(r => r.Rating)),
                "name" => ascending ? query.OrderBy(p => p.Name) : query.OrderByDescending(p => p.Name),
                _ => query.OrderBy(p => p.Name),  // Default to sorting by Name if invalid option
            };

            // Apply pagination
            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            // Fetch the products and map to the view model
            var products = await query.Select(p => new ProductInfoViewModel
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
            }).ToListAsync();

            return products;
        }


        public async Task<IEnumerable<ProductInfoViewModel>> GetNewestProductsAsync()
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

        public async Task<int> GetAllProductsCountAsync()
        {
            return await repo.AllReadonlyAsync<Product>().CountAsync();
        }
    }
}
