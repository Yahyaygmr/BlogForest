using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
