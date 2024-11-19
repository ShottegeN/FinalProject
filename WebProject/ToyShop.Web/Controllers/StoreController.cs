using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    //[Authorize]
    public class StoreController : Controller
    {
        private readonly ILogger<StoreController> logger;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public StoreController(ILogger<StoreController> _logger, IProductService _productService, ICategoryService _categoryService)
        {
            logger = _logger;
            productService = _productService;
            categoryService = _categoryService;
        }

        public async Task<IActionResult> Index(string sortBy = "rating", int pageNumber = 1, int pageSize = 9)
        {
            var products = await productService.GetAllProductsAsync(sortBy, pageNumber, pageSize);
            var categories = await categoryService.GetAllCategoriesAsync();
            var productsCount = await productService.GetAllProductsCountAsync();
            var totalPages = (int)Math.Ceiling(productsCount / (double)pageSize);

            var storeViewModel = new StoreViewModel
            {
                AllProducts = products,
                AllCategories = categories,
                CurrentPage = pageNumber,
                TotalPages = totalPages,
                SortBy = sortBy,
                PageSize = pageSize
            };

            return View(storeViewModel);
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
