using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Promotion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(PromotionConstraints.NameMaxLength)]
        public string Name { get; set; } = null!;
        
        public int DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
