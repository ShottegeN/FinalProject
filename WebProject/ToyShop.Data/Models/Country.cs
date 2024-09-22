using System.ComponentModel.DataAnnotations;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CountryConstraints.NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(CountryConstraints.ISOCodeMaxLength)]
        public string ISOCode { get; set; } = null!;       
        
        [Required]
        [MaxLength(CountryConstraints.CurrencyMaxLength)]
        public string Currency { get; set; } = null!;

        [MaxLength(CountryConstraints.PhoneCodeMaxLength)]
        public string? PhoneCode { get; set; }

        [MaxLength(CountryConstraints.ContinentMaxLength)]
        public string? Continent { get; set; }

        [MaxLength(CountryConstraints.RegionMaxLength)]
        public string? Region { get; set; }

        public bool IsActive { get; set; }

        public ICollection<City> Cities { get; set; } = new HashSet<City>();
    }
}
