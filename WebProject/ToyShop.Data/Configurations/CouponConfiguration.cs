using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToyShop.Data.Models;

namespace ToyShop.Data.Configurations
{
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datasets", "Coupons.json");

            string data = File.ReadAllText(path);
            var cinemas = JsonSerializer.Deserialize<List<Coupon>>(data);

            if (cinemas != null)
            {
                builder
                .HasData(cinemas);
            }
        }
    }
}
