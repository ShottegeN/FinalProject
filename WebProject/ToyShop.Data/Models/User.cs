using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;
using ToyShop.Data.Models.Enumerations;

namespace ToyShop.Data.Models
{
    public class User
    {
        [Key]
        [Comment("Primary Key for the User entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(UserConstraints.UsernameMaxLength)]
        [Comment("Username of the user, required with a maximum length constraint")]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(UserConstraints.PasswordMaxLength)]
        [Comment("Password of the user, required with a maximum length constraint")]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(UserConstraints.FirstNameMaxLength)]
        [Comment("First name of the user, required with a maximum length constraint")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(UserConstraints.LastNameMaxLength)]
        [Comment("Last name of the user, required with a maximum length constraint")]
        public string LastName { get; set; } = null!;

        [Comment("Age of the user")]
        public int Age { get; set; }

        [Comment("Gender of the user")]
        public Gender Gender { get; set; }

        [Required]
        [MaxLength(UserConstraints.PhoneNumberMaxLength)]
        [Comment("Phone number of the user, required with a maximum length constraint")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MaxLength(UserConstraints.EmailMaxLength)]
        [Comment("Email address of the user, required with a maximum length constraint")]
        public string Email { get; set; } = null!;

        [Comment("Registration date of the user")]
        public DateTime RegistrationDate { get; set; }

        [Comment("Foreign Key reference to the Address of the user")]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        // Navigation property for the associated address of the user, not stored directly in the database.
        public Address Address { get; set; } = null!;

        // Navigation property for the collection of orders placed by the user.
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        // Navigation property for the collection of reviews made by the user.
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        // Navigation property for the user's product wishlist.
        public ICollection<UserProductWhishlist> UsersProducts { get; set; } = new HashSet<UserProductWhishlist>();

        [Comment("Indicates if the user account is active")]
        public bool IsActive { get; set; } = true;
    }
}
