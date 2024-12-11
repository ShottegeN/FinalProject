using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Data.Models;

namespace ToyShop.Web.Controllers
{
    [Authorize(Roles = "User")]
    public class CartController : Controller
    {
        private readonly ILogger<CartController> logger;
        private readonly IProductService productService;

        public CartController(ILogger<CartController> _logger, IProductService _productService)
        {
            logger = _logger;
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                var products = await productService.GetUsersCartProductsAsync(userId);

                return View(products);
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(Guid productId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                await productService.AddToCartAsync(userId.Value, productId);
                return RedirectToAction("Details", "Product", new { productId });
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(Guid productId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                await productService.RemoveFromCartAsync(userId.Value, productId);
                return RedirectToAction("Index", "Cart");
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductQuantity(Guid productId, int quantity)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return RedirectToAction("Login", "Account");
            }

            try
            {
                await productService.UpdateProductQuantityAsync(userId.Value, productId, quantity);
                return RedirectToAction("Index", "Cart");
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetCartItemCount()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Json(0);
            }

            try
            {
                var products = await productService.GetUsersCartProductsAsync(userId.Value);
                int cartItemCount = products.Count();

                return Json(cartItemCount);
            }
            catch (ArgumentException ex)
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
