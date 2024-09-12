using System.ComponentModel.DataAnnotations.Schema;

namespace ToyShop.Data.Models
{
    public class OrderProduct
    {
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }
    }
}