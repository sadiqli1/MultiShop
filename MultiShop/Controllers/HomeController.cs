using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
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
        public IActionResult Cart()
        {
            string basketstr = HttpContext.Request.Cookies["Basket"];
            if(basketstr != null)
            {
                BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(basketstr);
                CartBasketVM cartBasket = new CartBasketVM();
                cartBasket.BasketItemVMs = new List<BasketItemVM>();
                foreach (BasketCookieItemVM cookie in basket.BasketCookieItemVMs)
                {
                    Dress existed = _context.Dresses.Include(d => d.Images).FirstOrDefault(d => d.Id == cookie.Id);
                    if(existed == null)
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
            return View();
        }
    }
}
