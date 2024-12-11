using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Common;
using ToyShop.Core.Contracts;
using ToyShop.Data.Models;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    [Authorize(Roles = "User")]
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
        public async Task<IActionResult> Index(int pageNumber = 1, DateTime? startDate = null, DateTime? endDate = null, string? status = null)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            var ordersData = await orderService.GetPaginatedUserOrdersAsync(userId.Value, pageNumber, startDate, endDate, status);

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

        [HttpPost]
        public async Task<IActionResult> Cancel(Guid orderId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                await orderService.CancelOrderAsync(userId.Value, orderId);
                return RedirectToAction("Index", "Order");
            }
            catch (CustomException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
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

            return RedirectToAction("Details", "Order", new { orderNumber });
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
                var order = await orderService.GetOrderForDetailsAsync(userId.Value, orderNumber);
                return View(order);
            }
            catch (CustomException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }

        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<ActionResult> Edit(Guid orderId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                var order = await orderService.GetOrderForEditAsync(userId.Value, orderId);
                return View(order);
            }
            catch (CustomException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<ActionResult> Edit(OrderViewModel order)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            if (!ModelState.IsValid)
            {
                return View(order);
            }

            try
            {
                await orderService.EditOrderAsync(userId.Value, order);
                return RedirectToAction("Index", "Order");
            }
            catch (CustomException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(order);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> Delete(Guid orderId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            try
            {
                await orderService.DeleteOrderAsync(userId.Value, orderId);
                return RedirectToAction("Index", "Order");
            }
            catch (CustomException ex)
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
