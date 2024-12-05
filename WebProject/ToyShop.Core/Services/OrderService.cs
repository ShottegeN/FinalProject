using Microsoft.EntityFrameworkCore;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.Data.Models.Enumerations;
using ToyShop.ViewModels;

namespace ToyShop.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repo;

        public OrderService(IRepository _repo)
        {
            repo = _repo;
        }        

        public async Task<List<OrderViewModel>> GetAllUserOrdersAsync(Guid userId)
        {
            var orders = await repo.AllReadonlyAsync<Order>()
                .Where(o => o.UserId == userId)
                .Select(o => new OrderViewModel
                {
                    Id = o.Id,
                    Number = o.Number,
                    Price = o.Price,
                    //DeliveryAddress = o.DeliveryAddress.ToString(),
                    OrderDate = o.OrderDate,
                    SendingDate = o.SendingDate.HasValue ? o.SendingDate : null,
                    OrderSatus = o.Status.ToString(),
                    DeliveryPrice = o.DeliveryPrice,
                    Products = o.OrdersProducts.Select(op => new ProductInfoViewModel
                    {
                        Id = op.Product.Id,
                        ProductName = op.Product.Name,
                        Price = op.Product.Price,
                        BoughtQuantity = op.BoughtQuantity,
                        DiscountPercentage = op.Product.Promotion != null && op.Product.Promotion.StartDate < DateTime.Now && op.Product.Promotion.EndDate > DateTime.Now ? op.Product.Promotion.DiscountPercentage : 0,
                    }).ToList()
                })
                .OrderBy(o => o.OrderDate)
                .ToListAsync();

            return orders;
        }

        public async Task<OrderViewModel> CheckOrderAsync(Guid userId, List<ProductInfoViewModel> products)
        {
            var user = await repo.AllReadonlyAsync<User>()
                .Where(u => u.Id == userId)
                .Include(u => u.Address.City)
                .FirstOrDefaultAsync();            

            var usersProducts = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                .Where(up => up.UserId == userId)
                .ToListAsync();
            
            var order = new OrderViewModel
            {
               // Number = DateTime.Now.ToString("ddMMyyyy") + Guid.NewGuid().ToString("N").Substring(0, 6),                               
                Products = products,
                DeliveryAddress = new AddressViewModel
                {
                    StreetName = "N/A",
                    Number = 500,
                    CityName = "N/A",
                    PostCode = "N/A",
                }
            };

            foreach (var product in order.Products)
            {
                foreach (var up in usersProducts)
                {
                    if (up.ProductId == product.Id)
                    {
                        product.BoughtQuantity = up.BoughtQuantity;
                    }
                }

                if (product.PromotionalPrice != 0)
                {
                    order.Price += product.PromotionalPrice * product.BoughtQuantity;
                    continue;
                }

                order.Price += product.Price * product.BoughtQuantity;
            }

            return order;
        }        

        public async Task<OrderViewModel> FinishOrderAsync(Guid userId)
        {






            throw new NotImplementedException();
        }

        public Task<OrderViewModel> GetOrderByIdAsync(Guid userId, Guid orderId)
        {
            throw new NotImplementedException();
        }

        
    }
}
