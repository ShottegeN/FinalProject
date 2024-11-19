namespace ToyShop.ViewModels
{
    public class StoreViewModel
    {
        public IEnumerable<ProductInfoViewModel> AllProducts { get; set; } = null!;

        public IEnumerable<CategoryViewModel> AllCategories { get; set; } = null!;
    }
}
