using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Coupon
    {
        [Key]
        [Comment("Primary Key for the Coupon entity")]
        public int Id { get; set; }

        [Required]
        [StringLength(CouponConstraints.CodeMaxLength)]
        [Comment("Unique code for the coupon with a maximum length constraint")]
        public string Code { get; set; } = null!;

        [Comment("Optional discount percentage for the coupon")]
        public int? DiscountPercentage { get; set; }

        [Column(TypeName = "money")]
        [Comment("Optional discount value for the coupon in monetary terms")]
        public decimal? DiscountValue { get; set; }

        // Navigation property for the collection of orders associated with this coupon.
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        [Comment("Indicates if the coupon is currently active")]
        public bool IsActive { get; set; } = false;
    }
}
