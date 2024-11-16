using ToyShop.ViewModels;

namespace ToyShop.ViewModels
{
    public class PromotionViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public int DiscountPercentage { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan Duration => EndDate - StartDate;
    }
}
