namespace ToyShop.Common.EntityConstraints
{
    public static class PromotionConstraints
    {
        public const byte NameMinLength = 3;
        public const byte NameMaxLength = 30;

        public const int ImageUrlMaxLength = 2000;

        public const string DiscountPercentageMinValue = "1";
        public const string DiscountPercentageMaxValue = "100";
    }
}
