using ToyShop.ViewModels;

namespace ToyShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<ProductInfoViewModel> NewProducts { get; set; } = null!;

        public IEnumerable<PromotionViewModel> ActivePromotions { get; set; } = null!;
    }
}
