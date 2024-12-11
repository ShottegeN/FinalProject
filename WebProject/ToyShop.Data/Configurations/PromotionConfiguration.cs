using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToyShop.Data.Models;

namespace ToyShop.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datasets", "Promotions.json");

            string data = File.ReadAllText(path);
            var promotions = JsonSerializer.Deserialize<List<Promotion>>(data);

            if (promotions != null)
            {
                builder
                .HasData(promotions);
            }
        }
    }
}
