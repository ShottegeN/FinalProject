using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;
using ToyShop.Data.Models.Enumerations;

namespace ToyShop.Data.Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
            ReleasedOn = DateTime.Now;
        }

        [Key]
        [Comment("Primary Key for the Product entity")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(ProductConstraints.NameMaxLength)]
        [Comment("Name of the product with a maximum length constraint")]
        public string Name { get; set; } = null!;

        [Comment("Quantity of the product available in stock")]
        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        [Comment("Price of the product in monetary terms")]
        public decimal Price { get; set; }        

        [Required]
        [MaxLength(ProductConstraints.SizeMaxLength)]
        [Comment("Size of the product with a maximum length constraint")]
        public string Size { get; set; } = null!;

        [Comment("The date when the product was released")]
        public DateTime ReleasedOn { get; set; }

        [Comment("Url of the product image")]
        public string? ImageUrl { get; set; }

        [Comment("Global category of the product")]
        public GlobalCategory GlobalCategory { get; set; }

        [Comment("Foreign Key reference to the Category entity")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [MaxLength(ProductConstraints.ShortDescriptionMaxLength)]
        [Comment("Short description of the product with a maximum length constraint")]
        public string ShortDescription { get; set; } = null!;

        [MaxLength(ProductConstraints.DescriptionMaxLength)]
        [Comment("Optional detailed description of the product with a maximum length constraint")]
        public string? Description { get; set; }

        [Comment("Optional foreign Key reference to the Promotion entity")]
        public int? PromotionId { get; set; }

        public Promotion? Promotion { get; set; }

        public ICollection<UserProductWhishlist> UsersProducts { get; set; } = new HashSet<UserProductWhishlist>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public ICollection<OrderProduct> OrdersProducts { get; set; } = new HashSet<OrderProduct>();

        [Comment("Indicates if the product is currently available for purchase")]
        public bool IsAvailable { get; set; } = true;
    }
}
