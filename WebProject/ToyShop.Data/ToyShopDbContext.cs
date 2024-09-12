using Microsoft.EntityFrameworkCore;
using ToyShop.Data.Models;

namespace ToyShop.Data
{
    public class ToyShopDbContext : DbContext
    {
        public ToyShopDbContext(DbContextOptions<ToyShopDbContext> options)
            : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Coupon> Coupons { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>()
                .Property(c => c.IsActive)
                .HasDefaultValue(false);

            modelBuilder.Entity<Product>()
                .Property(p => p.IsAvailable)
                .HasDefaultValue(true);

            modelBuilder.Entity<User>()
                .Property(u => u.IsActive)
                .HasDefaultValue(true);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<UserProduct>()
                .HasKey(up => new { up.UserId, up.ProductId });

            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });

            // Configure foreign keys to not use cascading deletes
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.DeliveryAddress)
                .WithMany(a => a.Orders)
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Coupon)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CouponId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
