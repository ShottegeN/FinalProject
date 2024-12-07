namespace ToyShop.ViewModels
{
    public class ProductInfoViewModel
    {      
        public Guid Id { get; set; }

        public string ProductName { get; set; } = String.Empty;
        
        public string? ImageUrl { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string GlobalCategory { get; set; } = String.Empty;

        public string Size { get; set; } = String.Empty;

        public string ShortDescription { get; set; } = String.Empty;

        public string ReleasedOn { get; set; } = String.Empty;

        public string? Description { get; set; }

        public string Category { get; set; } = String.Empty;

        public int DiscountPercentage { get; set; }

        public int BoughtQuantity { get; set; }

        public double Rating { get; set; }

        public decimal PromotionalPrice {  get; set; }
        
        public List<ReviewViewModel>? Reviews { get; set; }
    }
}
