using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Core.Services;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> logger;
        private readonly IProductService productService;

        public ProductController(ILogger<ProductController> _logger, IProductService _productService)
        {
            logger = _logger;
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid productId)
        {
            try
            {
                var product = await productService.GetProductForDetails(productId);

                return View(product);
            }
            catch (ArgumentNullException)
            {
                TempData["ErrorMessage"] = "Продуктът с дадения идентификатор не беше намерен.";
                return RedirectToAction("Error", "Home");
            }
        }


        [HttpGet]
        public async Task<IActionResult> Delete(Guid productId)
        {
            var product = await productService.GetProductForDetails(productId);

            return View(product);
        }
    }
}
