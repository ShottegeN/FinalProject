using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;
using ToyShop.Data.Models.Enumerations;

namespace ToyShop.Data.Models
{
    public class Product
    {
        [Key]
        [Comment("Primary Key for the Product entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ProductConstraints.NameMaxLength)]
        [Comment("Name of the product with a maximum length constraint")]
        public string Name { get; set; } = null!;

        [Comment("Quantity of the product available in stock")]
        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        [Comment("Price of the product in monetary terms")]
        public decimal Price { get; set; }

        [Comment("Url of the product image")]
        public string? ImageUrl { get; set; }

        [Comment("Global category of the product")]
        public GlobalCategory GlobalCategory { get; set; }

        [Comment("Foreign Key reference to the Category entity")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        // Navigation property for the associated category of the product, not stored directly in the database.
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

        // Navigation property for the associated promotion, not stored directly in the database.
        public Promotion? Promotion { get; set; }

        // Navigation property for the collection of user-product wishlist entries associated with this product.
        public ICollection<UserProductWhishlist> UsersProducts { get; set; } = new HashSet<UserProductWhishlist>();

        // Navigation property for the collection of reviews associated with this product.
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        // Navigation property for the collection of order-product relationships associated with this product.
        public ICollection<OrderProduct> OrdersProducts { get; set; } = new HashSet<OrderProduct>();

        [Comment("Indicates if the product is currently available for purchase")]
        public bool IsAvailable { get; set; } = true;
    }
}
