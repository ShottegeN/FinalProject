using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IOrderService
    {
        public Task<List<OrderViewModel>> GetAllUserOrdersAsync(Guid userId);

        public Task<OrderViewModel> GetOrderByIdAsync(Guid userId, Guid orderId);

        public Task<OrderViewModel> CheckOrderAsync(Guid userId, List<ProductInfoViewModel> products);

        public Task FinishOrderAsync(Guid userId, OrderViewModel order);
    }
}
