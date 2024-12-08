namespace ToyShop.ViewModels
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? SendingDate { get; set; }

        public string DeliveryType { get; set; } = string.Empty;

        public string OrderStatus { get; set; } = string.Empty;

        public AddressViewModel DeliveryAddress { get; set; } = null!;

        public Guid UserId { get; set; }

        public string UserFullName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;

        public List<ProductInfoViewModel> Products { get; set; } = new ();
    }
}
