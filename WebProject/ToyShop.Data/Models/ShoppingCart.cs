using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToyShop.Data.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Primary Key for the ShoppingCart entity")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Foreign Key reference to the User who owns the shopping cart")]
        public Guid UserId { get; set; } 

        [ForeignKey(nameof(UserId))]
        // Navigation property for the associated user of this shopping cart, not stored directly in the database.
        public User User { get; set; } = null!;

        // Navigation property for the collection of products in the shopping cart.
        public ICollection<ShoppingCartProduct> ShoppingCartProducts { get; set; } = new HashSet<ShoppingCartProduct>();
    }
}
