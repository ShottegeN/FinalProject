using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductInfoViewModel>> GetAllProductsAsyncWithFilterSorted(string sortBy, int pageNumber, int pageSize, int? categoryId);

        public Task<int> GetAllProductsCountAsync();

        public Task<IEnumerable<ProductInfoViewModel>> GetNewest10ProductsAsync();

    }
}
