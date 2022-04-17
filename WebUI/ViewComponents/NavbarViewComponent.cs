using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace WebUI.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            return View();
        }
    }
}
