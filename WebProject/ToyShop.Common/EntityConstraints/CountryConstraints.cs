namespace ToyShop.Common.EntityConstraints
{
    public static class CountryConstraints
    {
        public const byte NameMinLength = 2;
        public const byte NameMaxLength = 50;

        public const byte ISOCodeMinLength = 2;
        public const byte ISOCodeMaxLength = 3;

        public const byte PhoneCodeMinLength = 2;
        public const byte PhoneCodeMaxLength = 10;

        public const byte CurrencyMinLength = 2;
        public const byte CurrencyMaxLength = 20;

        public const byte ContinentMinLength = 2;
        public const byte ContinentMaxLength = 20;

        public const byte RegionMinLength = 1;
        public const byte RegionMaxLength = 30;
    }
}
