using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(AddressConstraints.StreetMaxLength)]
        public string StreetName { get; set; } = null!;

        public int Number { get; set; }

        public int? BuildingNumber { get; set; }

        [MaxLength(AddressConstraints.EntranceMaxLength)]
        public string? Entrance { get; set; }

        [MaxLength(AddressConstraints.OtherInfoMaxLength)]
        public string? OtherAddressInformation { get; set; }

        public int CityId { get; set; }

        [Required]
        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
