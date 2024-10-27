using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Category
    {
        [Key]
        [Comment("Primary Key for the Category entity")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryConstraints.NameMaxLength)]
        [Comment("Name of the category with a maximum length constraint")]
        public string Name { get; set; } = null!;

        // Navigation property for the collection of products that belong to this category.
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
