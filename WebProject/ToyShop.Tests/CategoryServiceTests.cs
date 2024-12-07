using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.Core.Contracts;
using Moq;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using ToyShop.ViewModels; // For IAsyncQueryProvider

namespace Toyshop.Tests
{
    class CategoryServiceTests
    {
        static readonly Random random = new Random();

        Mock<IRepository> mockRepo;
        CategoryService categoryServiceTest;
        List<Category> categories;

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
        public async Task TestCategories()
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
            

            var asyncCategories = new TestAsyncEnumerable<Category>(categories.AsQueryable());
            mockRepo.Setup(r => r.AllReadonlyAsync<Category>()).Returns(asyncCategories.AsQueryable());
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
