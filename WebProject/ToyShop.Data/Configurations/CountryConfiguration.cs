using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToyShop.Data.Models;

namespace ToyShop.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datasets", "Countries.json");

            string data = File.ReadAllText(path);
            var cinemas = JsonSerializer.Deserialize<List<Country>>(data);

            if (cinemas != null)
            {
                builder
                .HasData(cinemas);
            }
        }
    }
}
