using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;
using MultiShop.ViewModels;
using Newtonsoft.Json;

namespace MultiShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public AccountController(ApplicationDbContext context, UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolemanager)
        {
            _context = context;
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
            if (!ModelState.IsValid) return View();

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
            if (user == null) return View();

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
            string basketstr = HttpContext.Request.Cookies["Basket"];
            if (!string.IsNullOrEmpty(basketstr))
            {
                BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(basketstr);

                BasketItem existed = await _context.BasketItems.FirstOrDefaultAsync(b => b.AppUserId == user.Id);

                foreach (var item in basket.BasketCookieItemVMs)
                {

                    if (existed != null)
                    {
                        if (existed.DressId == item.Id)
                        {
                            existed.Quantity += item.Quantity;
                        }
                        else
                        {
                            existed = new BasketItem
                            {
                                Dress = await _context.Dresses.FirstOrDefaultAsync(d => d.Id == item.Id),
                                AppUser = user,
                                Quantity = item.Quantity,
                                Price = _context.Dresses.Find(item.Id).Price
                            };
                        }
                    }
                    else
                    {
                        existed = new BasketItem
                        {
                            Dress = await _context.Dresses.FirstOrDefaultAsync(d => d.Id == item.Id),
                            AppUser = user,
                            Quantity = item.Quantity,
                            Price = _context.Dresses.Find(item.Id).Price
                        };
                    }

                    _context.BasketItems.Add(existed);
                }
                await _context.SaveChangesAsync();
            }
            HttpContext.Response.Cookies.Delete("Basket");
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
