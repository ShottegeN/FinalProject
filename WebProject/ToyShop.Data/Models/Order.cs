﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;
using ToyShop.Data.Models.Enumerations;

namespace ToyShop.Data.Models
{
    public class Order
    {
        [Key]
        [Comment("Primary Key for the Order entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(OrderConstraints.OrderNumberMaxLength)]
        [Comment("Unique order number with a maximum length constraint")]
        public string Number { get; set; } = null!;

        [Column(TypeName = "money")]
        [Comment("Total price of the order in monetary terms")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        [Comment("Delivery price associated with the order")]
        public decimal DeliveryPrice { get; set; }

        [Comment("Date when the order was placed")]
        public DateTime OrderDate { get; set; }

        [Comment("Optional date when the order was sent")]
        public DateTime? SendingDate { get; set; }

        [Comment("Current status of the order")]
        public OrderStatus Status { get; set; }

        [Comment("Foreign Key reference to the Address entity for delivery")]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        // Navigation property for the delivery address associated with this order, not stored directly in the database.
        public Address DeliveryAddress { get; set; } = null!;

        [Comment("Optional foreign Key reference to the Coupon entity")]
        public int? CouponId { get; set; }

        // Navigation property for the associated coupon, not stored directly in the database.
        public Coupon? Coupon { get; set; }

        [Required]
        [Comment("Foreign Key reference to the User entity who placed the order")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        // Navigation property for the user who placed the order, not stored directly in the database.
        public User User { get; set; } = null!;

        // Navigation property for the collection of order-product relationships associated with this order.
        public ICollection<OrderProduct> OrdersProducts { get; set; } = new HashSet<OrderProduct>();
    }
}
