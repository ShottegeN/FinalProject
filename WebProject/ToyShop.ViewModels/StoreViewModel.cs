namespace ToyShop.ViewModels
{
    public class StoreViewModel
    {
        public IEnumerable<ProductInfoViewModel> AllProducts { get; set; } = new List<ProductInfoViewModel>();
        public IEnumerable<CategoryViewModel> AllCategories { get; set; } = new List<CategoryViewModel>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string SortBy { get; set; } = "rating";
        public int PageSize { get; set; }
    }

}
