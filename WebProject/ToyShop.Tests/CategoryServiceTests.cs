﻿using ToyShop.Core.Contracts;
using Moq;
using MockQueryable;
using ToyShop.Data.Common;
using ToyShop.Data.Models;

namespace Toyshop.Tests
{
    class CategoryServiceTests
    {
        static readonly Random random = new Random();

        Mock<IRepository> mockRepo;
        CategoryService categoryServiceTest;
        IList<Category> categories;

        void AddTestCategory(int id, string name, int productsCnt) 
        {
            categories.Add(new Category() { Id = id, Name = name, Products = Enumerable.Repeat(new Product(), productsCnt).ToList() });
        }

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<IRepository>();
            categoryServiceTest = new CategoryService(mockRepo.Object);
            categories = new List<Category>();
        }

        [Test]
        public async Task TestGetAllCategories()
        {
            int totalCategories = random.Next(20);
            int totalProduts = 0;

            for (int i = 0; i < totalCategories; i++)
            {
                int groupId = random.Next(20);
                int products = random.Next(20);
                totalProduts += products;

                AddTestCategory(groupId, "Group_" + groupId, products);
            }

            IQueryable<Category> mockCategories = categories.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Category>()).Returns(mockCategories.AsQueryable());
            var result = await categoryServiceTest.GetAllCategoriesAsync();

            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(totalCategories));
            for (int i = 0; i < totalCategories; i++)
            {
                Assert.That(categories[i].Id, Is.EqualTo(result.ElementAt(i).Id));
                Assert.That(categories[i].Name, Is.EqualTo(result.ElementAt(i).Name));
                Assert.That(categories[i].Products.Count(), Is.EqualTo(result.ElementAt(i).ProductCount));
            }
        }
    }
}
