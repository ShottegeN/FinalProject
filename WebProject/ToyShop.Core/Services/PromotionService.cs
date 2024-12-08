using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common;
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

        public async Task<PromotionViewModel> GetPromotionByIdAsync(int id)
        {
            var promotion = await repo.GetByIdAsync<Promotion>(id);

            if (promotion == null)
            {
                throw new ArgumentNullException("Ресурсът не е намерен!");
            }

            return new PromotionViewModel
            {
                Id = promotion.Id,
                Name = promotion.Name,
                ImageUrl = promotion.ImageUrl,
                DiscountPercentage = promotion.DiscountPercentage,
                StartDate = promotion.StartDate,
                EndDate = promotion.EndDate,
            };
        }

        public async Task AddPromotionAsync(PromotionViewModel p)
        {
            if (p == null) throw new ArgumentNullException("Невалидна операция");

            if (p.StartDate > p.EndDate) throw new CustomException("Началната дата не може да е след крайната дата!", "StartDate");

            var promotion = new Promotion
            {
                Name = p.Name,
                ImageUrl = p.ImageUrl,
                DiscountPercentage = p.DiscountPercentage,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
            };

            await repo.AddAsync(promotion);
            await repo.SaveChangesAsync();         
        }

        public async Task EditPromotionAsync(PromotionViewModel p)
        {
            if (p == null) throw new ArgumentNullException("Невалидна операция");

            if (p.StartDate > p.EndDate) throw new CustomException("Началната дата не може да е след крайната дата!", "StartDate");

            var promotion = await repo.GetByIdAsync<Promotion>(p.Id);

            if (promotion == null)
            {
                throw new ArgumentNullException("Ресурсът не е намерен!");
            }

            promotion.Name = p.Name;
            promotion.ImageUrl = p.ImageUrl;
            promotion.DiscountPercentage = p.DiscountPercentage;
            promotion.StartDate = p.StartDate;
            promotion.EndDate = p.EndDate;

            await repo.UpdateAsync(promotion);
            await repo.SaveChangesAsync();
        }

        public async Task RemovePromotionAsync(int id)
        {
            var promotion = await repo.AllReadonlyAsync<Promotion>()
                .Where(p => p.Id == id)
                .Include(p => p.Products)
                .FirstOrDefaultAsync();

            if (promotion == null)
            {
                throw new ArgumentNullException("Ресурсът не е намерен!");
            }

            if (promotion.Products.Any())
            {
                foreach (var product in promotion.Products)
                {
                    product.PromotionId = null;
                    await repo.UpdateAsync(product);
                }
            }
            await repo.RemoveAsync(promotion);
            await repo.SaveChangesAsync();
        }
        public async Task<IEnumerable<PromotionViewModel>> GetAllPromotionsAsync()
        {
            var promotions = await repo.AllReadonlyAsync<Promotion>()               
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

            return promotions;
        }
    }
}
