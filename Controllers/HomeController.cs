using KSTY.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KSTY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Phong()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Dichvu()
        {
            return View();
        }

        public IActionResult Checkin()
        {
            return View();
        }

        public IActionResult Gioithieu()
        {
            return View();
        }

        public IActionResult Lienhe()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}