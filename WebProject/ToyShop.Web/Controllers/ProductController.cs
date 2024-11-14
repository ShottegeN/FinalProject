using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.ViewModels;

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

        public async Task<IActionResult> Products()
        {
            var products = await productService.GetAllProductsAsync();
            return View(products);
        }

        //modelState.Isvalid should be after all other errors, so all of them could be displayed at once! 
        // use modelState.AddModelError for the different errors!







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
