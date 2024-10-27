using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Review
    {
        [Key]
        [Comment("Primary Key for the Review entity")]
        public int Id { get; set; }

        [Comment("Foreign Key reference to the Product being reviewed")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        // Navigation property for the associated product of this review, not stored directly in the database.
        public Product Product { get; set; } = null!;

        [Required]
        [Comment("Foreign Key reference to the User who wrote the review")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        // Navigation property for the associated user of this review, not stored directly in the database.
        public User User { get; set; } = null!;

        [MaxLength(ReviewConstraints.CommentMaxLength)]
        [Comment("Optional comment made by the user in the review with a maximum length constraint")]
        public string? Comment { get; set; }

        [Comment("Rating given by the user for the product")]
        public int Rating { get; set; }
    }
}
