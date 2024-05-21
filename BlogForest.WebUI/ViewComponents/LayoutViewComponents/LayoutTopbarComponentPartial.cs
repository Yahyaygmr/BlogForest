using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutTopbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
