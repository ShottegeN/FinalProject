namespace ToyShop.ViewModels
{
    public class StoreViewModel
    {
        public IEnumerable<ProductInfoViewModel> AllProducts { get; set; } = new List<ProductInfoViewModel>();
        public IEnumerable<CategoryViewModel> AllCategories { get; set; } = new List<CategoryViewModel>();
        public int TotalProductsCount { get; set; }


        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public string SortBy { get; set; } = "rating";
        public int PageSize { get; set; } = 9;

        public string Filter { get; set; } = "";
    }
}
