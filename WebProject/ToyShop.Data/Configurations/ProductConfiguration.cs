using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToyShop.Data.Models;

namespace ToyShop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datasets", "Products.json");

            string data = File.ReadAllText(path);
            var products = JsonSerializer.Deserialize<List<Product>>(data);
            
            if (products != null)
            {
                builder
                .HasData(products);
            }
        }
    }
}
