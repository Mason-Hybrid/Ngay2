using Microsoft.AspNetCore.Mvc;

namespace Ngay2.ViewComponents
{
    // VIEW COMPONENT: Component View được sử dụng để render một phần giao diện có logic riêng
    // View Component gồm 2 phần: class C# (logic) + view Razor (giao diện)
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menuItems = new List<string> { "Home", "Privacy", "Blog", "FAQ", "Welcome" };
            return View(menuItems);
        }
    }
}
