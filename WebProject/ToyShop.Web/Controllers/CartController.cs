using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> logger;
        private readonly IProductService productService;

        public CartController(ILogger<CartController> _logger, IProductService _productService)
        {
            logger = _logger;
            productService = _productService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = GetCurrentUserId();


            return View();
        }





        //private
        private string? GetCurrentUserId()
        {
            return User.Claims.FirstOrDefault()?.Value;
        }
    }
}
