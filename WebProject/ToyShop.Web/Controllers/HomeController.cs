using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
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
            var newProducts = await productService.GetNewProductsAsync();
            var homeProducts = new HomeProductsViewModel
            {
                NewProducts = newProducts
            };
            return View(homeProducts);
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
