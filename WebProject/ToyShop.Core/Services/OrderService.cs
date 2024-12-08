﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToyShop.Common;
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
        private readonly UserManager<User> userManager;

        public OrderService(IRepository _repo, UserManager<User> _userManager)
        {
            repo = _repo;
            userManager = _userManager;
        }

        public async Task<OrderDisplayViewModel> GetPaginatedUserOrdersAsync(Guid userId, int pageNumber = 1, DateTime? startDate = null, DateTime? endDate = null)
        {
            int pageSize = 5;

            var ordersQuery = repo.AllReadonlyAsync<Order>(); 

            var user = await userManager.FindByIdAsync(userId.ToString());

            if (user != null)
            {
                var roles = await userManager.GetRolesAsync(user);

                if (roles.Contains("Administrator") && !roles.Contains("Moderator"))
                {
                    ordersQuery = repo.AllReadonlyAsync<Order>()
                        .Where(o => o.UserId == userId);
                }

            }

            if (startDate.HasValue)
            {
                ordersQuery = ordersQuery.Where(o => o.OrderDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                ordersQuery = ordersQuery.Where(o => o.OrderDate <= endDate.Value);
            }

            int totalOrders = await ordersQuery.CountAsync();
            int totalPages = (int)Math.Ceiling(totalOrders / (double)pageSize);

            var orders = await ordersQuery
                .OrderBy(o => o.OrderDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(o => new OrderViewModel
                {
                    Id = o.Id,
                    Number = o.Number,
                    TotalPrice = o.TotalPrice,
                    OrderDate = o.OrderDate,
                    SendingDate = o.SendingDate,
                    OrderStatus = OrderStatusTranslator.Translate(o.Status),
                    DeliveryPrice = o.DeliveryPrice,
                })
                .ToListAsync();

            return new OrderDisplayViewModel
            {
                PageNumber = pageNumber,
                TotalPages = totalPages,
                StartDate = startDate,
                EndDate = endDate,
                Orders = orders
            };
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
            order.TotalPrice = order.Price;

            return order;
        }

        public async Task<string> FinishOrderAsync(Guid userId, OrderViewModel o)
        {
            var address = await repo.AllReadonlyAsync<Address>()
                .Where(a => a.City.Name.ToLower() == o.DeliveryAddress.CityName.ToLower())
                .Where(a => a.City.PostCode == o.DeliveryAddress.PostCode)
                .Where(a => a.StreetName.ToLower() == o.DeliveryAddress.StreetName.ToLower())
                .Where(a => a.Number == o.DeliveryAddress.Number)
                .FirstOrDefaultAsync();

            if (address == null)
            {
                var city = await repo.AllReadonlyAsync<City>()
                    .Where(c => c.Name.ToLower() == o.DeliveryAddress.CityName.ToLower())
                    .Where(c => c.PostCode == o.DeliveryAddress.PostCode)
                    .FirstOrDefaultAsync();


                if (city == null)
                {
                    city = new City
                    {
                        Name = o.DeliveryAddress.CityName,
                        PostCode = o.DeliveryAddress.PostCode,
                    };

                    await repo.AddAsync(city);
                    await repo.SaveChangesAsync();
                }

                address = new Address
                {
                    CityId = city.Id,
                    StreetName = o.DeliveryAddress.StreetName,
                    Number = o.DeliveryAddress.Number,
                    BuildingNumber = o.DeliveryAddress.BuildingNumber,
                    Entrance = o.DeliveryAddress.Entrance,
                    OtherAddressInformation = o.DeliveryAddress.OtherAddressInformation,
                };

                await repo.AddAsync(address);
                await repo.SaveChangesAsync();
            }

            var order = new Order
            {
                Number = DateTime.Now.ToString("ddMMyyyy") + Guid.NewGuid().ToString("N").Substring(0, 6),
                OrderDate = DateTime.Now,
                AddressId = address.Id,
                UserId = userId,
                Status = OrderStatus.Processing,
                Price = o.Price,
                DeliveryPrice = o.DeliveryPrice,
                TotalPrice = o.TotalPrice,
            };

            var usersProductsShoppingCart = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                .Where(up => up.UserId == userId)
                .Include(up => up.Product)
                .ToListAsync();

            var ordersProducts = new List<OrderProduct>();

            foreach (var up in usersProductsShoppingCart)
            {
                OrderProduct orderProduct;
                if (up.BoughtQuantity <= up.Product.Quantity)
                {
                    orderProduct = new OrderProduct
                    {
                        OrderId = order.Id,
                        Order = order,
                        ProductId = up.ProductId,
                        Product = up.Product,
                        BoughtQuantity = up.BoughtQuantity,
                    };
                    orderProduct.Product.Quantity -= up.BoughtQuantity;

                    if (orderProduct.Product.Quantity == 0)
                    {
                        orderProduct.Product.IsAvailable = false;
                    }

                    await repo.UpdateAsync(orderProduct.Product);
                }
                else
                {
                    throw new ArgumentException("Недостатъчно количество!");
                }

                ordersProducts.Add(orderProduct);
            }


            await repo.AddAsync(order);
            await repo.RemoveRangeAsync(usersProductsShoppingCart);
            await repo.AddRangeAsync(ordersProducts);
            await repo.SaveChangesAsync();

            return order.Number;
        }

        public async Task<OrderViewModel> GetOrderByNumberAsync(Guid userId, string orderNumber)
        {
            var order = await repo.AllReadonlyAsync<Order>()
                .Where(o => o.Number == orderNumber)
                .Where(o => o.UserId == userId)
                .Include(o => o.DeliveryAddress)
                .Include(o => o.OrdersProducts)
                    .ThenInclude(op => op.Product)
                .Select(o => new OrderViewModel
                {
                    Id = o.Id,
                    Number = o.Number,
                    OrderDate = o.OrderDate,
                    SendingDate = o.SendingDate,
                    Price = o.Price,
                    DeliveryPrice = o.DeliveryPrice,
                    TotalPrice = o.TotalPrice,
                    UserFullName = o.User.FirstName + " " + o.User.LastName,
                    UserEmail = o.User.Email!,
                    UserPhone = o.User.PhoneNumber!,
                    OrderStatus = OrderStatusTranslator.Translate(o.Status),
                    DeliveryAddress = new AddressViewModel
                    {
                        CityName = o.DeliveryAddress.City.Name,
                        PostCode = o.DeliveryAddress.City.PostCode,
                        StreetName = o.DeliveryAddress.StreetName,
                        Number = o.DeliveryAddress.Number,
                        BuildingNumber = o.DeliveryAddress.BuildingNumber,
                        Entrance = o.DeliveryAddress.Entrance,
                        OtherAddressInformation = o.DeliveryAddress.OtherAddressInformation,
                    },
                    Products = o.OrdersProducts.Select(op => new ProductInfoViewModel
                    {
                        ProductName = op.Product.Name,
                        Price = op.Product.Price,
                        Quantity = op.Product.Quantity,
                        ImageUrl = op.Product.ImageUrl,
                        BoughtQuantity = op.BoughtQuantity,
                        GlobalCategory = op.Product.GlobalCategory.ToString(),
                        Size = op.Product.Size,
                        ShortDescription = op.Product.ShortDescription,
                        Description = op.Product.ShortDescription,
                        Category = op.Product.Category.Name,
                        DiscountPercentage = op.Product.Promotion != null ? op.Product.Promotion.DiscountPercentage : 0,
                        PromotionalPrice = op.Product.Promotion != null
                        ? op.Product.Price - op.Product.Price * op.Product.Promotion.DiscountPercentage / 100
                        : op.Product.Price,
                    }).ToList()

                })
                .FirstOrDefaultAsync();

            if (order == null)
            {
                throw new FieldValidationException("Невалиден номер на поръчка!", "Model.Number");
            }

            switch (order.DeliveryPrice)
            {
                case 5: order.DeliveryType = "До офис на куриер"; break;
                case 7: order.DeliveryType = "До адрес"; break;
                default: order.DeliveryType = "Лично вземане"; break;
            }

            return order;
        }
    }
}
