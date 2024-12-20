﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Core.Contracts;

namespace ToyShop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class UserManagementController : Controller
    {
        private readonly IUserService userService;

        public UserManagementController(IUserService _userService)
        {
            userService = _userService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var users = await userService.GetAllUsersAsync();
                return View(users);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(string userId, string role)
        {
            Guid userGuid = Guid.Empty;
            if (!IsGuidValid(userId, ref userGuid))
            {
                return RedirectToAction(nameof(Index));
            }

            bool userExists = await userService
                .UserExistsByIdAsync(userGuid);
            if (!userExists)
            {
                return RedirectToAction(nameof(Index));
            }

            bool assignResult = await userService
                .AssignUserToRoleAsync(userGuid, role);
            if (!assignResult)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveRole(string userId, string role)
        {
            Guid userGuid = Guid.Empty;
            if (!IsGuidValid(userId, ref userGuid))
            {
                return RedirectToAction(nameof(Index));
            }

            bool userExists = await userService
                .UserExistsByIdAsync(userGuid);
            if (!userExists)
            {
                return RedirectToAction(nameof(Index));
            }

            bool removeResult = await userService
                .RemoveUserRoleAsync(userGuid, role);
            if (!removeResult)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            Guid userGuid = Guid.Empty;
            if (!IsGuidValid(userId, ref userGuid))
            {
                return RedirectToAction(nameof(Index));
            }

            bool userExists = await userService
                .UserExistsByIdAsync(userGuid);
            if (!userExists)
            {
                return RedirectToAction(nameof(Index));
            }

            bool removeResult = await userService
                .DeleteUserAsync(userGuid);
            if (!removeResult)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        //private
        private bool IsGuidValid(string? id, ref Guid parsedGuid)
        {
            // Non-existing parameter in the URL
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            // Invalid parameter in the URL
            bool isGuidValid = Guid.TryParse(id, out parsedGuid);
            if (!isGuidValid)
            {
                return false;
            }

            return true;
        }
    }
}
