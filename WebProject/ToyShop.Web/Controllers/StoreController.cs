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

        public async Task<IActionResult> Index(string sortBy = "rating", int pageNumber = 1, int pageSize = 9, string filter = "")
        {           
            var storeViewModel = await productService.GetStoreViewModelAsync(sortBy, pageNumber, pageSize, filter);
            storeViewModel.AllCategories = await categoryService.GetAllCategoriesAsync();           

            return View(storeViewModel);
        }


        //modelState.Isvalid should be after all other errors, so all of them could be displayed at once! 
        // use modelState.AddModelError for the different errors!
    }
}
