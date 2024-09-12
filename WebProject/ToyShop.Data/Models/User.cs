using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToyShop.Common.EntityConstraints;
using ToyShop.Data.Models.Enumerations;

namespace ToyShop.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(UserConstraints.UsernameMaxLength)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(UserConstraints.PasswordMaxLength)]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(UserConstraints.FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(UserConstraints.LastNameMaxLength)]
        public string LastName { get; set; } = null!;
        
        public int Age { get; set; }

        public Gender Gender { get; set; }

        [Required]
        [MaxLength(UserConstraints.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MaxLength(UserConstraints.EmailMaxLength)]
        public string Email { get; set; } = null!;

        public DateTime RegistrationDate { get; set; }

        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!;
        
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public ICollection<UserProduct> UsersProducts { get; set; } = new HashSet<UserProduct>();
        
        public bool IsActive { get; set; } = true;
    }
}
