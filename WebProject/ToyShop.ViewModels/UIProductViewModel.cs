using System.ComponentModel.DataAnnotations;
using ToyShop.Common.EntityConstraints;
using static ToyShop.Common.EntityConstraints.ProductConstraints;

namespace ToyShop.ViewModels
{
    public class UIProductViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = "Името трябва да е между {2} и {1} символа!")]
        public string ProductName { get; set; } = null!;

        [MaxLength(ImageUrlMaxLength, ErrorMessage = "Пътят на изображението не трябва да надвишава {1} символа!")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Range(typeof(int), MinQuantity, MaxQuantity, ErrorMessage = "Цената трябва да бъде между {1} и {2}!")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Range(typeof(decimal), MinPrice, MaxPrice, ErrorMessage = "Цената трябва да бъде между {1} и {2}!")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [StringLength(SizeMaxLength, MinimumLength = SizeMinLength, ErrorMessage = "Размерът трябва да е между {2} и {1} символа!")]
        public string Size { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително!")]
        public string GlobalCategory { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително!")]
        [StringLength(ShortDescriptionMaxLength, MinimumLength = ShortDescriptionMinLength, ErrorMessage = "Краткото описание трябва да е между {2} и {1} символа!")]
        public string ShortDescription { get; set; } = null!;

        [MaxLength(DescriptionMaxLength, ErrorMessage = "Описанието не трябва да надвишава {1} символа!")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        public string Category { get; set; } = null!;
    }
}
