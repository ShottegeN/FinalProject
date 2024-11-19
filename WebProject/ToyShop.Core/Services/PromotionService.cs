using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.ViewModels;

namespace ToyShop.Core.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IRepository repo;

        public PromotionService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<PromotionViewModel>> GetActivePromotionsAsync()
        {
            var activePromotions = await repo.AllReadonlyAsync<Promotion>()
                .Where(p => p.StartDate < DateTime.Now && p.EndDate > DateTime.Now)                
                .Select(p => new PromotionViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    DiscountPercentage = p.DiscountPercentage,
                    StartDate = p.StartDate,
                    EndDate = p.EndDate,                    
                })
                .ToListAsync();

            return activePromotions;
        }
    }
}
