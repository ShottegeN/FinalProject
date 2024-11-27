using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToyShop.Data.Common;
using ToyShop.ViewModels;

namespace ToyShop.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> logger;
        private readonly IRepository repo;

        public CartController(ILogger<CartController> _logger, IRepository _repo)
        {
            logger = _logger;
            repo = _repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var model = new ErrorViewModel
            {
                Title = "���! �������� ������.",
                Message = "�� ������� �� ��������� ������ ������. ����, �������� ������ ��-�����.",
                SupportContact = "support@toyshop.com" // �������� ����� �� �������
            };

            return View(model);
        }

    }
}
