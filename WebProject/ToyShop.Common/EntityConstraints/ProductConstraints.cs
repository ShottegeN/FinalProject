namespace ToyShop.Common.EntityConstraints
{
    public static class ProductConstraints
    {
        public const byte NameMinLength = 5;
        public const byte NameMaxLength = 50;

        public const byte SizeMinLength = 5;
        public const byte SizeMaxLength = 50;

        public const byte ShortDescriptionMinLength = 10;
        public const byte ShortDescriptionMaxLength = 150;   

        public const int DescriptionMaxLength = 500;

        public const int ImageUrlMaxLength = 2000;

        public const string MinPrice = "0.01";
        public const string MaxPrice = "1000.00";

        public const string MinQuantity = "1";
        public const string MaxQuantity = "100";
    }
}
