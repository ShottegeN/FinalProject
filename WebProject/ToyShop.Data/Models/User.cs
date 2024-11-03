using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;
using ToyShop.Data.Models.Enumerations;

namespace ToyShop.Data.Models
{
    public class User : IdentityUser
    {        
        // Id 
        // Username 
        // PhoneNumber 
        // Email 

        [MaxLength(UserConstraints.FirstNameMaxLength)]
        [Comment("First name of the user, required with a maximum length constraint")]
        public string? FirstName { get; set; }

        [MaxLength(UserConstraints.LastNameMaxLength)]
        [Comment("Last name of the user, required with a maximum length constraint")]
        public string? LastName { get; set; }

        [Comment("Age of the user")]
        public int? Age { get; set; }

        [Comment("Gender of the user")]
        public Gender Gender { get; set; }        

        [Comment("Registration date of the user")]
        public DateTime RegistrationDate { get; set; }

        [Comment("Foreign Key reference to the Address of the user")]
        public int? AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        [Comment("Navigation property for the associated address of the user, not stored directly in the database.")]
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
