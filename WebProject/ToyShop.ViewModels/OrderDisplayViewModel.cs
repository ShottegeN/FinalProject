namespace ToyShop.ViewModels
{
    public class OrderDisplayViewModel
    {
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public List<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();
    }
}
