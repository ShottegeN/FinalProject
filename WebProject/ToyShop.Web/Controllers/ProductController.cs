using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Common;
using ToyShop.Core.Contracts;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    [Authorize(Roles = "User")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> logger;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IPromotionService promotionService;

        public ProductController(ILogger<ProductController> _logger, IProductService _productService, ICategoryService _categoryService, IPromotionService _promotionService)
        {
            logger = _logger;
            productService = _productService;
            categoryService = _categoryService;
            promotionService = _promotionService;
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return RedirectToAction("/Identity/Account/Login");
            }

            try
            {
                var addProductViewModel = new AddOrEditProductViewModel
                {
                    Product = new UIProductViewModel(),
                    Categories = await categoryService.GetAllCategoriesAsync(),
                    Promotions = await promotionService.GetAllPromotionsAsync(),
                };

                return View(addProductViewModel);
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        public async Task<IActionResult> Add(AddOrEditProductViewModel productViewModel, string? newCategoryName)
        {
            if (!ModelState.IsValid)
            {
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();
                productViewModel.Promotions = await promotionService.GetAllPromotionsAsync();

                return View(productViewModel);
            }

            try
            {
                await productService.AddProductAsync(productViewModel.Product, newCategoryName!);
            }
            catch (CustomException ex)
            {
                ModelState.AddModelError(ex.FieldName, ex.Message);
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();
                productViewModel.Promotions = await promotionService.GetAllPromotionsAsync();
                productViewModel.NewCategoryName = "new";

                return View(productViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            try
            {
                var addProductViewModel = new AddOrEditProductViewModel
                {
                    Product = await productService.GetproductForEditAsync(id),
                    Categories = await categoryService.GetAllCategoriesAsync(),
                    Promotions = await promotionService.GetAllPromotionsAsync(),
                };

                return View(addProductViewModel);
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        public async Task<IActionResult> Edit(AddOrEditProductViewModel productViewModel, string? newCategoryName)
        {
            if (!ModelState.IsValid)
            {
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();
                productViewModel.Promotions = await promotionService.GetAllPromotionsAsync();
                return View(productViewModel);
            }

            try
            {
                await productService.EditProductAsync(productViewModel.Product, newCategoryName!);
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("NewCategoryName", ex.Message);
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();
                productViewModel.Promotions = await promotionService.GetAllPromotionsAsync();
                productViewModel.NewCategoryName = "new";

                return View(productViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(Guid productId)
        {
            try
            {
                var product = await productService.GetProductForDetailsAsync(productId);

                return View(product);
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> WriteProductReview(Guid productId, string username, int rating, string comment)
        {
            if (username == null)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                await productService.WriteProductReviewAsync(productId, username, rating, comment);

                return RedirectToAction("Details", "Product", new { productId });
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var product = await productService.GetproductForDeleteAsync(id);

                return View(product);

            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        public async Task<IActionResult> Delete(ProductInfoViewModel product)
        {
            try
            {
                await productService.DeleteProductAsync(product.Id);
                return RedirectToAction("Index", "Home");
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Whishlist()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                var products = await productService.GetUsersWhishlistAsync(userId.Value);
                return View(products);
            }
            catch (ArgumentNullException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToWishlist(Guid productId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");

            }

            try
            {
                await productService.AddToWishlistAsync(userId.Value, productId);
                return RedirectToAction("Whishlist", "Product");
            }
            catch (ArgumentNullException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }

        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromWhishlist(Guid productId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return RedirectToAction("/Identity/Account/Login");
            }

            try
            {
                await productService.RemoveFromWhishlistAsync(userId.Value, productId);
                return RedirectToAction("Whishlist", "Product");
            }
            catch (ArgumentNullException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetWhishlistProductsCount()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Json(0);
            }

            try
            {
                var products = await productService.GetUsersWhishlistAsync(userId.Value);
                int cartItemCount = products.Count();

                return Json(cartItemCount);
            }
            catch (ArgumentNullException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        //private
        private Guid? GetCurrentUserId()
        {
            var userIdClaim = User.Claims.FirstOrDefault()?.Value;
            if (Guid.TryParse(userIdClaim, out var userId))
            {
                return userId;
            }

            return null;
        }
    }
}
