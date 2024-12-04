using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToyShop.Data.Models
{
    public class OrderProduct
    {
        [Required]
        [Comment("Foreign Key reference to the Order")]
        public Guid OrderId { get; set; } 

        [ForeignKey(nameof(OrderId))]
        // Navigation property for the associated order, not stored directly in the database.
        public Order Order { get; set; } = null!;

        [Comment("Foreign Key reference to the Product in the order")]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        // Navigation property for the associated product, not stored directly in the database.
        public Product Product { get; set; } = null!;

        [Comment("Quantity of the bought products of same type")]
        public int BoughtQuantity { get; set; }
    }
}
