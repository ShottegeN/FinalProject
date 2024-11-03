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
            var cinemas = JsonSerializer.Deserialize<List<Product>>(data);
            
            if (cinemas != null)
            {
                builder
                .HasData(cinemas);
            }
        }
    }
}
