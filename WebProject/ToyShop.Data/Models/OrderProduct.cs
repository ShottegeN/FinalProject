using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToyShop.Data.Models
{
    public class OrderProduct
    {
        [Comment("Foreign Key reference to the Order entity")]
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        // Navigation property for the associated order, not stored directly in the database.
        public Order Order { get; set; } = null!;

        [Comment("Foreign Key reference to the Product entity")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        // Navigation property for the associated product, not stored directly in the database.
        public Product Product { get; set; } = null!;

        [Comment("Quantity of the product in the order")]
        public int Quantity { get; set; }
    }
}
