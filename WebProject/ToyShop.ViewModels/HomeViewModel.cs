using ToyShop.ViewModels.Product;

namespace ToyShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<ProductInfoViewModel> NewProducts { get; set; } = null!;
    }
}
