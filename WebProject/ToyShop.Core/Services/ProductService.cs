using Microsoft.EntityFrameworkCore;
using ToyShop.Common;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.Data.Models.Enumerations;
using ToyShop.ViewModels;


namespace ToyShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repo;

        public ProductService(IRepository _repo)
        {
            repo = _repo;
        }


        public async Task<StoreViewModel> GetStoreViewModelAsync(string sortBy, int pageNumber = 1, int pageSize = 9, string filter = "")
        {
            var allProductsQuery = TotalProductsAfterFiltered(filter);

            var totalProductsCount = await allProductsQuery.CountAsync();

            var totalPages = (int)Math.Ceiling(totalProductsCount / (double)pageSize);

            pageNumber = pageNumber > totalPages ? totalPages : pageNumber;

            var paginatedProducts = await GetAllProductsWithFilterSorted(allProductsQuery, sortBy, pageNumber, pageSize);

            return new StoreViewModel
            {
                AllProducts = paginatedProducts,
                TotalPages = totalPages,
                TotalProductsCount = totalProductsCount,
                CurrentPage = pageNumber,
                PageSize = pageSize,
                SortBy = sortBy,
                Filter = filter
            };
        }

        public async Task AddProductAsync(UIProductViewModel p, string? newCategoryName)
        {
            int categoryId = await GetCategoryId(p, newCategoryName);
            bool hasPromotion = int.TryParse(p.Promotion, out int promotionId);

            var product = await repo.AllReadonlyAsync<Product>()
                .Where(product => product.Name.ToLower() == p.ProductName.ToLower())
                .Where(product => product.CategoryId == categoryId)
                .FirstOrDefaultAsync();

            if (product != null && product.IsAvailable == false)
            {
                product.Quantity += p.Quantity!.Value;
                product.IsAvailable = true;

                await repo.UpdateAsync(product);
            }
            else if (product != null && product.IsAvailable == true)
            {
                throw new CustomException("Продукт с това име вече съществува!", "Product.ProductName");
            }
            else
            {
                product = new Product
                {
                    Name = p.ProductName,
                    Price = p.Price!.Value,
                    Quantity = p.Quantity!.Value,
                    Description = p.Description,
                    ShortDescription = p.ShortDescription,
                    Size = p.Size,
                    ImageUrl = p.ImageUrl ?? "img/no_img.png",
                    GlobalCategory = Enum.TryParse(p.GlobalCategory, true, out GlobalCategory globalCategory) ? globalCategory : GlobalCategory.Други,
                    CategoryId = categoryId,
                    PromotionId = promotionId,
                };

                await repo.AddAsync(product);
            }

            await repo.SaveChangesAsync();
        }

        public async Task EditProductAsync(UIProductViewModel p, string? newCategoryName)
        {
            var product = await repo.GetByIdAsync<Product>(p.Id);

            if (product == null)
            {
                throw new ArgumentException("Невалидна операция");
            }

            bool isParsable = int.TryParse(p.Promotion, out int promotionId);

            if (isParsable) // promotion selected
            {
                product.PromotionId = promotionId;
            }
            else if (!isParsable && p.Promotion == "none")//no promotion selected
            {
                product.PromotionId = null;
            }
            else //product has promotion, not changed on submit, promotion comes as string != none and no parsable to int
            {
                var promotion = await repo.AllReadonlyAsync<Promotion>()
                .Where(prom => prom.Name == p.Promotion)
                .FirstOrDefaultAsync();

                if (promotion != null)// if no promotion with this name existing
                {
                    product.PromotionId = promotion.Id;
                }
                else
                {
                    throw new ArgumentException("Невалидна операция");
                }
            }

            int categoryId = await GetCategoryId(p, newCategoryName);

            product.Name = p.ProductName;
            product.Price = p.Price!.Value;
            product.Quantity = p.Quantity!.Value;
            product.Description = p.Description;
            product.ShortDescription = p.ShortDescription;
            product.Size = p.Size;
            product.ImageUrl = p.ImageUrl ?? "img/no_img.png";
            product.GlobalCategory = Enum.TryParse(p.GlobalCategory, true, out GlobalCategory globalCategory) ? globalCategory : GlobalCategory.Други;
            product.CategoryId = categoryId;

            await repo.UpdateAsync(product);
            await repo.SaveChangesAsync();
        }

        public async Task<UIProductViewModel> GetproductForEditAsync(Guid id)
        {
            var p = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.Id == id)
                .Include(p => p.Category)
                .Include(p => p.Promotion)
                .FirstOrDefaultAsync();


            if (p == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            var product = new UIProductViewModel
            {
                Id = p.Id,
                ProductName = p.Name,
                ImageUrl = p.ImageUrl,
                Quantity = p.Quantity,
                Price = p.Price,
                Size = p.Size,
                Promotion = p.Promotion != null ? p.Promotion?.Name : "none",
                Category = p.Category.Id.ToString(),
                GlobalCategory = p.GlobalCategory.ToString(),
                ShortDescription = p.ShortDescription,
                Description = p.Description

            };

            return product;
        }

        public async Task<IEnumerable<ProductInfoViewModel>> GetNewest10ProductsAsync()
        {
            var products = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.IsAvailable)
                .Where(p => p.ReleasedOn >= DateTime.Now.AddDays(-30))
                .OrderByDescending(p => p.ReleasedOn)
                .Take(10)
                .Select(p => new ProductInfoViewModel
                {
                    Id = p.Id,
                    ProductName = p.Name,
                    ImageUrl = p.ImageUrl,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    Size = p.Size,
                    ReleasedOn = p.ReleasedOn.ToString(),
                    GlobalCategory = p.GlobalCategory.ToString(),
                    Category = p.Category.Name,
                    DiscountPercentage = p.Promotion != null && p.Promotion.StartDate < DateTime.Now && p.Promotion.EndDate > DateTime.Now ? p.Promotion.DiscountPercentage : 0,
                    ShortDescription = p.ShortDescription,
                    Rating = p.Reviews.Any() ? p.Reviews.Average(r => (double)r.Rating) : 0,
                    Description = p.Description
                })
                .ToListAsync();

            if (products == null)
            {
                throw new ArgumentException("Невалидна операция");
            }

            CalculatePromotionalPrice(products);

            return products;
        }

        public async Task<ProductInfoViewModel> GetProductForDetailsAsync(Guid productId)
        {
            var p = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.Id == productId && p.IsAvailable)
                .Include(p => p.Category)
                .Include(p => p.Reviews)
                .Include(p => p.Promotion)
                .FirstOrDefaultAsync();

            if (p == null)
            {
                throw new ArgumentException();
            }

            List<ReviewViewModel> reviews = new List<ReviewViewModel>();

            if (p.Reviews.Any())
            {
                var userIds = p.Reviews.Select(r => r.UserId).Distinct().ToList();

                var users = await repo.AllReadonlyAsync<User>()
                    .Where(u => userIds.Contains(u.Id))
                    .ToDictionaryAsync(u => u.Id, u => $"{u.FirstName} {u.LastName}");

                reviews = p.Reviews
                .Select(r => new ReviewViewModel
                {
                    Id = r.Id,
                    Comment = r.Comment,
                    Rating = r.Rating,
                    UserFullName = users.ContainsKey(r.UserId) ? users[r.UserId] : "Unknown"
                }).ToList();
            }

            var product = new ProductInfoViewModel
            {
                Id = p.Id,
                ProductName = p.Name,
                ImageUrl = p.ImageUrl,
                Quantity = p.Quantity,
                Price = p.Price,
                Size = p.Size,
                ReleasedOn = p.ReleasedOn.ToString("dd.MM.yyyy"),
                Category = p.Category.Name,
                GlobalCategory = p.GlobalCategory.ToString(),
                DiscountPercentage = p.Promotion != null && p.Promotion.StartDate < DateTime.Now && p.Promotion.EndDate > DateTime.Now ? p.Promotion.DiscountPercentage : 0,
                ShortDescription = p.ShortDescription,
                Reviews = reviews,
                Rating = p.Reviews.Any() ? p.Reviews.Average(r => (double)r.Rating) : 0,
                Description = p.Description
            };

            CalculateSingleProductPromotionalPrice(product);

            return product;
        }

        public async Task WriteProductReviewAsync(Guid productId, string username, int rating, string comment)
        {
            var user = await repo.AllReadonlyAsync<User>()
                .Where(u => u.UserName == username)
                .FirstOrDefaultAsync();

            var product = await repo.GetByIdAsync<Product>(productId);

            if (user == null || product == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            var review = new Review
            {
                Comment = comment,
                Rating = rating,
                UserId = user.Id,
                ProductId = product.Id
            };

            await repo.AddAsync(review);

            await repo.SaveChangesAsync();
        }

        public async Task<ProductInfoViewModel> GetproductForDeleteAsync(Guid id)
        {
            var p = await repo.GetByIdAsync<Product>(id);

            if (p == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            var product = new ProductInfoViewModel
            {
                Id = p.Id,
                ProductName = p.Name,
                ReleasedOn = p.ReleasedOn.ToString("dd.MM.yyyy"),
                GlobalCategory = p.GlobalCategory.ToString(),
            };

            return product;
        }

        public async Task DeleteProductAsync(Guid id)
        {
            var product = await repo.GetByIdAsync<Product>(id);

            if (product == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            product.IsAvailable = false;

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductInfoViewModel>> GetUsersCartProductsAsync(Guid? userId)
        {
            var products = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                .Where(up => up.UserId == userId)
                .Include(up => up.Product)
                .Where(up => up.Product.IsAvailable)
                .Select(up => new ProductInfoViewModel
                {
                    Id = up.ProductId,
                    ProductName = up.Product.Name,
                    Price = up.Product.Price,
                    BoughtQuantity = up.BoughtQuantity,
                    Quantity = up.Product.Quantity,
                    ImageUrl = up.Product.ImageUrl,
                    DiscountPercentage = up.Product.Promotion != null && up.Product.Promotion.StartDate < DateTime.Now && up.Product.Promotion.EndDate > DateTime.Now ? up.Product.Promotion.DiscountPercentage : 0,
                })
                .ToListAsync();

            if (products == null)
            {
                throw new ArgumentException("Невалидна операция");
            }

            CalculatePromotionalPrice(products);

            return products;
        }

        public async Task AddToCartAsync(Guid userId, Guid productId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            var product = await repo.GetByIdAsync<Product>(productId);

            if (user == null || product == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            var existingUserProduct = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                    .Where(up => up.UserId == userId && up.ProductId == productId)
                    .FirstOrDefaultAsync();

            if (existingUserProduct != null)
            {
                existingUserProduct.BoughtQuantity++;

                await repo.UpdateAsync(existingUserProduct);
                await repo.SaveChangesAsync();
            }
            else
            {
                var userProduct = new UserProductShoppingCart
                {
                    UserId = userId,
                    ProductId = productId,
                    BoughtQuantity = 1
                };

                await repo.AddAsync(userProduct);
                await repo.SaveChangesAsync();

            }

        }

        public async Task RemoveFromCartAsync(Guid userId, Guid productId)
        {
            var existingUserProduct = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                    .Where(up => up.UserId == userId && up.ProductId == productId)
                    .FirstOrDefaultAsync();

            if (existingUserProduct == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            await repo.RemoveAsync(existingUserProduct);
            await repo.SaveChangesAsync();
        }

        public async Task UpdateProductQuantityAsync(Guid userId, Guid productId, int quantity)
        {
            var existingUserProduct = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                    .Where(up => up.UserId == userId && up.ProductId == productId)
                    .FirstOrDefaultAsync();

            if (existingUserProduct == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            existingUserProduct.BoughtQuantity = quantity;

            await repo.UpdateAsync(existingUserProduct);
            await repo.SaveChangesAsync();

        }

        public async Task<IEnumerable<ProductInfoViewModel>> GetUsersWhishlistAsync(Guid? userId)
        {
            var products = await repo.AllReadonlyAsync<UserProductWhishlist>()
                .Where(up => up.UserId == userId)
                .Include(up => up.Product)
                .Where(up => up.Product.IsAvailable)
                .Select(up => new ProductInfoViewModel
                {
                    Id = up.ProductId,
                    ProductName = up.Product.Name,
                    Price = up.Product.Price,
                    ImageUrl = up.Product.ImageUrl,
                    DiscountPercentage = up.Product.Promotion != null && up.Product.Promotion.StartDate < DateTime.Now && up.Product.Promotion.EndDate > DateTime.Now ? up.Product.Promotion.DiscountPercentage : 0,
                })
                .ToListAsync();

            if (!products.Any())
            {
                throw new ArgumentException("Невалидна операция!");
            }

            CalculatePromotionalPrice(products);

            return products;
        }

        public async Task AddToWishlistAsync(Guid userId, Guid productId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            var product = await repo.GetByIdAsync<Product>(productId);

            if (user == null || product == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            var existingUserProduct = await repo.AllReadonlyAsync<UserProductWhishlist>()
                .Where(up => up.UserId == userId && up.ProductId == productId)
                .FirstOrDefaultAsync();

            if (existingUserProduct == null)
            {
                var userProduct = new UserProductWhishlist
                {
                    UserId = userId,
                    ProductId = productId,
                };

                await repo.AddAsync(userProduct);
                await repo.SaveChangesAsync();
            }
        }

        public async Task RemoveFromWhishlistAsync(Guid userId, Guid productId)
        {
            var existingUserProduct = await repo.AllReadonlyAsync<UserProductWhishlist>()
                    .Where(up => up.UserId == userId && up.ProductId == productId)
                    .FirstOrDefaultAsync();

            if (existingUserProduct == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }
            await repo.RemoveAsync(existingUserProduct);
            await repo.SaveChangesAsync();
        }


        //private
        private async Task<IEnumerable<ProductInfoViewModel>> GetAllProductsWithFilterSorted(IQueryable<Product> productsQuery, string sortBy, int pageNumber = 1, int pageSize = 9)
        {
            var products = await productsQuery
                .Select(p => new ProductInfoViewModel
                {
                    Id = p.Id,
                    ProductName = p.Name,
                    ImageUrl = p.ImageUrl,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    GlobalCategory = p.GlobalCategory.ToString(),
                    Category = p.Category.Name,
                    DiscountPercentage = p.Promotion != null && p.Promotion.StartDate < DateTime.Now && p.Promotion.EndDate > DateTime.Now ? p.Promotion.DiscountPercentage : 0,
                    ShortDescription = p.ShortDescription,
                    Rating = p.Reviews.Any() ? p.Reviews.Average(r => (double)r.Rating) : 0,
                    Description = p.Description
                })
                .ToListAsync();

            CalculatePromotionalPrice(products);

            products = sortBy.ToLower() switch
            {
                "price_asc" => [.. products.OrderBy(p => p.PromotionalPrice)],
                "price_desc" => [.. products.OrderByDescending(p => p.PromotionalPrice)],
                "name_asc" => [.. products.OrderBy(p => p.ProductName)],
                "name_desc" => [.. products.OrderByDescending(p => p.ProductName)],
                _ => [.. products.OrderByDescending(p => p.Rating)] // Default: by rating
            };

            return products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }

        private async Task<int> GetCategoryId(UIProductViewModel p, string? newCategoryName)
        {

            if (p.Category != "new")
            {
                return int.Parse(p.Category);
            }
            else if (p.Category == null)
            {
                throw new CustomException("Това поле е задължително!", "Product.Category");
            }

            if (newCategoryName == null)
            {
                throw new CustomException("Това поле е задължително!", "NewCategoryName");
            }

            var categories = await repo.AllReadonlyAsync<Category>().ToListAsync();

            if (categories.Any(c => c.Name.ToLower() == newCategoryName!.ToLower()))
            {
                throw new CustomException("Този вид вече съществува!", "NewCategoryName");
            }

            var newCategory = new Category
            {
                Name = newCategoryName!
            };

            await repo.AddAsync(newCategory);
            await repo.SaveChangesAsync();

            return newCategory.Id;
        }

        private static void CalculatePromotionalPrice(List<ProductInfoViewModel> products)
        {
            foreach (var p in products)
            {
                CalculateSingleProductPromotionalPrice(p);
            }
        }

        private static void CalculateSingleProductPromotionalPrice(ProductInfoViewModel p)
        {
            p.PromotionalPrice = p.Price - p.Price * p.DiscountPercentage / 100;
        }

        private IQueryable<Product> TotalProductsAfterFiltered(string filter)
        {
            var productsQuery = repo.AllReadonlyAsync<Product>().Where(p => p.IsAvailable);

            if (filter == "")
            {
                return productsQuery;
            }
            var filterArray = filter.Split("-").ToArray();

            var filteringType = filterArray[0];
            var filteringValue = filterArray[1];

            if (filteringType == "category")
            {
                productsQuery = productsQuery.Where(p => p.CategoryId == int.Parse(filteringValue));
            }
            else if (filteringType == "promotion")
            {
                if (filteringValue == "all")
                {
                    return productsQuery.Where(p => p.PromotionId > 0);
                }

                productsQuery = productsQuery.Where(p => p.PromotionId == int.Parse(filteringValue));
            }
            else if (filteringType == "globalCategory")
            {
                bool hasValue = int.TryParse(filteringValue, out int value);

                if (hasValue)
                {
                    productsQuery = productsQuery.Where(p => (int)p.GlobalCategory == int.Parse(filteringValue));
                }

                if (filterArray.Length > 2)
                {
                    var searchQuery = filterArray[2];

                    productsQuery = productsQuery
                        .Where(p => EF.Functions.Like(p.Name, "%" + searchQuery + "%"));
                }
            }

            return productsQuery;
        }
    }
}
