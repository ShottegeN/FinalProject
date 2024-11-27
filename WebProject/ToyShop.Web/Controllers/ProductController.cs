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

        public ProductController(ILogger<ProductController> _logger, IProductService _productService)
        {
            logger = _logger;
            productService = _productService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var product = new ProductInfoViewModel();

            return View(product);
        }

        [AllowAnonymous]
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
                TempData["ErrorMessage"] = "Ресурсът не е намерен!.";
                return RedirectToAction("Error", "Home");
            }
        }


        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var product = await productService.GetproductForDelete(id);

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
            var result = await productService.DeleteProductAsync(product.Id);

            return RedirectToAction("Index", "Home");
        }
    }
}
