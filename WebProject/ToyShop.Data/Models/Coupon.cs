using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CouponConstraints.CodeMaxLength)]
        public string Code { get; set; } = null!;

        public int? DiscountPercentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountValue { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public bool IsActive { get; set; } = false;
    }
}