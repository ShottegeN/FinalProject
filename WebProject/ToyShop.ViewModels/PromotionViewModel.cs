using System.ComponentModel.DataAnnotations;
using static ToyShop.Common.EntityConstraints.PromotionConstraints;

namespace ToyShop.ViewModels
{
    public class PromotionViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = "Името трябва да е между {2} и {1} символа!")]
        public string Name { get; set; } = null!;

        [MaxLength(ImageUrlMaxLength, ErrorMessage = "Пътят на изображението не трябва да надвишава {1} символа!")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [Range(typeof(int), DiscountPercentageMinValue, DiscountPercentageMaxValue, ErrorMessage = "Процента отстъпка трябва да бъде между {1} и {2}!")]
        public int DiscountPercentage { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        public DateTime EndDate { get; set; }

        public TimeSpan Duration => EndDate - StartDate;
    }
}
