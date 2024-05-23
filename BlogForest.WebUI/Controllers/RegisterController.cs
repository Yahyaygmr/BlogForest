using BlogForest.Dtolayer.RegisterDtos;
using BlogForest.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateRegisterDto dto)
        {
            AppUser appUser = new AppUser()
            {
                Name = dto.Name,
                Email = dto.Email,
                Surname = dto.Surname,
                ImageUrl = dto.ImageUrl,
                Description = dto.Description,
                UserName = dto.UserName,
            };
            var result = await _userManager.CreateAsync(appUser, dto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
