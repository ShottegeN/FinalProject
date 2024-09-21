using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyShop.Data.Models
{
    public class ShoppingCartProduct
    {
        [Key]
        public int Id { get; set; }
        
        public int ShoppingCartId { get; set; }

        [ForeignKey(nameof(ShoppingCartId))]
        public ShoppingCart ShoppingCart { get; set; } = null!;
        
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
        
        public int Quantity { get; set; }

        [Column(TypeName = "money")] 
        public decimal UnitPrice { get; set; }
    }
}
