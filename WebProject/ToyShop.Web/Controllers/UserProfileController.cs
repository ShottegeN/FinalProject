using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Common;
using ToyShop.Core.Contracts;
using ToyShop.Data.Models;
using ToyShop.ViewModels;


namespace ToyShop.Web.Controllers
{
    //[Area("Identity")]
    public class UserProfileController : Controller
    {
        private readonly ILogger<UserProfileController> logger;
        private readonly IUserService userService;
        private readonly SignInManager<User> signInManager;

        public UserProfileController(ILogger<UserProfileController> _logger, IUserService _userService, SignInManager<User> _signInManager)
        {
            logger = _logger;
            userService = _userService;
            signInManager = _signInManager;
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
            Guid? userId = GetCurrentUserId();

            if (!userId.HasValue)
            {
                return Redirect("/Identity/Account/Login");
            }

            if (!ModelState.IsValid)
            {
                return View(userProfile);
            }

            try
            {
                var user = await userService.GetUserAsync(userId.Value);

                await userService.SaveUserProfileAsync(userProfile);
                await userService.AssignUserToRoleAsync(userId.Value, "User");
                await signInManager.SignOutAsync();
                await signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }
            catch (CustomException cEx)
            {
                ModelState.AddModelError(cEx.FieldName, cEx.Message);
                return View(cEx);
            }
            catch (Exception ex)
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