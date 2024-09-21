using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [MaxLength(ReviewConstraints.CommentMaxLength)]
        public string? Comment { get; set; }
        public int Rating { get; set; } 
    }
}
