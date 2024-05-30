using BlogForest.Businesslayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IBlogService _blogService;

        public DefaultController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogDetail(int id)
        {
            var values = _blogService.GetById(id);
            _blogService.IncreaseBlogViewCount(id);
            return View(values);
        }
    }
}
