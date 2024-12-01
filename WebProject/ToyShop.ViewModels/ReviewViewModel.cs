namespace ToyShop.ViewModels
{
    public class ReviewViewModel
    {
        public Guid Id { get; set; }

        public int Rating { get; set; }

        public string? UserFullName { get; set; }

        public string? Comment { get; set; } = null!;
    }
}