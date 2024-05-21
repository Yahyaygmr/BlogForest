using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
