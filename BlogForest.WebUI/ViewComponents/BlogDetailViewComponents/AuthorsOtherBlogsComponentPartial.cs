using BlogForest.Businesslayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class AuthorsOtherBlogsComponentPartial:ViewComponent
    {
        private readonly IBlogService _blogService;

        public AuthorsOtherBlogsComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _blogService.GetLast2BlogByAppUser(id);
            return View(values);
        }
    }
}
