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
        private readonly IPromotionService promotionService;

        public HomeController(ILogger<HomeController> _logger, IProductService _productService, IPromotionService _promotionService)
        {
            logger = _logger;
            productService = _productService;
            promotionService = _promotionService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var newProducts = await productService.GetNewestProductsAsync();
            var activePromotions = await promotionService.GetActivePromotionsAsync();

            var homeViewModel = new HomeViewModel
            {
                NewProducts = newProducts,
                ActivePromotions = activePromotions
            };
            return View(homeViewModel);
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
