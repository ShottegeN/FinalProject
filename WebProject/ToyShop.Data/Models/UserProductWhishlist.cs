using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToyShop.Data.Models
{
    public class UserProductWhishlist
    {
        [Required]
        [Comment("Foreign Key reference to the User who owns the wishlist")]
        public Guid UserId { get; set; } 

        [ForeignKey(nameof(UserId))]
        // Navigation property for the associated user, not stored directly in the database.
        public User User { get; set; } = null!;

        [Comment("Foreign Key reference to the Product in the wishlist")]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        // Navigation property for the associated product, not stored directly in the database.
        public Product Product { get; set; } = null!;
    }
}
