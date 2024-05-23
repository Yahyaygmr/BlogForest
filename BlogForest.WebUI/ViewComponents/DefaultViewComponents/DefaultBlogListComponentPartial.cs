using BlogForest.Businesslayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.DefaultViewComponents
{
    public class DefaultBlogListComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public DefaultBlogListComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogService.GetBlogsWithCategoryAndUser();
            return View(values);
        }
    }
}
