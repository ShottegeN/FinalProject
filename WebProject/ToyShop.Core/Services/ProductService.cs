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

        public async Task<IEnumerable<ProductInfoViewModel>> GetAllProductsAsync(string sortBy, int pageNumber = 1, int pageSize = 9)
        {
            var productsQuery = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.IsAvailable)
                .Select(p => new ProductInfoViewModel
                {
                    Id = p.Id,
                    ProductName = p.Name,
                    ImageUrl = p.ImageUrl,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    DiscountPercentage = p.Promotion != null && p.Promotion.StartDate < DateTime.Now && p.Promotion.EndDate > DateTime.Now ? p.Promotion.DiscountPercentage : 0,
                    Category = p.Category.Name,
                    ShortDescription = p.ShortDescription,
                    Rating = p.Reviews.Sum(r => r.Rating),
                    Description = p.Description
                })
                .ToListAsync();
            
            foreach (var p in productsQuery)
            {
                p.PromotionalPrice = p.Price - p.Price * p.DiscountPercentage / 100;
            }


            switch (sortBy.ToLower())
            {
                case "price_asc":
                    productsQuery = productsQuery.OrderBy(p => p.PromotionalPrice).ToList();
                    break;

                case "price_desc":
                    productsQuery = productsQuery.OrderByDescending(p => p.PromotionalPrice).ToList();
                    break;

                case "name_asc":
                    productsQuery = productsQuery.OrderBy(p => p.ProductName).ToList();
                    break;

                case "name_desc":
                    productsQuery = productsQuery.OrderByDescending(p => p.ProductName).ToList();
                    break;

                default:
                    productsQuery = productsQuery.OrderBy(p => p.Rating).ToList();
                    break;
            }


            productsQuery = productsQuery.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return productsQuery;
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
