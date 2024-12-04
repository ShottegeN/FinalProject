using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class City
    {
        [Key]
        [Comment("Primary Key for the City entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CityConstraints.NameMaxLength)]
        [Comment("Name of the city with a maximum length constraint")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(CityConstraints.PostCodeMaxLength)]
        [Comment("Post code of the city with a maximum length constraint")]
        public string PostCode { get; set; } = null!;

        [Comment("Foreign Key reference to the Country entity")]
        public int CountryId { get; set; }       

        // Navigation property for the collection of addresses associated with this city.
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
