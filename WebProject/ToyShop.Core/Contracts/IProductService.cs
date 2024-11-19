using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductInfoViewModel>> GetAllProductsAsync(string sortBy, bool isAvailable, int pageNumber, int pageSize);

        public Task<int> GetAllProductsCountAsync();

        public Task<IEnumerable<ProductInfoViewModel>> GetNewestProductsAsync();

    }
}
