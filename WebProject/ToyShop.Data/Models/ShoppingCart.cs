using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyShop.Data.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        public ICollection<ShoppingCartProduct> ShoppingCartProducts { get; set; } = new HashSet<ShoppingCartProduct>();
    }

}
