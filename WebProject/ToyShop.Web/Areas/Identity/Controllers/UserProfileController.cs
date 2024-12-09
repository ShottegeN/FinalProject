using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;
using ToyShop.ViewModels.UserProfile;

namespace ToyShop.Web.Areas.Identity
{
    [Area("Identity")]  
    public class UserProfileController : Controller
    {
        private readonly ILogger<UserProfileController> logger;
        private readonly IUserService userService;

        public UserProfileController(ILogger<UserProfileController> _logger, IUserService _userService)
        {
            logger = _logger;
            userService = _userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            var user = await userService.GetUserProfileAsync(userId.Value);

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> SaveProfile(UserProfileViewModel userProfile)
        {
            return RedirectToAction("Index", "Home");
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
