using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToyShop.Data.Models;

namespace ToyShop.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datasets", "Cities.json");

            string data = File.ReadAllText(path);
            var cinemas = JsonSerializer.Deserialize<List<City>>(data);

            if (cinemas != null)
            {
                builder
                .HasData(cinemas);
            }
        }
    }
}
