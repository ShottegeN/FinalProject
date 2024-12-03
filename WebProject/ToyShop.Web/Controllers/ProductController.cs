using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Core.Services;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    //[Authorize(Roles = "Administrator, Moderator")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> logger;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(ILogger<ProductController> _logger, IProductService _productService, ICategoryService _categoryService)
        {
            logger = _logger;
            productService = _productService;
            categoryService = _categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var addProductViewModel = new AddOrEditProductViewModel
            {
                Product = new UIProductViewModel(),
                Categories = await categoryService.GetAllCategoriesAsync()
            };

            return View(addProductViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddOrEditProductViewModel productViewModel, string? newCategoryName)
        {
            if (!ModelState.IsValid)
            {
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();

                return View(productViewModel);
            }

            try
            {
                await productService.AddProductAsync(productViewModel.Product, newCategoryName!);
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("NewCategoryName", ex.Message);
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();
                productViewModel.NewCategoryName = "new";

                return View(productViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {

            var addProductViewModel = new AddOrEditProductViewModel
            {
                Product = await productService.GetproductForEditAsync(id),
                Categories = await categoryService.GetAllCategoriesAsync()
            };

            return View(addProductViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AddOrEditProductViewModel productViewModel, string? newCategoryName)
        {
            if (!ModelState.IsValid)
            {
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();

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
            catch (ArgumentNullException)
            {
                TempData["ErrorMessage"] = "Ресурсът не е намерен!.";
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> WriteProductReview(Guid productId, string username, int rating, string comment)
        {

            await productService.WriteProductReviewAsync(productId, username, rating, comment);

            return RedirectToAction("Details", "Product", new { productId = productId });
        }


        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var product = await productService.GetproductForDeleteAsync(id);

                return View(product);

            }
            catch (ArgumentNullException)
            {
                TempData["ErrorMessage"] = "Невалидна операция!";
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductInfoViewModel product)
        {
            await productService.DeleteProductAsync(product.Id);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Whishlist()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Json(0);
            }

            var products = await productService.GetUsersWhishlistAsync(userId.Value);

            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddToWishlist(Guid productId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return RedirectToAction("Login", "Account");
            }

            await productService.AddToWishlistAsync(userId.Value, productId);

            return RedirectToAction("Whishlist", "Product");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromWhishlist(Guid productId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return RedirectToAction("/Identity/Account/Login");
            }

            await productService.RemoveFromWhishlistAsync(userId.Value, productId);

            return RedirectToAction("Whishlist", "Product");
        }

        [HttpGet]
        public async Task<IActionResult> GetWhishlistProductsCount()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Json(0);
            }

            var products = await productService.GetUsersWhishlistAsync(userId.Value);
            int cartItemCount = products.Count();

            return Json(cartItemCount);
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
