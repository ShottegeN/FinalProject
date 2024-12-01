using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Core.Services;
using ToyShop.Data.Common;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    [Authorize]
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

            var products = await productService.GetUsersCartProductsAsync(userId);

            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(Guid productId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return RedirectToAction("Login", "Account");
            }

            await productService.AddToCartAsync(userId.Value, productId);

            return RedirectToAction("Details", "Product", new { productId });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(Guid productId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return RedirectToAction("Login", "Account");
            }

            await productService.RemoveFromCartAsync(userId.Value, productId);

            return RedirectToAction("Index", "Cart");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductQuantity(Guid productId, int quantity)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return RedirectToAction("Login", "Account");
            }

            await productService.UpdateProductQuantityAsync(userId.Value, productId, quantity);

            return RedirectToAction("Index", "Cart");
        }

        [HttpGet]
        public async Task<IActionResult> GetCartItemCount()
        {
            Guid? userId = GetCurrentUserId();  

            if (!userId.HasValue)
            {
                return Json(0);  
            }

            var products = await productService.GetUsersCartProductsAsync(userId.Value);
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
