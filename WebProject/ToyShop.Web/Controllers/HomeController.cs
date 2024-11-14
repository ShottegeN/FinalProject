using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Core.Services;
using ToyShop.Data.Common;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> _logger, IProductService _productService)
        {
            logger = _logger;
            productService = _productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await productService.GetNewProductsAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
