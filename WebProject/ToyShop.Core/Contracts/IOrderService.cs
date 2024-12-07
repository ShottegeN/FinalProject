using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IOrderService
    {
        public Task<List<OrderViewModel>> GetAllUserOrdersAsync(Guid userId);

        public Task<OrderViewModel> GetOrderByNumberAsync(Guid userId, string orderNumber);

        public Task<OrderViewModel> CheckOrderAsync(Guid userId, List<ProductInfoViewModel> products);

        public Task<string> FinishOrderAsync(Guid userId, OrderViewModel order);
    }
}
