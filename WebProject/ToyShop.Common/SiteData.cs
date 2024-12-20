﻿namespace ToyShop.Common
{
    public static class SiteData
    {
        private const int ReleaseYear = 2024;
        private const string Address = "8000 Бургас бул. Тракия №23";
        private const string Email = "real&magic@email.com";
        private const string PhoneNumber = "+359-876-678-407";
        private const string AboutUs = "Радостта на най-малките е наш приоритет.";

        public static string GetAboutUs() => AboutUs;
        public static string GetAddress() => Address;
        public static string GetEmail() => Email;
        public static string GetPhoneNumber() => PhoneNumber;

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
