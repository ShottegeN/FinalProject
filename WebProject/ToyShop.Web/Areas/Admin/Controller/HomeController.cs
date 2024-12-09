using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToyShop.Web.Areas.Admin
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator, Moderator")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }       
    }
}
