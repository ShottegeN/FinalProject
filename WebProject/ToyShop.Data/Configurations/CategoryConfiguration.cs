using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToyShop.Data.Models;

namespace ToyShop.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datasets", "Categories.json");

            string data = File.ReadAllText(path);
            var cinemas = JsonSerializer.Deserialize<List<Category>>(data);

            if (cinemas != null)
            {
                builder
                .HasData(cinemas);
            }
        }
    }
}
