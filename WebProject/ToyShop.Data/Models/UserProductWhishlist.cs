using System.ComponentModel.DataAnnotations.Schema;

namespace ToyShop.Data.Models
{
    public class UserProductWhishlist
    {
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
