using ToyShop.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IPromotionService
    {
        public Task<IEnumerable<PromotionViewModel>> GetActivePromotionsAsync();

        public Task AddPromotionAsync(PromotionViewModel model);

        public Task EditPromotionAsync(PromotionViewModel model);

        public Task RemovePromotionAsync(int id);

        public Task<PromotionViewModel> GetPromotionByIdAsync(int id);

        public Task<IEnumerable<PromotionViewModel>> GetAllPromotionsAsync();

    }
}
