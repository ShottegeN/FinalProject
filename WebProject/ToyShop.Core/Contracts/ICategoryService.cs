using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface ICategoryService
    {        
        public Task<IEnumerable<CategoryViewModel>> GetAllCategoriesAsync();

    }
}
