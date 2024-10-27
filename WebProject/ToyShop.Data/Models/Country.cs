using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Country
    {
        [Key]
        [Comment("Primary Key for the Country entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CountryConstraints.NameMaxLength)]
        [Comment("Name of the country with a maximum length constraint")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(CountryConstraints.ISOCodeMaxLength)]
        [Comment("ISO code of the country with a maximum length constraint")]
        public string ISOCode { get; set; } = null!;

        [Required]
        [MaxLength(CountryConstraints.CurrencyMaxLength)]
        [Comment("Currency used in the country with a maximum length constraint")]
        public string Currency { get; set; } = null!;

        [MaxLength(CountryConstraints.PhoneCodeMaxLength)]
        [Comment("Optional phone code of the country with a maximum length constraint")]
        public string? PhoneCode { get; set; }

        [MaxLength(CountryConstraints.ContinentMaxLength)]
        [Comment("Optional continent of the country with a maximum length constraint")]
        public string? Continent { get; set; }

        [MaxLength(CountryConstraints.RegionMaxLength)]
        [Comment("Optional region of the country with a maximum length constraint")]
        public string? Region { get; set; }

        [Comment("Indicates if the country is active")]
        public bool IsActive { get; set; }

        // Navigation property for the collection of cities associated with this country.
        public ICollection<City> Cities { get; set; } = new HashSet<City>();
    }
}
