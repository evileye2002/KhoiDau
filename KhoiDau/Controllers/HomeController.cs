using KhoiDau.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KhoiDau.Controllers
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

        public IActionResult SanPham()
        {
            return View();
        }

        public IActionResult GioiThieu()
        {
            return View();
        }

        public IActionResult DanhMuc()
        {
            return View();
        }

        public IActionResult LienHe()
        {
            return View();
        }

        public IActionResult DangNhap()
        {
            return View();
        }

        public IActionResult TaiXuong()
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