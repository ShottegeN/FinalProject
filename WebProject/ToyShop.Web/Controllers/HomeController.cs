using Microsoft.AspNetCore.Mvc;
using ToyShop.Common;
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
            var homeViewModel = new HomeViewModel
            {
                NewProducts = await productService.GetNewest10ProductsAsync(),
                ActivePromotions = await promotionService.GetActivePromotionsAsync()
            };

            return View(homeViewModel);
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeliveryAndReturning()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Terms()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var model = new ErrorViewModel
            {
                Title = "Упс! Възникна грешка.",
                Message = TempData["ErrorMessage"]?.ToString() ?? "Не успяхме да обработим вашата заявка. Моля, опитайте отново по-късно.",
                SupportContact = SiteData.GetEmail()
            };

            return View(model);
        }       
    }
}
