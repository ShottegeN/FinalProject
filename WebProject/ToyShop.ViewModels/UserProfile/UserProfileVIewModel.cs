using System.ComponentModel.DataAnnotations;
using static ToyShop.Common.EntityConstraints.UserConstraints;

namespace ToyShop.ViewModels.UserProfile
{
    public class UserProfileViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Име")]
        [Required(ErrorMessage = "Полето е задължително!")]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = "Размерът трябва да е между {2} и {1} символа!")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Полето е задължително!")]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = "Размерът трябва да е между {2} и {1} символа!")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Полето е задължително!")]
        [Range(typeof(int), AgeMin, AgeMax, ErrorMessage = "Процента отстъпка трябва да бъде между {1} и {2}!")]
        public string Age { get; set; } = string.Empty;

        [Display(Name = "Телефонен номер")]
        [Phone(ErrorMessage = "Моля, въведете валиден телефонен номер.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Display(Name = "Имейл адрес")]
        [Required(ErrorMessage = "Полето е задължително!")]
        [EmailAddress(ErrorMessage = "Моля, въведете валиден имейл адрес.")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Адрес")]
        [MaxLength(200, ErrorMessage = "Адресът не трябва да надвишава 200 символа.")]
        public AddressViewModel Address { get; set; } = new AddressViewModel();
    }
}
