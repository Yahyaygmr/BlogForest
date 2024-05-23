using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class AboutAuthorComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
