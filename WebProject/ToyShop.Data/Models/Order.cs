using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToyShop.Common.EntityConstraints;
using ToyShop.Data.Models.Enumerations;

namespace ToyShop.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(OrderConstraints.OrderNumberMaxLength)]
        public string Number { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal DeliveryPrice { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? SendingDate { get; set; }

        public OrderStatus Status { get; set; }

        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address DeliveryAddress { get; set; } = null!;

        public int? CouponId { get; set; }

        public Coupon? Coupon { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        public ICollection<OrderProduct> OrdersProducts { get; set; } = new HashSet<OrderProduct>();
    }
}