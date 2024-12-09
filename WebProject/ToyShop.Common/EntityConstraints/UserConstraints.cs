namespace ToyShop.Common.EntityConstraints
{
    public static class UserConstraints
    {
        public const byte UsernameMinLength = 5;
        public const byte UsernameMaxLength = 10;

        public const byte PasswordMinLength = 5;
        public const byte PasswordMaxLength = 20;

        public const byte FirstNameMinLength = 2;
        public const byte FirstNameMaxLength = 20;

        public const byte LastNameMinLength = 2;
        public const byte LastNameMaxLength = 20;

        public const string AgeMin = "1";
        public const string AgeMax = "110";

        public const byte PhoneNumberMinLength = 6;
        public const byte PhoneNumberMaxLength = 10;

        public const byte EmailMaxLength = 20;
    }

}
