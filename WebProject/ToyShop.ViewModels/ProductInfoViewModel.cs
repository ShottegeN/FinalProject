namespace ToyShop.ViewModels
{
    public class ProductInfoViewModel
    {      
        public Guid Id { get; set; }

        public string ProductName { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string GlobalCategory { get; set; } = null!;

        public string Size { get; set; } = null!;

        public string ShortDescription { get; set; } = null!;

        public string ReleasedOn { get; set; } = null!;

        public string? Description { get; set; }

        public string Category { get; set; } = null!;

        public int DiscountPercentage { get; set; }

        public int Rating { get; set; }

        public decimal PromotionalPrice {  get; set; }
        
        public List<ReviewViewModel>? Reviews { get; set; }
    }
}
