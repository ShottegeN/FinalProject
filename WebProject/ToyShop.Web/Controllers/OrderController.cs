using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

            await orderService.FinishOrderAsync(userId.Value, order);

            return RedirectToAction("LastFinishedOrder", "Order", new {orderId = order.Id});
        }

        [HttpGet]
        public IActionResult LastFinishedOrder(Guid orderId)
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }                   

            return View(order);
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

        private AddressViewModel GetPersonalClaimAddress()
        {
            var address = new AddressViewModel
            {
                StreetName = "N/A",
                Number = 0,
                CityName = "N/A",
                PostCode = "N/A",
            };

            return address;
        }
    }
}
