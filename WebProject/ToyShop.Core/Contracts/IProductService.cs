using ToyShop.Data.Models;
using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IProductService
    {
        public Task<List<ProductInfoViewModel>> GetNewProductsAsync();
    }
}
