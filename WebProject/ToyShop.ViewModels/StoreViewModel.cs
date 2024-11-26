namespace ToyShop.ViewModels
{
    public class StoreViewModel
    {
        public IEnumerable<ProductInfoViewModel> AllProducts { get; set; } = new List<ProductInfoViewModel>();
        public IEnumerable<CategoryViewModel> AllCategories { get; set; } = new List<CategoryViewModel>();
        public int TotalProductsCount { get; set; }
    }
}
