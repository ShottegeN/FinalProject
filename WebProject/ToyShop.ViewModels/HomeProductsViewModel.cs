using ToyShop.ViewModels.Product;

namespace ToyShop.ViewModels
{
    public class HomeProductsViewModel
    {
        public IEnumerable<ProductInfoViewModel> NewProducts { get; set; } = null!;
    }
}
