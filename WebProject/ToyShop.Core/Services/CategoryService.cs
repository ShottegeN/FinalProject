using Microsoft.EntityFrameworkCore;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repo;

        public CategoryService(IRepository _repo) 
        {
            repo = _repo;
        }
        public async Task<IEnumerable<CategoryViewModel>> GetAllCategoriesAsync()
        {
            var categories = await repo.AllReadonlyAsync<Category>()
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    ProductCount = c.Products.Where(p => p.IsAvailable).Count(),
                })
                .ToListAsync();

            if (categories == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            return categories;
        }

    }
}
