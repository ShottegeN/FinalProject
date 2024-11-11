using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyShop.Data.Models
{
    public class ShoppingCartProduct
    {
        [Comment("Foreign Key reference to the ShoppingCart")]
        public Guid ShoppingCartId { get; set; }

        [ForeignKey(nameof(ShoppingCartId))]
        // Navigation property for the associated shopping cart, not stored directly in the database.
        public ShoppingCart ShoppingCart { get; set; } = null!;

        [Comment("Foreign Key reference to the Product in the shopping cart")]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        // Navigation property for the associated product in the shopping cart, not stored directly in the database.
        public Product Product { get; set; } = null!;
    }
}
