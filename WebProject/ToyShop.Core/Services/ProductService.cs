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

        public async Task<IEnumerable<ProductInfoViewModel>> GetAllProductsAsyncWithFilterSorted(string sortBy, int pageNumber = 1, int pageSize = 9, int? categoryId = null)
        {            
            var productsQuery = repo.AllReadonlyAsync<Product>().Where(p => p.IsAvailable);

            if (categoryId.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.CategoryId == categoryId.Value);
            }

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

            switch (sortBy.ToLower())
            {
                case "price_asc":
                    products = products.OrderBy(p => p.PromotionalPrice).ToList();
                    break;

                case "price_desc":
                    products = products.OrderByDescending(p => p.PromotionalPrice).ToList();
                    break;

                case "name_asc":
                    products = products.OrderBy(p => p.ProductName).ToList();
                    break;

                case "name_desc":
                    products = products.OrderByDescending(p => p.ProductName).ToList();
                    break;

                default:
                    products = products.OrderBy(p => p.Rating).ToList();
                    break;
            }

            products = products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return products;
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

        public async Task<int> GetAllProductsCountAsync()
        {
            return await repo.AllReadonlyAsync<Product>().CountAsync();
        }




        //private
        private static void CalculatePromotionalPrice(List<ProductInfoViewModel> products)
        {
            foreach (var p in products)
            {
                p.PromotionalPrice = p.Price - p.Price * p.DiscountPercentage / 100;
            }
        }
    }
}
