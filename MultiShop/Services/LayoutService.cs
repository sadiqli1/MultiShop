using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
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

        public LayoutService(ApplicationDbContext context, IHttpContextAccessor http)
        {
            _context = context;
            _http = http;
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
        public BasketVM GetBasket()
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
