using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Data.Common;
using ToyShop.Data.Models;

namespace ToyShop.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> logger;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly UserManager<User> userManager;

        public UserController(ILogger<UserController> _logger, RoleManager<IdentityRole<Guid>> _roleManager, UserManager<User> _userManager)
        {
            logger = _logger;
            roleManager = _roleManager;
            userManager = _userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> MakeUserAdministrator()
        {
            string roleName = "Administrator";

            IdentityResult? result = null;

            if (!await roleManager.RoleExistsAsync(roleName))
            {
                result = await roleManager.CreateAsync(new IdentityRole<Guid>(roleName));
            }

            if (!User.IsInRole(roleName) && (result == null || result.Succeeded))
            {
                var user = await userManager.FindByNameAsync(User?.Identity?.Name!);

                if (user != null)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }

            return RedirectToAction("Index");
        }
    }
}
