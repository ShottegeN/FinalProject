using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderViewModel>> GetAllUserOrdersAsync(Guid userId);

        public Task<OrderViewModel> GetOrderByIdAsync(Guid userId, Guid orderId);

        public Task<OrderViewModel> CheckOrderAsync(Guid userId, IEnumerable<ProductInfoViewModel> products);

        public Task<OrderViewModel> FinishOrderAsync(Guid userId);
    }
}
