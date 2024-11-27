namespace ToyShop.ViewModels
{
    public class ErrorViewModel
    {
        public string Title { get; set; } = "Възникна грешка";
        public string Message { get; set; } = "Нещо се обърка. Моля, опитайте отново по-късно.";
        public string? SupportContact { get; set; } = "support@toyshop.com"; // Примерен имейл за контакт
    }
}
