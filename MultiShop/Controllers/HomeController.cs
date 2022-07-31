using System.Collections.Generic;
using System.Linq;
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
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
		private readonly UserManager<AppUser> _userManager;

		public HomeController(ApplicationDbContext context, UserManager<AppUser> userManager
            )
        {
            _context = context;
			_userManager = userManager;
		}
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM()
            {
                Dresses = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).ToListAsync(),
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.Include(c => c.Dresses).ToListAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> Cart()
        {
			if (User.Identity.IsAuthenticated)
			{
                string basketstr = HttpContext.Request.Cookies["Basket"]; 

				AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                List<BasketItem> existed = await _context.BasketItems.Where(b => b.AppUserId == user.Id).ToListAsync();

                if (existed == null)
				{
                    return View();
				}
				else
				{
                    CartBasketVM cartBasket = new CartBasketVM();
                    cartBasket.BasketItemVMs = new List<BasketItemVM>();

                    foreach (BasketItem item in existed)
					{
                        BasketItemVM basketItem = new BasketItemVM
                        {
                            Dress = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).FirstOrDefaultAsync(d => d.Id == item.DressId),
                            Quantity = item.Quantity
                        };
                        cartBasket.BasketItemVMs.Add(basketItem);
                        cartBasket.ToatlPrice += item.Price * item.Quantity;
                    }
                    return View(cartBasket);
				}
            }
			else
			{
                string basketstr = HttpContext.Request.Cookies["Basket"];
                if (basketstr != null)
                {
                    BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(basketstr);
                    CartBasketVM cartBasket = new CartBasketVM();
                    cartBasket.BasketItemVMs = new List<BasketItemVM>();
                    foreach (BasketCookieItemVM cookie in basket.BasketCookieItemVMs)
                    {
                        Dress existed = _context.Dresses.Include(d => d.Images).FirstOrDefault(d => d.Id == cookie.Id);
                        if (existed == null)
                        {
                            basket.BasketCookieItemVMs.Remove(cookie);
                            continue;
                        }
                        BasketItemVM basketItem = new BasketItemVM()
                        {
                            Dress = existed,
                            Quantity = cookie.Quantity,
                        };
                        cartBasket.BasketItemVMs.Add(basketItem);
                        cartBasket.ToatlPrice = basket.TotalPrice;
                    }
                    return View(cartBasket);
                }
            }
            HttpContext.Response.Cookies.Delete("Basket");
            return View();
        }
    }
}
