using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Core.Services;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    //[Authorize(Roles = "Administrator, Moderator")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> logger;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(ILogger<ProductController> _logger, IProductService _productService, ICategoryService _categoryService)
        {
            logger = _logger;
            productService = _productService;
            categoryService = _categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var addProductViewModel = new AddOrEditProductViewModel
            {
                Product = new UIProductViewModel(),
                Categories = await categoryService.GetAllCategoriesAsync()
            };

            return View(addProductViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddOrEditProductViewModel productViewModel, string? newCategoryName)
        {
            if (!ModelState.IsValid)
            {
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();

                return View(productViewModel);
            }

            try
            {
                await productService.AddProductAsync(productViewModel.Product, newCategoryName!);
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("NewCategoryName", ex.Message);
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync(); 
                productViewModel.NewCategoryName = "new";

                return View(productViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {

            var addProductViewModel = new AddOrEditProductViewModel
            {
                Product = await productService.GetproductForEditAsync(id),
                Categories = await categoryService.GetAllCategoriesAsync()
            };

            return View(addProductViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AddOrEditProductViewModel productViewModel, string? newCategoryName)
        {
            if (!ModelState.IsValid)
            {
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();

                return View(productViewModel);
            }

            try
            {
                await productService.EditProductAsync(productViewModel.Product, newCategoryName!);
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("NewCategoryName", ex.Message);
                productViewModel.Categories = await categoryService.GetAllCategoriesAsync();
                productViewModel.NewCategoryName = "new";

                return View(productViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(Guid productId)
        {
            try
            {
                var product = await productService.GetProductForDetailsAsync(productId);

                return View(product);
            }
            catch (ArgumentNullException)
            {
                TempData["ErrorMessage"] = "Ресурсът не е намерен!.";
                return RedirectToAction("Error", "Home");
            }
        }


        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var product = await productService.GetproductForDeleteAsync(id);

                return View(product);

            }
            catch (ArgumentNullException)
            {
                TempData["ErrorMessage"] = "Невалидна операция!";
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductInfoViewModel product)
        {
            await productService.DeleteProductAsync(product.Id);

            return RedirectToAction("Index", "Home");
        }
    }
}
