using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.Web.Models;

namespace ToyShop.Web.Controllers
{
    //[Authorize]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> logger;
        private readonly IProductService productService;
        

        public ProductController(ILogger<ProductController> _logger, IProductService _productService)
        {
            logger = _logger;
            productService = _productService;
        }

        public IActionResult Index()
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
