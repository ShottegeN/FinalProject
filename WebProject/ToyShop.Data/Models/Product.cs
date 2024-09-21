using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToyShop.Common.EntityConstraints;
using ToyShop.Data.Models.Enumerations;

namespace ToyShop.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ProductConstraints.NameMaxLength)]
        public string Name { get; set; } = null!;

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public GlobalCategory GlobalCategory { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [MaxLength(ProductConstraints.ShortDescriptionMaxLength)]
        public string ShortDescription { get; set; } = null!;

        [MaxLength(ProductConstraints.DescriptionMaxLength)]
        public string? Description { get; set; }

        public int? PromotionId { get; set; }

        public Promotion? Promotion { get; set; }

        public ICollection<UserProduct> UsersProducts { get; set; } = new HashSet<UserProduct>();

        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        public ICollection<OrderProduct> OrdersProducts { get; set; } = new HashSet<OrderProduct>();

        public bool IsAvailable { get; set; } = true;
    }
}
