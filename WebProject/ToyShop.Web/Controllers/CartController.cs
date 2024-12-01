using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
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
