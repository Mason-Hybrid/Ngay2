using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ngay2.Controllers
{
    // ATTRIBUTE ROUTING: Controller này sử dụng Attribute Routing
    // Dùng [Route] attribute để định nghĩa URL pattern trực tiếp trên controller và action
    // Attribute Routing cho phép kiểm soát chính xác URL, không phụ thuộc convention
    [Route("[controller]")]
    public class HelloController : Controller
    {
        // ATTRIBUTE ROUTING: URL: /Hello hoặc /Hello/Index
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        // ATTRIBUTE ROUTING: URL: /Hello/Welcome?name=xxx&numTimes=x
        // Hoặc: /Hello/Welcome/xxx/3
        [Route("Welcome/{name?}/{numTimes:int?}")]
        public IActionResult Welcome(string name = "Guest", int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        // ATTRIBUTE ROUTING: URL tùy chỉnh: /Hello/About hoặc /gioi-thieu
        [Route("About")]
        [Route("/gioi-thieu")]
        public IActionResult About()
        {
            ViewData["Message"] = "Đây là trang giới thiệu - sử dụng Attribute Routing";
            return View();
        }
    }
}
