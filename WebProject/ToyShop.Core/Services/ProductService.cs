using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
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
            var allProductsQuery = TotalProductsAfterCategoryFilter(filter);

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

            var product = new Product
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
            };

            await repo.AddAsync(product);

            await repo.SaveChangesAsync();
        }

        public async Task EditProductAsync(UIProductViewModel p, string? newCategoryName)
        {
            var product = await repo.GetByIdAsync<Product>(p.Id);

            if (product == null)
            {
                throw new ArgumentException("Невалидна операция");
            }

            // Get or create the category ID
            int categoryId = await GetCategoryId(p, newCategoryName);

            // Update the properties of the existing product
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
                .FirstOrDefaultAsync();


            if (p == null)
            {
                throw new ArgumentNullException();
            }

            var product = new UIProductViewModel
            {
                Id = p.Id,
                ProductName = p.Name,
                ImageUrl = p.ImageUrl,
                Quantity = p.Quantity,
                Price = p.Price,
                Size = p.Size,
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
                    GlobalCategory = p.GlobalCategory.ToString(),
                    Category = p.Category.Name,
                    DiscountPercentage = p.Promotion != null && p.Promotion.StartDate < DateTime.Now && p.Promotion.EndDate > DateTime.Now ? p.Promotion.DiscountPercentage : 0,
                    ShortDescription = p.ShortDescription,
                    Rating = p.Reviews.Any() ? p.Reviews.Average(r => (double)r.Rating) : 0,
                    Description = p.Description
                })
                .ToListAsync();

            CalculatePromotionalPrice(products);

            return products;
        }

        public async Task<ProductInfoViewModel> GetProductForDetailsAsync(Guid productId)
        {
            var p = await repo.AllReadonlyAsync<Product>()
                .Where(p => p.Id == productId)
                .Include(p => p.Category)
                .Include(p => p.Reviews)
                .Include(p => p.Promotion)
                .FirstOrDefaultAsync();

            if (p == null)
            {
                throw new ArgumentNullException();
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
                throw new ArgumentException();
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
                throw new ArgumentNullException();
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
                throw new ArgumentNullException();
            }

            product.IsAvailable = false;

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductInfoViewModel>> GetUsersCartProductsAsync(Guid? userId)
        {
            var products = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                .Where(up => up.UserId == userId)
                .Include(up => up.Product)
                .Select(up => new ProductInfoViewModel
                {
                    Id = up.ProductId,
                    ProductName = up.Product.Name,
                    Price = up.Product.Price,
                    BoughtQuantity = up.BoughtQuantity,
                    ImageUrl = up.Product.ImageUrl,
                    DiscountPercentage = up.Product.Promotion != null && up.Product.Promotion.StartDate < DateTime.Now && up.Product.Promotion.EndDate > DateTime.Now ? up.Product.Promotion.DiscountPercentage : 0,
                })
                .ToListAsync();

            CalculatePromotionalPrice(products);

            return products;
        }

        public async Task AddToCartAsync(Guid userId, Guid productId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            var product = await repo.GetByIdAsync<Product>(productId);

            if (user != null && product != null)
            {
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
        }

        public async Task RemoveFromCartAsync(Guid userId, Guid productId)
        {
            var existingUserProduct = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                    .Where(up => up.UserId == userId && up.ProductId == productId)
                    .FirstOrDefaultAsync();

            if (existingUserProduct != null) 
            {
                await repo.RemoveAsync(existingUserProduct);
                await repo.SaveChangesAsync();
            }            
        }

        public async Task UpdateProductQuantityAsync(Guid userId, Guid productId, int quantity)
        {
            var existingUserProduct = await repo.AllReadonlyAsync<UserProductShoppingCart>()
                    .Where(up => up.UserId == userId && up.ProductId == productId)
                    .FirstOrDefaultAsync();

            if (existingUserProduct != null)
            {
                existingUserProduct.BoughtQuantity = quantity;                

                await repo.UpdateAsync(existingUserProduct);                
                await repo.SaveChangesAsync();
            }
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
            if (newCategoryName == null && p.Category == "new")
            {
                throw new ArgumentException("Това поле е задължително!");
            }
            else if (newCategoryName == null && p.Category != "new")
            {
                return int.Parse(p.Category);
            }

            var categories = await repo.AllReadonlyAsync<Category>().ToListAsync();

            if (categories.Any(c => c.Name.ToLower() == newCategoryName!.ToLower()))
            {
                throw new ArgumentException("Този вид вече съществува!");
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

        private IQueryable<Product> TotalProductsAfterCategoryFilter(string filter)
        {
            var productsQuery = repo.AllReadonlyAsync<Product>().Where(p => p.IsAvailable);

            if (filter == "")
            {
                return productsQuery;
            }
            var filterArray = filter.Split('-').ToArray();

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
                if (filterArray.Length >= 2)
                {
                    productsQuery = productsQuery.Where(p => (int)p.GlobalCategory == int.Parse(filteringValue));

                    if (filterArray.Length > 2 && filterArray[2] != "")
                    {
                        var searchQuery = filterArray[2];

                        productsQuery = productsQuery
                            .Where(p =>
                            (int)p.GlobalCategory == int.Parse(filteringValue) &&
                            EF.Functions.Like(p.Name, "%" + searchQuery + "%"));
                    }
                    
                }                
            }

            return productsQuery;
        }
    }
}
