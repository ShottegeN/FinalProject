using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Check(IEnumerable<ProductInfoViewModel> products)
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

            if (!ModelState.IsValid && order.DeliveryType != "Лично вземане")
            {
                return View("Check", order);
            }

            return RedirectToAction("Finish", "Order");
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
