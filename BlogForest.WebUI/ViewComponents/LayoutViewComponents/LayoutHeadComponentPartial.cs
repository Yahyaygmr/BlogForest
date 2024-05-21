using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
