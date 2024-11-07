namespace ToyShop.Common
{
    public static class FooterCalculations
    {
        private const int ReleaseYear = 2024;

        public static string GetFooterNote()
        {
            int currentYear = DateTime.UtcNow.Year;

            if (ReleaseYear != currentYear)
            {
                return $"{ReleaseYear} - {currentYear}";
            }

            return ReleaseYear.ToString();
        }
    }    
}
