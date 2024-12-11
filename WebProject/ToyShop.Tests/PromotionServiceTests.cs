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
    class PromotionServiceTests
    {
        static readonly Random random = new Random();

        Mock<IRepository> mockRepo;        
        PromotionService promotionServiceTest;
        IList<Promotion> promotions;

        List<User> SetupUsers(int usersCnt)
        {
            List<User> users = new List<User>();
            for(int i = 0; i < usersCnt; i++)
            {
                User usr = new User() { UserName = "User_" + i, Email = $"TestEmail{i}@Test.test" };
                users.Add(usr);
            }
            return users;
        }

        void SetupPromotions(int promotionsCnt)
        {
            for(int i = 0; i < promotionsCnt; i++)
            {
                var promotion = new Promotion() { Id = i, Name = "Promotion_" + i };
                promotions.Add(promotion);
            }
        }

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<IRepository>();
            promotionServiceTest = new PromotionService(mockRepo.Object);
            promotions = new List<Promotion>();
        }

        [Test]
        public async Task TestGetActivePromotionsAsync()
        {

            SetupPromotions(random.Next(10, 20));
            int activeProms = 0;
            foreach(var prom in promotions)
            {
                if(random.Next(0, 10) % 2 == 0)
                {
                    prom.EndDate = DateTime.Now.AddDays(-1);
                }
                else
                {
                    prom.StartDate = DateTime.Now.AddDays(-1);
                    prom.EndDate = DateTime.Now.AddDays(+1);
                    activeProms++;
                }
            }
            IQueryable<Promotion> mockPromotions = promotions.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Promotion>()).Returns(mockPromotions.AsQueryable());

            var promotionsVM = await promotionServiceTest.GetActivePromotionsAsync();
            Assert.That(promotionsVM.Count(), Is.EqualTo(activeProms));

            foreach(var promotion in promotionsVM)
            {
                var prom = promotions.Where(x => x.Id == promotion.Id).FirstOrDefault();
                Assert.NotNull(prom);
            }
        }

        [Test]
        public async Task TestGetPromotionByIdAsync()
        {
            SetupPromotions(random.Next(10, 20));

            IQueryable<Promotion> mockPromotions = promotions.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Promotion>(It.IsAny<int>())).Returns<int>(id => { return Task.FromResult(mockPromotions.Where(x => x.Id == id).FirstOrDefault()); });

            foreach(var promotion in promotions)
            {
                var res = await promotionServiceTest.GetPromotionByIdAsync(promotion.Id);
                Assert.NotNull(res);
                Assert.That(res.Id, Is.EqualTo(promotion.Id));
                Assert.That(res.Name, Is.EqualTo(promotion.Name));
            }
        }


        [Test]
        public async Task TestAddPromotionAsync()
        {
            IQueryable<Promotion> mockPromotions = promotions.BuildMock();
            mockRepo.Setup(r => r.AddAsync<Promotion>(It.IsAny<Promotion>())).Returns((Promotion promotion) =>
            {
                mockPromotions = mockPromotions.Concat(new[] { promotion });
                return Task.CompletedTask;
            });

            int promotionsCnt = random.Next(10, 20);
            for(int i = 0; i < promotionsCnt; i++)
            {
                var promotionVM = new PromotionViewModel
                {
                    Name = "Promotion" + i,
                    StartDate = DateTime.Now.AddDays(-1),
                    EndDate = DateTime.Now.AddDays(+1),
                };
                await promotionServiceTest.AddPromotionAsync(promotionVM);
            }

            foreach(var promotion in promotions)
            {
                Assert.That(mockPromotions.Count(), Is.EqualTo(promotionsCnt));
            }
        }


        [Test]
        public async Task TestEditPromotionAsync()
        {
            SetupPromotions(random.Next(10, 20));
            IQueryable<Promotion> mockPromotions = promotions.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Promotion>(It.IsAny<int>())).Returns<int>(id => { return Task.FromResult(mockPromotions.Where(x => x.Id == id).FirstOrDefault()); });

            for(int i = 0; i < promotions.Count; i++)
            {
                var promotionVM = new PromotionViewModel
                {
                    Id = promotions[i].Id,  
                    Name = "PromotionNewName_" + i,
                    StartDate = DateTime.Now.AddDays(-1),
                    EndDate = DateTime.Now.AddDays(+1),
                };
                await promotionServiceTest.EditPromotionAsync(promotionVM);
                Assert.That(promotionVM.Name, Is.EqualTo(promotions[i].Name));
            }
        }


        [Test]
        public async Task TestRemovePromotionAsync()
        {
            SetupPromotions(random.Next(10, 20));
            int productsCnt = random.Next(10, 20);
            List<Product> products = new List<Product>();
            for(int i = 0; i < productsCnt; i++)
            {
                var promotion = promotions[random.Next(0, promotions.Count)];
                Product prod = new Product() { PromotionId = promotion.Id };
                products.Add(prod);
                promotion.Products.Add(prod);
            }
            IQueryable<Promotion> mockPromotions = promotions.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Promotion>()).Returns(mockPromotions.AsQueryable());

            foreach(var prom in promotions)
            {
                await promotionServiceTest.RemovePromotionAsync(prom.Id);
                foreach(var product in prom.Products)
                {
                    Assert.That(product.Promotion, Is.EqualTo(null));
                }
            }
        }

        [Test]
        public async Task TestGetAllPromotionsAsync()
        {
            SetupPromotions(random.Next(10, 20));
            IQueryable<Promotion> mockPromotions = promotions.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Promotion>()).Returns(mockPromotions.AsQueryable());

            var promotionsVM = await promotionServiceTest.GetAllPromotionsAsync();
            Assert.That(promotionsVM.Count(), Is.EqualTo(promotions.Count));

     
            foreach(var promotion in promotionsVM)
            {
                var prom = promotions.Where(x => x.Id == promotion.Id).FirstOrDefault();
                Assert.NotNull(prom);
            }
        }

    }
}
