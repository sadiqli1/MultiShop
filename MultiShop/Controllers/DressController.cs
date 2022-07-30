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
    public class DressController : Controller
    {
        private readonly ApplicationDbContext _context;
		private readonly UserManager<AppUser> _userManager;

		public DressController(ApplicationDbContext context ,UserManager<AppUser> userManager)
        {
            _context = context;
			_userManager = userManager;
		}
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Dress existed = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).FirstOrDefaultAsync(d => d.Id == id);
            if (existed == null) return NotFound();
            DetailVM detailVM = new DetailVM()
            {
                Dress = existed,
                Colors = _context.Colors.ToList(),
                Sizes = _context.Sizes.ToList(),
            };
            return View(detailVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Detail(DetailVM detailVM, int? id)
        {
            return Json(detailVM.Dress == null);
        }
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Dress dress = _context.Dresses.FirstOrDefault(d => d.Id == id);
            if (dress == null) return NotFound();

            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
			{
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if(user == null) return NotFound();

                BasketItem existed = await _context.BasketItems.FirstOrDefaultAsync(b => b.AppUserId == user.Id && b.DressId == dress.Id);
                if(existed == null)
				{
                    existed = new BasketItem()
                    {
                        Dress = dress,
                        AppUser = user,
                        Quantity = 1,
                        Price = dress.Price
					};
                    _context.BasketItems.Add(existed);
				}
				else
				{
                    existed.Quantity++;
				}
                await _context.SaveChangesAsync();
            }
            else
			{
                string basketstr = HttpContext.Request.Cookies["Basket"];

                BasketVM basket;

                if (string.IsNullOrEmpty(basketstr))
                {
                    basket = new BasketVM();
                    basket.BasketCookieItemVMs = new List<BasketCookieItemVM>();

                    BasketCookieItemVM cookiItem = new BasketCookieItemVM()
                    {
                        Id = dress.Id,
                        Quantity = 1
                    };
                    basket.BasketCookieItemVMs.Add(cookiItem);
                    basket.TotalPrice = dress.Price;
                }
                else
                {
                    basket = JsonConvert.DeserializeObject<BasketVM>(basketstr);

                    BasketCookieItemVM existed = basket.BasketCookieItemVMs.FirstOrDefault(b => b.Id == id);
                    if (existed == null)
                    {
                        BasketCookieItemVM cookiItem = new BasketCookieItemVM()
                        {
                            Id = dress.Id,
                            Quantity = 1
                        };
                        basket.BasketCookieItemVMs.Add(cookiItem);
                        basket.TotalPrice += dress.Price;
                    }
                    else
                    {
                        existed.Quantity++;
                        basket.TotalPrice += dress.Price;
                    }
                }

                basketstr = JsonConvert.SerializeObject(basket);
                HttpContext.Response.Cookies.Append("Basket", basketstr);
            }

            return RedirectToAction("Index", "Home");
        }
        public IActionResult RemoveBasket(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Dress dress = _context.Dresses.FirstOrDefault(d => d.Id == id);
            BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(HttpContext.Request.Cookies["Basket"]);
            if(basket != null)
            {
                foreach (BasketCookieItemVM item in basket.BasketCookieItemVMs)
                {
                    if (item.Id == id)
                    {
                        if(item.Quantity > 1)
                        {
                            item.Quantity -= 1;
                            basket.TotalPrice -= dress.Price;
                        }
                        else
                        {
                            basket.TotalPrice -= dress.Price * item.Quantity;
                            basket.BasketCookieItemVMs.Remove(item);
                            break;
                        }
                    }
                }
            }
            string basketstr = JsonConvert.SerializeObject(basket);
            HttpContext.Response.Cookies.Append("Basket", basketstr);
            return RedirectToAction("Cart", "Home");
        }
        public IActionResult ShowBasket()
        {
            if (HttpContext.Request.Cookies["basket"] == null) return NotFound();

            BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(HttpContext.Request.Cookies["Basket"]);

            return Content(HttpContext.Request.Cookies["Basket"]);
        }


        public IActionResult AddWish(int? id)
        {
            if (id is null || id == 0) return NotFound();

            Dress existed = _context.Dresses.FirstOrDefault(d => d.Id == id);
            if (existed == null) return NotFound();

            string wishstr = HttpContext.Request.Cookies["Wish"];

            WishVM wish = new WishVM();

            if (string.IsNullOrEmpty(wishstr))
            {
                wish.WishCookieItemVMs = new List<WishCookieItemVM>();
                WishCookieItemVM cookieItem = new WishCookieItemVM()
                {
                    Id = existed.Id,
                    Quantity = 1
                };
                wish.WishCookieItemVMs.Add(cookieItem);
            }

            wishstr = JsonConvert.SerializeObject(wish);

            HttpContext.Response.Cookies.Append("Wish", wishstr);
            return RedirectToAction("Index");
        }
        public IActionResult ShowWishList()
        {
            if (HttpContext.Request.Cookies["Wish"] == null) return NotFound();

            WishVM wish = JsonConvert.DeserializeObject<WishVM>(HttpContext.Request.Cookies["Wish"]);

            return Content(HttpContext.Request.Cookies["Wish"]);
        }
    }
}
