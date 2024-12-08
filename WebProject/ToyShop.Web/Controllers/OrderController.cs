using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Common;
using ToyShop.Core.Contracts;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly ILogger<OrderController> logger;

        public OrderController(ILogger<OrderController> _logger, IOrderService _orderService)
        {
            logger = _logger;
            orderService = _orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int pageNumber = 1, DateTime? startDate = null, DateTime? endDate = null)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            var ordersData = await orderService.GetPaginatedUserOrdersAsync(userId.Value, pageNumber, startDate, endDate);

            return View(ordersData);
        }


        [HttpGet]
        public async Task<IActionResult> Check(List<ProductInfoViewModel> products)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            var order = await orderService.CheckOrderAsync(userId.Value, products);

            return View(order);
        }

        public async Task<IActionResult> Cancel()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Finish(OrderViewModel order)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }
           
            if (!ModelState.IsValid)
            {               
                return View("Check", order);
            }

            string orderNumber = await orderService.FinishOrderAsync(userId.Value, order);

            return RedirectToAction("Details", "Order", new {orderNumber});
        }

        [HttpGet]
        public async Task<ActionResult> Details(string orderNumber)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                var order = await orderService.GetOrderByNumberAsync(userId.Value, orderNumber);
                return View(order);
            }
            catch (FieldValidationException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
            
        }


        //private
        private Guid? GetCurrentUserId()
        {
            var userIdClaim = User.Claims.FirstOrDefault()?.Value;

            if (Guid.TryParse(userIdClaim, out var userId))
            {
                return userId;
            }

            return null;
        }        
    }
}
