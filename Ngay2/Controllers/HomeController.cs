using Microsoft.AspNetCore.Mvc;
using Ngay2.Models;
using System.Diagnostics;

namespace Ngay2.Controllers
{
    // CONVENTIONAL ROUTING: Controller này sử dụng conventional routing
    // được cấu hình trong Program.cs với pattern: {controller=Home}/{action=Index}/{id?}
    // Không cần dùng [Route] attribute, URL tự động map theo convention
    public class HomeController : Controller
    {
        // URL: / hoặc /Home hoặc /Home/Index (theo conventional routing)
        public IActionResult Index()
        {
            return View();
        }

        // URL: /Home/Privacy (theo conventional routing)
        public IActionResult Privacy()
        {
            return View();
        }

        // URL: /Home/Blog (theo conventional routing)
        public IActionResult Blog()
        {
            return View();
        }

        // URL: /Home/FAQ (theo conventional routing)
        public IActionResult FAQ()
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
