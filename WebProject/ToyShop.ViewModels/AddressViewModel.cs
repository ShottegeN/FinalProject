using System.ComponentModel.DataAnnotations;
using ToyShop.Common.EntityConstraints;
using static ToyShop.Common.EntityConstraints.AddressConstraints;
namespace ToyShop.ViewModels
{
    public class AddressViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето е задължително!")]
        [StringLength(StreetNameMaxLength, MinimumLength = StreetNameMinLength, ErrorMessage = "Името на улицата трябва да е между {2} и {1} символа!")]
        public string StreetName { get; set; } = null!;

        [Range(typeof(int), IntMinValue, IntMaxValue, ErrorMessage = "Номерът трябва да бъде между {1} и {2}!")]
        public int Number { get; set; }
        
        public int? BuildingNumber { get; set; }

        [MaxLength(EntranceMaxLength)]
        public string? Entrance { get; set; }

        [MaxLength(OtherInfoMaxLength)]
        public string? OtherAddressInformation { get; set; }

        public int CityId { get; set; }

        [StringLength(CityConstraints.NameMaxLength, MinimumLength = CityConstraints.NameMinLength, ErrorMessage = "Името на града трябва да е между {2} и {1} символа!")]
        public string CityName { get; set; } = null!;

        [StringLength(CityConstraints.PostCodeMaxLength, MinimumLength = CityConstraints.PostCodeMinLength, ErrorMessage = "Пощенският код трябва да е между {2} и {1} символа!")]
        public string PostCode { get; set; } = null!;
    }
}
