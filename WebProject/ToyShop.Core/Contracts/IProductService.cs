using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductInfoViewModel>> GetNewestProductsAsync();
    }
}
