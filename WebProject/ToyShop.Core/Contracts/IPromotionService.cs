using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IPromotionService
    {
        public Task<IEnumerable<PromotionViewModel>> GetActivePromotionsAsync();
    }
}
