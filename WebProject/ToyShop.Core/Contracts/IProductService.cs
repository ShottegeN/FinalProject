using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IProductService
    {
        public Task<StoreViewModel> GetStoreViewModel(string sortBy, int pageNumber, int pageSize, string filter);

        public Task<IEnumerable<ProductInfoViewModel>> GetNewest10ProductsAsync();

        public Task<ProductInfoViewModel> GetProductForDetails(Guid id);

    }
}
