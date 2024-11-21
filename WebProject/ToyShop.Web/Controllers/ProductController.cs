using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Data.Common;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> logger;
        private readonly IRepository repo;

        public ProductController(ILogger<ProductController> _logger, IRepository _repo)
        {
            logger = _logger;
            repo = _repo;
        }

        public IActionResult Details()
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
