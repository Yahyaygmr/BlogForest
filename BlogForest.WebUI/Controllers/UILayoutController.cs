using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
