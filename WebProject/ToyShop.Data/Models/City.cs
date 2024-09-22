using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CityConstraints.NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(CityConstraints.PostCodeMaxLength)]
        public string PostCode { get; set; } = null!;

        public int CountryId { get; set; }
        
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
