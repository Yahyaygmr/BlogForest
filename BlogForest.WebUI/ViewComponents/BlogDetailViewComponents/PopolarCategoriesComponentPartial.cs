using BlogForest.Businesslayer.Abstract;
using BlogForest.DataAccesslayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class PopularCategoriesComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public PopularCategoriesComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.GetCategoryWithBlogCount();
            return View(values);
        }
    }
}
