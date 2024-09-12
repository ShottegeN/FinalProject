namespace ToyShop.Common.EntityConstraints
{
    public static class ProductConstraints
    {
        public const byte NameMinLength = 5;
        public const byte NameMaxLength = 10;

        public const byte ShortDescriptionMinLength = 10;
        public const byte ShortDescriptionMaxLength = 50;   

        public const byte DescriptionMaxLength = 200;
    }
}
