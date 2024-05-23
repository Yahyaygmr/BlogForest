using BlogForest.Businesslayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class BlogDetailComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;
        public BlogDetailComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var values = _blogService.GetBlogWithCategoryAndUserById(id);
            return View(values);
        }
    }
}
