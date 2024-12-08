using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IOrderService
    {
        public Task<OrderDisplayViewModel> GetPaginatedUserOrdersAsync(Guid userId, int pageNumber, DateTime? startDate, DateTime? endDate, string? status);

        public Task<OrderViewModel> GetOrderByNumberAsync(Guid userId, string orderNumber);

        public Task<OrderViewModel> CheckOrderAsync(Guid userId, List<ProductInfoViewModel> products);

        public Task<string> FinishOrderAsync(Guid userId, OrderViewModel order);
    }
}
