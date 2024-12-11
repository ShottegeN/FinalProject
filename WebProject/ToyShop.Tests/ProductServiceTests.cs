using Microsoft.EntityFrameworkCore;
using Moq;
using MockQueryable;
using Toyshop.Tests;
using ToyShop.Core.Services;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.Data.Models.Enumerations;
using ToyShop.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToyShop.Tests
{
    class ProductServiceTests
    {
        static readonly Random random = new Random();

        Mock<IRepository> mockRepo;
        ProductService productServiceTest;
        IList<Product> products;

        List<Category> SetupCategories(int cnt)
        {
            return Enumerable.Range(0, cnt).Select(i => new Category { Id = i, Name = $"Category_{i}" }).ToList();
        }

        IList<User> SetupUsers(int cnt)
        {
            return Enumerable.Range(0, cnt) .Select(i => new User()) .ToList();
        }

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<IRepository>();
            productServiceTest = new ProductService(mockRepo.Object);
            products = new List<Product>();
        }

        [Test]
        public async Task TestGetProductForEdit()
        {
            int totalProduts = random.Next(20);

            for (int i = 0; i < totalProduts; i++)
            {
                var prod = new Product() { Name = "Product_" + i, Price = random.Next(), Category = new Category() { Id = i } };
                products.Add(prod);
            }

            IQueryable<Product> mockCategories = products.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Product>()).Returns(mockCategories);

            foreach (var prod in products)
            {
                var result = await productServiceTest.GetproductForEditAsync(prod.Id);
                Assert.NotNull(result);
                Assert.That(prod.Name, Is.EqualTo(result.ProductName));
                Assert.That(prod.Price, Is.EqualTo(result.Price));
            }
        }

        [Test]
        public async Task TestGetProductForDelete()
        {
            int totalProduts = random.Next(20);

            for (int i = 0; i < totalProduts; i++)
            {
                GlobalCategory category = (GlobalCategory)random.Next(0, Enum.GetNames(typeof(GlobalCategory)).Length);
                products.Add(new Product() { Name = "Product_" + i, GlobalCategory = category });
            }

            IQueryable<Product> mockProducts = products.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Product>(It.IsAny<Guid>())).Returns<Guid>(id => { return Task.FromResult(mockProducts.Where(x => x.Id == id).FirstOrDefault()); });

            foreach (var prod in products)
            {
                var result = await productServiceTest.GetproductForDeleteAsync(prod.Id);
                Assert.NotNull(result);
                Assert.That(prod.Name, Is.EqualTo(result.ProductName));
                Assert.That(prod.ReleasedOn.ToString("dd.MM.yyyy").ToString(), Is.EqualTo(result.ReleasedOn));
                Assert.That(prod.GlobalCategory.ToString(), Is.EqualTo(result.GlobalCategory));
            }
        }

        [Test]
        public async Task TestGetNewest10Products()
        {
            int totalProduts = 50;
            int categoriesCnt = 0;
            for (int i = 0; i < totalProduts; i++)
            {
                var dateRelasedOn = DateTime.Now.AddDays(-random.Next(0, 31))
                                   .AddHours(random.Next(0, 24))
                                   .AddMinutes(random.Next(0, 60))
                                   .AddSeconds(random.Next(0, 60));

                products.Add(new Product() { Name = "Product_" + i, ReleasedOn = dateRelasedOn, IsAvailable = true, Category = new Category() { Id = categoriesCnt, Name = "Category_" + categoriesCnt }, });
            }

            IQueryable<Product> mockProducts = products.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Product>()).Returns(mockProducts.AsQueryable());

            var result = await productServiceTest.GetNewest10ProductsAsync();
            Assert.NotNull(result);

            int skipCnt = 0;
            foreach (var prodRes in result)
            {
                var prod = products.OrderByDescending(p => p.ReleasedOn).Skip(skipCnt++).FirstOrDefault();
                Assert.That(prod.Name, Is.EqualTo(prodRes.ProductName));
                Assert.That(prod.ReleasedOn.ToString(), Is.EqualTo(prodRes.ReleasedOn));
                //TODO: Assign ReleasedOn prop on ProductInfoViewModel creation
            }
        }

        [Test]
        public async Task TestAddProductAsync()
        {
            int categoriesCnt = 5;
            List<Category> categories = SetupCategories(categoriesCnt);
            List<Product> allProducts = new List<Product>();

            int totalProduts = 50;

            for (int i = 0; i < totalProduts; i++)
            {
                var category = categories[random.Next(0, categoriesCnt)];
                Product newProduct;
                if (random.Next(1, 10) % 2 == 0)
                {
                    newProduct = new Product() { Name = "Product_" + i, Category = category, CategoryId = category.Id, IsAvailable = false };
                    products.Add(newProduct);
                }
                else
                {
                    newProduct = new Product() { Name = "Product_" + i, IsAvailable = true };
                }
                allProducts.Add(newProduct);
            }

            IQueryable<Product> mockProducts = products.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Product>()).Returns(mockProducts.AsQueryable());

            IQueryable<Category> mockCategories = categories.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Category>()).Returns(mockCategories.AsQueryable());

            mockRepo.Setup(r => r.AddAsync<Product>(It.IsAny<Product>())).Returns((Product product) =>
            {
                mockProducts = mockProducts.Append(product );
                return Task.CompletedTask;
            });

            foreach (var prod in allProducts)
            {
                if (products.Where(x => x.Id == prod.Id) != null)
                {
                    await productServiceTest.AddProductAsync(new UIProductViewModel()
                    {
                        Id = prod.Id,
                        ProductName = prod.Name,
                        Category = prod.CategoryId.ToString(),
                        Price = random.Next(0, 100),
                        Quantity = random.Next(0, 20),
                    }, prod.CategoryId.ToString());
                }
                else
                {
                    await productServiceTest.AddProductAsync(new UIProductViewModel()
                    {
                        Id = prod.Id,
                        ProductName = prod.Name,
                        Category = "new",
                        Price = random.Next(0, 100),
                        Quantity = random.Next(0, 20)
                    }, "Category_" + categoriesCnt++);
                }
            }

            Assert.That(allProducts.Count, Is.EqualTo(mockProducts.Count()));
            foreach (var prodRes in mockProducts)
            {
                Assert.That(prodRes.IsAvailable, Is.True);
            }
        }

        [Test]
        public async Task TestEditProductAsync()
        {
            int categoriesCnt = 5;
            List<Category> categories = SetupCategories(categoriesCnt);

            int initalPrice = random.Next(0, 100);
            int newPrice = initalPrice * 2;

            int initialQuantity = random.Next(5, 10);
            int newQuantity = initialQuantity - 5;

            int totalProduts = 50;
            for (int i = 0; i < totalProduts; i++)
            {
                var category = categories[random.Next(0, categoriesCnt)];
                products.Add(new Product() { Name = "Product_" + i, Category = category, CategoryId = category.Id, IsAvailable = false, Price = initalPrice, Quantity = initialQuantity });
            }

            IQueryable<Product> mockProducts = products.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Product>(It.IsAny<Guid>())).Returns<Guid>(id => { return Task.FromResult(mockProducts.Where(x => x.Id == id).FirstOrDefault()); });

            IQueryable<Category> mockCategories = categories.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<Category>()).Returns(mockCategories.AsQueryable());

            foreach (var prod in products)
            {
                await productServiceTest.EditProductAsync(new UIProductViewModel()
                {
                    Id = prod.Id,
                    Promotion = "none",
                    Category = prod.CategoryId.ToString(),
                    Price = newPrice,
                    Quantity = newQuantity,
                }, prod.CategoryId.ToString());
            }

            foreach (var prod in mockProducts)
            {
                Assert.That(prod.Price, Is.EqualTo(newPrice));
                Assert.That(prod.Quantity, Is.EqualTo(newQuantity));
            }
        }

        [Test]
        public async Task TestDeleteProductAsync()
        {
            int totalProduts = 50;
            for (int i = 0; i < totalProduts; i++)
            {
                products.Add(new Product() { Name = "Product_" + i, IsAvailable = true });
            }

            IQueryable<Product> mockProducts = products.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Product>(It.IsAny<Guid>())).Returns<Guid>(id => { return Task.FromResult(mockProducts.Where(x => x.Id == id).FirstOrDefault()); });

            foreach(var prod in products)
            {
                await productServiceTest.DeleteProductAsync(prod.Id);
                Assert.That(prod.IsAvailable, Is.EqualTo(false));
            }
        }

        [Test]
        public async Task TestAddToCartAsync()
        {
            int productsCnt = random.Next(1, 10);
            int userCount = random.Next(1, 5);

            IList<User> users = SetupUsers(userCount);
            List<UserProductShoppingCart> usersProducts = new List<UserProductShoppingCart>();

            for (int i = 0; i < productsCnt; i++)
            {
                products.Add(new Product() { Name = "Product_" + i });
            }

            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < productsCnt; j++)
                {
                    bool addExistingProduct = random.Next(1, 10) % 2 == 0;
                    if (addExistingProduct)
                    {
                        usersProducts.Add(new UserProductShoppingCart()
                        {
                            User = users[i],
                            UserId = users[i].Id,
                            Product = products[j],
                            ProductId = products[j].Id,
                            BoughtQuantity = 0
                        });
                    }
                }
            }

            IQueryable<Product> mockProducts = products.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Product>(It.IsAny<Guid>())).Returns<Guid>(id =>
            {
                return Task.FromResult(mockProducts.Where(x => x.Id == id).FirstOrDefault());
            });

            IQueryable<User> mockUsers = users.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<User>(It.IsAny<Guid>())).Returns<Guid>(id =>
            {
                return Task.FromResult(mockUsers.Where(x => x.Id == id).FirstOrDefault());
            });

            IQueryable<UserProductShoppingCart> mockUsersProduct = usersProducts.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<UserProductShoppingCart>()).Returns(mockUsersProduct.AsQueryable());
            mockRepo.Setup(r => r.AddAsync(It.IsAny<UserProductShoppingCart>())).Returns((UserProductShoppingCart prd) =>
            {
                mockUsersProduct = mockUsersProduct.Append(prd);
                return Task.CompletedTask;
            });

            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < productsCnt; j++)
                {
                    await productServiceTest.AddToCartAsync(users[i].Id, products[j].Id);
                }
            }

            foreach(var userProduct in mockUsersProduct)
            {
                Assert.That(userProduct.BoughtQuantity, Is.GreaterThan(0));
            }
            Assert.That(mockUsersProduct.Count(), Is.EqualTo(productsCnt * users.Count));
        }

        [Test]
        public async Task TestRemoveFromCartAsync()
        {
            int productsCnt = random.Next(1, 10);

            int userCnt = random.Next(1, 5);
            IList<User> users = SetupUsers(userCnt);
            List<UserProductShoppingCart> usersProducts = new List<UserProductShoppingCart>();
            List<UserProductShoppingCart> removedusersProducts = new List<UserProductShoppingCart>();

            for (int i = 0; i < productsCnt; i++)
            {
                products.Add(new Product() { Name = "Product_" + i });
            }

            foreach(var user in users)
            {
                foreach (var product in products)
                {
                    usersProducts.Add(new UserProductShoppingCart()
                    {
                        User = user,
                        UserId = user.Id,
                        Product = product,
                        ProductId = product.Id,
                        BoughtQuantity = 0
                    });
                }
            }

            IQueryable<UserProductShoppingCart> mockUsersProduct = usersProducts.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<UserProductShoppingCart>()).Returns(mockUsersProduct.AsQueryable());
            mockRepo.Setup(r => r.RemoveAsync(It.IsAny<UserProductShoppingCart>())).Returns((UserProductShoppingCart prd) =>
            {
                mockUsersProduct = mockUsersProduct.Except(new[] { prd });
                removedusersProducts.Add(prd);
                return Task.CompletedTask;
            });

            bool atLeastOneRemoved = false;
            foreach (var user in users)
            {
                foreach (var product in products)
                {
                    if (random.Next(0, 10) % 2 == 0 && !atLeastOneRemoved)
                    {
                        atLeastOneRemoved = true;
                        await productServiceTest.RemoveFromCartAsync(user.Id, product.Id);
                    }
                }
            }

            Assert.That(removedusersProducts.Count + mockUsersProduct.Count(), Is.EqualTo(userCnt * productsCnt));
            foreach (var removed in removedusersProducts)
            {
                Assert.That(removed, !Is.AnyOf(mockUsersProduct));
            }
        }

        [Test]
        public async Task TestAddToWishlistAsync()
        {
            int productsCnt = random.Next(1, 10);
            int userCnt = random.Next(1, 5);
            IList<User> users = SetupUsers(userCnt);
            IList<UserProductWhishlist> usersProducts = new List<UserProductWhishlist>();

            for (int i = 0; i < productsCnt; i++)
            {
                products.Add(new Product() { Name = "Product_" + i });
            }

            foreach (var user in users)
            {
                foreach (var product in products)
                {
                    if (random.Next(0, 10) % 2 == 0)
                    {
                        usersProducts.Add(new UserProductWhishlist()
                        {
                            User = user,
                            UserId = user.Id,
                            Product = product,
                            ProductId = product.Id,
                        });
                    }
                }
            }
            IQueryable<Product> mockProducts = products.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<Product>(It.IsAny<Guid>())).Returns<Guid>(id =>
            {
                return Task.FromResult(mockProducts.Where(x => x.Id == id).FirstOrDefault());
            });

            IQueryable<User> mockUsers = users.BuildMock();
            mockRepo.Setup(r => r.GetByIdAsync<User>(It.IsAny<Guid>())).Returns<Guid>(id =>
            {
                return Task.FromResult(mockUsers.Where(x => x.Id == id).FirstOrDefault());
            });

            IQueryable<UserProductWhishlist> mockUsersProduct = usersProducts.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<UserProductWhishlist>()).Returns(mockUsersProduct.AsQueryable());
            mockRepo.Setup(r => r.AddAsync(It.IsAny<UserProductWhishlist>())).Returns((UserProductWhishlist prd) =>
            {
                mockUsersProduct = mockUsersProduct.Concat(new[] { prd });
                return Task.CompletedTask;
            });

            foreach (var user in users)
            {
                foreach (var product in products)
                {
                    await productServiceTest.AddToWishlistAsync(user.Id, product.Id);
                }
            }

            Assert.That(mockUsersProduct.Count(), Is.EqualTo(userCnt * productsCnt));
        }

        [Test]
        public async Task TestRemoveFromWhishlistAsync()
        {
            int productsCnt = random.Next(1, 10);
            int userCnt = random.Next(1, 5);

            IList<User> users = SetupUsers(userCnt);
            IList<UserProductWhishlist> usersProducts = new List<UserProductWhishlist>();
            IList<UserProductWhishlist> removedusersProducts = new List<UserProductWhishlist>();

            for (int i = 0; i < productsCnt; i++)
            {
                products.Add(new Product() { Name = "Product_" + i });
            }

            foreach (var user in users)
            {
                foreach (var product in products)
                {
                    usersProducts.Add(new UserProductWhishlist()
                    {
                        User = user,
                        UserId = user.Id,
                        Product = product,
                        ProductId = product.Id,
                    });
                }
            }

            IQueryable<UserProductWhishlist> mockUsersProduct = usersProducts.BuildMock();
            mockRepo.Setup(r => r.AllReadonlyAsync<UserProductWhishlist>()).Returns(mockUsersProduct.AsQueryable());
            mockRepo.Setup(r => r.RemoveAsync(It.IsAny<UserProductWhishlist>())).Returns((UserProductWhishlist prd) =>
            {
                mockUsersProduct = mockUsersProduct.Except(new[] { prd });
                removedusersProducts.Add(prd);
                return Task.CompletedTask;
            });

            bool atLeastOneRemoved = false;
            foreach (var user in users)
            {
                foreach (var product in products)
                {
                    if (random.Next(0, 10) % 2 == 0 && !atLeastOneRemoved)
                    {
                        atLeastOneRemoved = true;
                        await productServiceTest.RemoveFromWhishlistAsync(user.Id, product.Id);
                    }
                }
            }

            Assert.That(removedusersProducts.Count + mockUsersProduct.Count(), Is.EqualTo(userCnt * productsCnt));
            foreach (var removed in removedusersProducts)
            {
                Assert.That(removed, !Is.AnyOf(mockUsersProduct));
            }
        }
    }
}
