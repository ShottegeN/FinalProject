using ToyShop.Data.Models;
using ToyShop.ViewModels.Product;

namespace ToyShop.Core.Contracts
{
    public interface IProductService
    {
        public Task<List<ProductInfoViewModel>> GetNewProductsAsync();
    }
}
