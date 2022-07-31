using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;
using MultiShop.ViewModels;
using Newtonsoft.Json;

namespace MultiShop.Services
{
    public class LayoutService
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _http;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(ApplicationDbContext context, IHttpContextAccessor http, UserManager<AppUser> userManager)
        {
            _context = context;
            _http = http;
            _userManager = userManager;
        }
        public List<Setting> GetSettings()
        {
            List<Setting> settings = _context.Settings.ToList();
            return settings;
        }
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        public async Task<BasketVM> GetBasket()
        {
            if (_http.HttpContext.User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(_http.HttpContext.User.Identity.Name);

                List<BasketItem> existed = await _context.BasketItems.Where(b => b.AppUserId == user.Id).ToListAsync();

                if(existed != null)
                {
                    BasketVM basket = new BasketVM();
                    basket.BasketCookieItemVMs = new List<BasketCookieItemVM>();

                    foreach (BasketItem item in existed)
                    {
                        BasketCookieItemVM basketCookie = new BasketCookieItemVM()
                        {
                            Id = item.DressId,
                            Quantity = item.Quantity
                        };
                        basket.BasketCookieItemVMs.Add(basketCookie);
                    }
                    return basket;
                }
                return null;
            }
            else
            {
                string basketstr = _http.HttpContext.Request.Cookies["Basket"];

                if (!string.IsNullOrEmpty(basketstr))
                {
                    BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(basketstr);

                    foreach (BasketCookieItemVM cookie in basket.BasketCookieItemVMs)
                    {
                        Dress existed = _context.Dresses.FirstOrDefault(d => d.Id == cookie.Id);
                        if (existed == null)
                        {
                            basket.BasketCookieItemVMs.Remove(cookie);
                        }
                    }
                    return basket;
                }
                return null;
            }
        }
    }
}