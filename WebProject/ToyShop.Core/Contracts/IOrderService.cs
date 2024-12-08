using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IOrderService
    {
        public Task<OrderDisplayViewModel> GetPaginatedUserOrdersAsync(Guid userId, int pageNumber, DateTime? startDate, DateTime? endDate, string? status);

        public Task<OrderViewModel> GetOrderForDetailsAsync(Guid userId, string orderNumber);

        public Task<OrderViewModel> CheckOrderAsync(Guid userId, List<ProductInfoViewModel> products);

        public Task<string> FinishOrderAsync(Guid userId, OrderViewModel order);

        public Task CancelOrderAsync(Guid userId, Guid orderId);

        public Task<OrderViewModel> GetOrderForEditAsync(Guid userId, Guid orderId);

        public Task EditOrderAsync(Guid userId, OrderViewModel order);
    }
}
