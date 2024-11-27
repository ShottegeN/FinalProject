using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Data.Common;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> logger;
        private readonly IRepository repo;

        public CartController(ILogger<CartController> _logger, IRepository _repo)
        {
            logger = _logger;
            repo = _repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var model = new ErrorViewModel
            {
                Title = "Упс! Възникна грешка.",
                Message = "Не успяхме да обработим вашата заявка. Моля, опитайте отново по-късно.",
                SupportContact = "support@toyshop.com" // Примерен имейл за контакт
            };

            return View(model);
        }

    }
}
