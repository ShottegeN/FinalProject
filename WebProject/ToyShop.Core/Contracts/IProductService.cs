using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IProductService
    {
        public Task<StoreViewModel> GetStoreViewModelAsync(string sortBy, int pageNumber, int pageSize, string filter);

        public Task<IEnumerable<ProductInfoViewModel>> GetNewest10ProductsAsync();

        public Task<ProductInfoViewModel> GetProductForDetailsAsync(Guid id);

        public Task<ProductInfoViewModel> GetproductForDeleteAsync(Guid id);

        public Task<UIProductViewModel> GetproductForEditAsync(Guid id);

        public Task AddProductAsync(UIProductViewModel product, string newCategoryName);

        public Task EditProductAsync(UIProductViewModel product, string newCategory);

        public Task DeleteProductAsync(Guid id);

    }
}
