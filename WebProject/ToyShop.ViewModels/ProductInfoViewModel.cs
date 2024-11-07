namespace ToyShop.ViewModels
{
    public class ProductInfoViewModel
    {
        public int Id { get; set; }

        public required string ProductName { get; set; }

        public string? ImageUrl { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string ShortDescription { get; set; } = null!;

        public string? Description { get; set; }
    }
}
