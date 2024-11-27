using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Data.Common;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> logger;
        private readonly IRepository repo;

        public OrderController(ILogger<OrderController> _logger, IRepository _repo)
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
    }
}
