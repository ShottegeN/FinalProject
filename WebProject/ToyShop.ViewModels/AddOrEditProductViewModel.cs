namespace ToyShop.ViewModels
{
    public class AddOrEditProductViewModel
    {
        public UIProductViewModel Product { get; set; } = null!;
        public IEnumerable<CategoryViewModel>? Categories { get; set; }

        public IEnumerable<PromotionViewModel>? Promotions { get; set; }

        public string? NewCategoryName { get; set; }
    }
}
