using AutoMapper;
using BlogForest.Businesslayer.Abstract;
using BlogForest.Dtolayer.BlogDtos;
using BlogForest.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/{controller}/{action}/{id?}")]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogController(UserManager<AppUser> userManager, IBlogService blogService, IMapper mapper)
        {
            _userManager = userManager;
            _blogService = blogService;
            _mapper = mapper;
        }

        public async Task<IActionResult> MyBlogsList()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            var blogs = _blogService.GetBlogsByAppUser(user.Id);

            return View(blogs);
        }
        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            createBlogDto.AppUserId = user.Id;
            createBlogDto.CreatedDate = DateTime.Now;

            var mappedValue = _mapper.Map<Blog>(createBlogDto);
            _blogService.Insert(mappedValue);

            return RedirectToAction("MyBlogsList");
        }
    }
}
