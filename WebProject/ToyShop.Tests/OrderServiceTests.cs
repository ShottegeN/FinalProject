using Microsoft.AspNetCore.Identity;
using MockQueryable;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toyshop.Tests;
using ToyShop.Core.Services;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.ViewModels;

namespace ToyShop.Tests
{
    class OrderServiceTests
    {
        static readonly Random random = new Random();

        Mock<IRepository> mockRepo;
        Mock<UserManager<User>> userManager;
        OrderService orderServiceTest;
        List<Order> orders;

        List<Category> SetupCategories(int cnt)
        {
            return Enumerable.Range(0, cnt).Select(i => new Category { Id = i, Name = $"Category_{i}" }).ToList();
        }
        void SetupOrders(int ordersCnt)
        {
            for (int i = 0; i < ordersCnt; i++)
            {
                Order order = new Order() { Number = $"{i}" };
                orders.Add(order);
            }
        }
        List<User> SetupUsers(int usersCnt)
        {
            List<User> users = new List<User>();
            for (int i = 0; i < usersCnt; i++)
            {
                User usr = new User() { UserName = "User_" + i, Email = $"TestEmail{i}@Test.test" };
                users.Add(usr);
            }
            return users;
        }

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<IRepository>();
            var userStoreMock = new Mock<IUserStore<User>>();
            userManager = new Mock<UserManager<User>>(userStoreMock.Object, null, null, null, null, null, null, null, null);
            orderServiceTest = new OrderService(mockRepo.Object, userManager.Object);
            orders = new List<Order>();
        }

        [Test]
        public async Task TestAddProductAsync()
        {
            int usersCnt = 5;
            int productsCnt = random.Next(5, 10);
            List<User> users = Enumerable.Range(1, usersCnt).Select(i => new User()).ToList();
            List<UserProductShoppingCart> userProducts = new List<UserProductShoppingCart>();
            List<ProductInfoViewModel> products = new List<ProductInfoViewModel>();
            for (int i = 0; i < productsCnt; i++)
            {
                Product prod = new Product();
                products.Add(new ProductInfoViewModel()
                {
                    Id = prod.Id,
                    Price = random.Next(10, 50),
                    PromotionalPrice = random.Next(0, 2)
                });
            }
            City testCity = new City() { Name = "Chirpan", PostCode = "6200" };

            List<Address> addresses = new List<Address>() { new Address() { Id = 1, City = testCity } };

            IQueryable<User> mockUsers = users.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<User>()).Returns(mockUsers.AsQueryable());

            IQueryable<UserProductShoppingCart> mockUsersProduct = userProducts.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<UserProductShoppingCart>()).Returns(mockUsersProduct.AsQueryable());

            IQueryable<Address> mockAddresses = addresses.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Address>()).Returns(mockAddresses.AsQueryable());

            decimal userTotalPrice = 0;
            foreach (var user in users)
            {
                foreach (var product in products)
                {
                    int bq = random.Next(1, 5);
                    userProducts.Add(new UserProductShoppingCart() { UserId = user.Id, ProductId = product.Id, BoughtQuantity = bq });
                    userTotalPrice += bq * (product.PromotionalPrice != 0 ? product.PromotionalPrice : product.Price);
                }

                OrderViewModel order = await orderServiceTest.CheckOrderAsync(user.Id, products);
                Assert.That(order.Price, Is.EqualTo(userTotalPrice));
                userTotalPrice = 0;
                userProducts.Clear();
            }
        }

        [Test]
        public async Task TestCancelOrderAsync()
        {
            int ordersCnt = random.Next(1, 5);
            int productsCnt = random.Next(5, 10);
            int usersCnt = random.Next(1, 5);

            List<User> users = Enumerable.Range(1, usersCnt).Select(i => new User()).ToList();
            List<Product> products = Enumerable.Range(1, productsCnt).Select(i => new Product() { Quantity = 0 }).ToList();
            orders = Enumerable.Range(1, ordersCnt).Select(i => new Order()
            {
                UserId = users.First().Id,
                Status = Data.Models.Enumerations.OrderStatus.Processing
            }).ToList();
            List<OrderProduct> orderProducts = new List<OrderProduct>();

            foreach (var order in orders)
            {
                foreach (var product in products)
                {
                    orderProducts.Add(new OrderProduct() { OrderId = order.Id, ProductId = product.Id, BoughtQuantity = 1 });
                }
            }

            IQueryable<Product> mockUsers = products.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Product>(It.IsAny<Guid>())).Returns<Guid>(id =>
            {
                return Task.FromResult(mockUsers.Where(x => x.Id == id).FirstOrDefault());
            });

            IQueryable<Order> mockOrders = orders.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Order>(It.IsAny<Guid>())).Returns<Guid>(id =>
            {
                return Task.FromResult(mockOrders.Where(x => x.Id == id).FirstOrDefault());
            });
            IQueryable<OrderProduct> mockOrderProducts = orderProducts.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<OrderProduct>()).Returns(mockOrderProducts.AsQueryable());


            foreach (var order in orders)
            {
                await orderServiceTest.CancelOrderAsync(order.UserId, order.Id);
                Assert.That(order.Status, Is.EqualTo(Data.Models.Enumerations.OrderStatus.Cancelled));
            }
            foreach (var prod in products)
            {
                Assert.That(prod.Quantity, Is.EqualTo(ordersCnt));
            }

        }

        //[Test]
        //public async Task TestGetAllOrdersQuery()
        //{
        //    int ordersCnt = random.Next(10, 20);
        //    SetupOrders(ordersCnt);

        //    int usersCnt = random.Next(10, 20);
        //    List<User> users = SetupUsers(usersCnt);

        //    Dictionary<User, List<string>> usrRoles = new Dictionary<User, List<string>>();
        //    Dictionary<User, List<Order>> usrOrders = new Dictionary<User, List<Order>>();

        //    foreach (var user in users)
        //    {
        //        usrRoles[user] = new List<string>();

        //        if (random.Next(1, 10) % 3 == 0)
        //        {
        //            usrRoles[user].Add("Administrator");
        //        }
        //        else
        //        {
        //            usrRoles[user].Add("User");
        //        }

        //        usrOrders[user] = new List<Order>();

        //        foreach (var order in orders)
        //        {
        //            if (random.Next(1, 10) % 2 == 0)
        //            {
        //                usrOrders[user].Add(order);
        //            }
        //        }
        //    }

        //    IQueryable<Order> mockOrders = orders.BuildMock();
        //    mockRepo.Setup(r => r.AllReadonlyAsync<Order>()).Returns(mockOrders.AsQueryable());

        //    userManager.Setup(r => r.FindByIdAsync(It.IsAny<string>())).Returns<string>(id =>
        //    {
        //        return Task.FromResult(users.Where(x => x.Id.ToString() == id).FirstOrDefault());
        //    });

        //    userManager.Setup(x => x.GetRolesAsync(It.IsAny<User>())).Returns<User>(usr =>
        //    {
        //        return Task.FromResult((IList<string>)usrRoles[usr]);
        //    });

        //    foreach (var usrOrdersKV in usrOrders)
        //    {
        //        foreach (var order in usrOrdersKV.Value)
        //        {
        //            var res = await orderServiceTest.GetOrderForDetailsAsync(usrOrdersKV.Key.Id, order.Number);
        //        }
        //    }
        //}
    }
}
