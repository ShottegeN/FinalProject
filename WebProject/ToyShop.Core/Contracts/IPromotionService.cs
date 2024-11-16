using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IPromotionService
    {
        public Task<List<PromotionViewModel>> GetActivePromotionsAsync();
    }
}
