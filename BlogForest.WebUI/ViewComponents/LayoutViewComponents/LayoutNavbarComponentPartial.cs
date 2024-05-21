using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
