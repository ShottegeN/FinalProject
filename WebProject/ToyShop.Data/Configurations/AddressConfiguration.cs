using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToyShop.Data.Models;

namespace ToyShop.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datasets", "Addresses.json");

            string data = File.ReadAllText(path);
            var addresses = JsonSerializer.Deserialize<List<Address>>(data);

            if (addresses != null)
            {
                builder
                .HasData(addresses);
            }
        }
    }
}
