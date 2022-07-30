using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Models;
using MultiShop.ViewModels;

namespace MultiShop.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<AppUser> _usermanager;
		private readonly SignInManager<AppUser> _signInManager;
		private readonly RoleManager<IdentityRole> _rolemanager;

		public AccountController(UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolemanager)
		{
			_usermanager = usermanager;
			_signInManager = signInManager;
			_rolemanager = rolemanager;
		}
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
		{
            if(!ModelState.IsValid) return View();

			if (!register.Terms)
			{
                ModelState.AddModelError("Terms", "Please check our terms and conditions");
                return View();
			}

            AppUser appUser = new AppUser()
			{
                FirstName = register.Firstname,
                LastName = register.Lastname,
                UserName = register.Username,
                Email = register.Email
			};

            IdentityResult result = await _usermanager.CreateAsync(appUser, register.Password);

			if (!result.Succeeded)
			{
				foreach (IdentityError error in result.Errors)
				{
                    ModelState.AddModelError("", error.Description);
				}
                return View();
			}
			await _usermanager.AddToRoleAsync(appUser, "Member");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult> Login(LoginVM login)
		{
            if (!ModelState.IsValid) return View();

            AppUser user = await _usermanager.FindByNameAsync(login.Username);
            if(user == null) return View();

			Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, true);
			if (!result.Succeeded)
			{
				if (result.IsLockedOut)
				{
					ModelState.AddModelError("", "You have block 10 minut");
					return View();
				}
				ModelState.AddModelError("", "Username or Password is incorrect");
				return View();
			}
			return RedirectToAction("Index", "Home");
		}
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
		public IActionResult ShowAuthenticated()
		{
            return Json(User.Identity.IsAuthenticated);
		}
		public async Task CreateRole()
		{
			await _rolemanager.CreateAsync(new IdentityRole("Member"));
			await _rolemanager.CreateAsync(new IdentityRole("Moderator"));
			await _rolemanager.CreateAsync(new IdentityRole("Admin"));
		}
	}
}
