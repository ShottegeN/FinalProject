using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Common;
using ToyShop.Core.Contracts;
using ToyShop.Data.Models;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    [Authorize(Roles = "Administrator, Moderator")]
    public class PromotionController : Controller
    {
        private readonly IPromotionService promotionService;

        public PromotionController(IPromotionService _promotionService)
        {
            promotionService = _promotionService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var promotions = await promotionService.GetAllPromotionsAsync();
            return View(promotions);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(PromotionViewModel promotion)
        {
            if (!ModelState.IsValid)
            {
                return View(promotion);
            }

            try
            {
                await promotionService.AddPromotionAsync(promotion);
                return RedirectToAction(nameof(Index));
            }
            catch (CustomException ex)
            {
                ModelState.AddModelError(ex.FieldName, ex.Message);
                return View(promotion);
            }
            catch (ArgumentException argEx)
            {
                TempData["ErrorMessage"] = argEx.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var promotion = await promotionService.GetPromotionByIdAsync(id);
                return View(promotion);
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PromotionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await promotionService.EditPromotionAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (CustomException ex)
            {
                ModelState.AddModelError(ex.FieldName, ex.Message);
                return View(model);
            }
            catch (ArgumentException argEx)
            {
                TempData["ErrorMessage"] = argEx.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                var promotion = await promotionService.GetPromotionByIdAsync(id);
                return View(promotion);
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveConfirmed(int id)
        {
            await promotionService.RemovePromotionAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}