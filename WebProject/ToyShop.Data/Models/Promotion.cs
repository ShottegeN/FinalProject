using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Promotion
    {
        [Key]
        [Comment("Primary Key for the Promotion entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(PromotionConstraints.NameMaxLength)]
        [Comment("Name of the promotion with a maximum length constraint")]
        public string Name { get; set; } = null!;

        [Comment("Imgage Url of the promotion")]
        public string? ImageUrl { get; set; }

        [Comment("Discount percentage offered by the promotion")]
        public int DiscountPercentage { get; set; }

        [Comment("Start date of the promotion")]
        public DateTime StartDate { get; set; }

        [Comment("End date of the promotion")]
        public DateTime EndDate { get; set; }

        // Navigation property for the collection of products associated with this promotion.
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
