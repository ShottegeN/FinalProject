using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Address
    {
        [Key]
        [Comment("Primary Key for the Address entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AddressConstraints.StreetNameMaxLength)]
        [Comment("Street name of the address with a maximum length constraint")]
        public string StreetName { get; set; } = null!;

        [Comment("House number or address number")]
        public int Number { get; set; }

        [Comment("Optional building number")]
        public int? BuildingNumber { get; set; }

        [MaxLength(AddressConstraints.EntranceMaxLength)]
        [Comment("Optional entrance information for the address")]
        public string? Entrance { get; set; }

        [MaxLength(AddressConstraints.OtherInfoMaxLength)]
        [Comment("Optional additional information for the address")]
        public string? OtherAddressInformation { get; set; }

        [Comment("Foreign Key reference to the City entity")]
        public int CityId { get; set; }

        [Required]
        [ForeignKey(nameof(CityId))]
        // Navigation property for the related City entity, not stored directly in the database.
        public City City { get; set; } = null!;

        // Navigation property for the collection of orders associated with this address.
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        // Navigation property for the collection of users associated with this address.
        public ICollection<User> Users { get; set; } = new HashSet<User>();
       
    }
}
