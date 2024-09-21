using System.ComponentModel.DataAnnotations;
using ToyShop.Common.EntityConstraints;

namespace ToyShop.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(CategoryConstraints.NameMaxLength)]
        public string Name { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
