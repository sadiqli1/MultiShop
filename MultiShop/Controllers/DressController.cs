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

        public DressController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Dress existed = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).FirstOrDefaultAsync(d => d.Id == id);
            if (existed == null) return NotFound();

            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();

            ViewBag.SimilarProduct = _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).Where(d => d.CategoryId == existed.CategoryId).ToList();

            return View(existed);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Detail(Dress dress, int? id)
        {
            if (id is null || id == 0) return NotFound();

            Dress existed = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).FirstOrDefaultAsync(d => d.Id == id);
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();

            if (dress.SizeId == 0 || dress.ColorId == 0 || dress.Quantity == 0)
            {
                ModelState.AddModelError("", "Color, Size and Quantity Required");
                return View(existed);
            }

            await AddBasket(dress.Id, dress.SizeId, dress.ColorId, dress.Quantity);

            return RedirectToAction("index", "home");
        }
        public async Task<IActionResult> AddBasket(int? id, int? size, int? color, int count)
        {
            if (id == null || id == 0) return NotFound();

            Dress dress = _context.Dresses.FirstOrDefault(d => d.Id == id);
            if (dress == null) return NotFound();

            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                string basketstr = HttpContext.Request.Cookies["Basket"];

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null) return NotFound();

                BasketItem existed = await _context.BasketItems.FirstOrDefaultAsync(b => b.AppUserId == user.Id && b.DressId == dress.Id);


                if (existed == null)
                {
                    existed = new BasketItem()
                    {
                        Dress = dress,
                        AppUser = user,
                        Quantity = count,
                        Price = dress.Price,
                        Color = _context.Colors.FirstOrDefault(c => c.Id == color).Name,
                        Size = _context.Sizes.FirstOrDefault(s => s.Id == size).Name
                    };
                    _context.BasketItems.Add(existed);
                }
                else
                {
                    if (color != null || size != null)
                    {
                        bool exiscolor = _context.Colors.FirstOrDefault(c => c.Id == color).Name == existed.Color;
                        bool exissize = _context.Sizes.FirstOrDefault(c => c.Id == size).Name == existed.Size;

                        if (exiscolor == false || exissize == false)
                        {
                            existed = new BasketItem()
                            {
                                Dress = dress,
                                AppUser = user,
                                Quantity = count,
                                Price = dress.Price,
                                Color = _context.Colors.FirstOrDefault(c => c.Id == color).Name,
                                Size = _context.Sizes.FirstOrDefault(s => s.Id == size).Name
                            };
                            _context.BasketItems.Add(existed);
                        }
                        else
                        {
                            existed.Quantity++;
                        }
                    }
                    else
                    {
                        existed.Quantity++;
                    }
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
                        Quantity = count,
                        Color = _context.Colors.FirstOrDefault(c => c.Id == color).Name,
                        Size = _context.Sizes.FirstOrDefault(s => s.Id == size).Name
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
                            Quantity = count,
                            Color = _context.Colors.FirstOrDefault(c => c.Id == color).Name,
                            Size = _context.Sizes.FirstOrDefault(s => s.Id == size).Name
                        };
                        basket.BasketCookieItemVMs.Add(cookiItem);
                        basket.TotalPrice += dress.Price;
                    }
                    else
                    {
                        if (color != null || size != null)
                        {
                            bool exiscolor = _context.Colors.FirstOrDefault(c => c.Id == color).Name == existed.Color;
                            bool exissize = _context.Sizes.FirstOrDefault(c => c.Id == size).Name == existed.Size;

                            if (exiscolor == false || exissize == false)
                            {
                                BasketCookieItemVM cookiItem = new BasketCookieItemVM()
                                {
                                    Id = dress.Id,
                                    Quantity = count,
                                    Color = _context.Colors.FirstOrDefault(c => c.Id == color).Name,
                                    Size = _context.Sizes.FirstOrDefault(s => s.Id == size).Name
                                };
                                basket.BasketCookieItemVMs.Add(cookiItem);
                                basket.TotalPrice += dress.Price;
                            }
                        }
                        else
                        {
                            existed.Quantity++;
                            basket.TotalPrice += dress.Price;
                        }
                    }
                }

                basketstr = JsonConvert.SerializeObject(basket);
                HttpContext.Response.Cookies.Append("Basket", basketstr);
            }

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> RemoveBasket(int? id)
        {
            if (id == null || id == 0) return NotFound();


            Dress dress = _context.Dresses.FirstOrDefault(d => d.Id == id);

            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                BasketItem existed = await _context.BasketItems.FirstOrDefaultAsync(b => b.AppUserId == user.Id && b.DressId == id);

                if (existed != null)
                {
                    if (existed.Quantity > 1)
                    {
                        existed.Quantity -= 1;
                    }
                    else
                    {
                        _context.BasketItems.Remove(existed);
                    }
                }
                _context.SaveChanges();
            }
            else
            {
                BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(HttpContext.Request.Cookies["Basket"]);
                if (basket != null)
                {
                    foreach (BasketCookieItemVM item in basket.BasketCookieItemVMs)
                    {
                        if (item.Id == id)
                        {
                            if (item.Quantity > 1)
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
            }

            return RedirectToAction("Cart", "Home");
        }
        public async Task<IActionResult> RemoveAllBasket(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Dress dress = _context.Dresses.FirstOrDefault(d => d.Id == id);

            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                BasketItem existed = await _context.BasketItems.FirstOrDefaultAsync(b => b.AppUserId == user.Id && b.DressId == id);

                if (existed != null)
                {
                    _context.BasketItems.Remove(existed);
                }
                _context.SaveChanges();
            }
            else
            {
                BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(HttpContext.Request.Cookies["Basket"]);
                if (basket != null)
                {
                    List<BasketCookieItemVM> removable = new List<BasketCookieItemVM>();

                    foreach (BasketCookieItemVM item in basket.BasketCookieItemVMs)
                    {
                        if (item.Id == id)
                        {
                            basket.TotalPrice = 0;
                            removable.Add(item);
                        }
                    }
                    basket.BasketCookieItemVMs.RemoveAll(b => removable.Any(r => r.Id == b.Id));
                }
                string basketstr = JsonConvert.SerializeObject(basket);
                HttpContext.Response.Cookies.Append("Basket", basketstr);
            }
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
            if (id == null || id == 0) return NotFound();

            Dress dress = _context.Dresses.FirstOrDefault(d => d.Id == id);
            if (dress == null) return NotFound();

            #region Wish
            //if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            //{
            //    string wishstr = HttpContext.Request.Cookies["Wish"];

            //    AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            //    if (user == null) return NotFound();

            //    BasketItem existed = await _context.BasketItems.FirstOrDefaultAsync(b => b.AppUserId == user.Id && b.DressId == dress.Id);
            //    if (existed == null)
            //    {
            //        existed = new BasketItem()
            //        {
            //            Dress = dress,
            //            AppUser = user,
            //            Quantity = 1,
            //            Price = dress.Price
            //        };
            //        _context.BasketItems.Add(existed);
            //    }
            //    else
            //    {
            //        existed.Quantity++;
            //    }

            //    await _context.SaveChangesAsync();
            //}
            #endregion

            string wishstr = HttpContext.Request.Cookies["Wish"];

            WishVM wish;

            if (string.IsNullOrEmpty(wishstr))
            {
                wish = new WishVM();
                wish.WishCookieItemVMs = new List<WishCookieItemVM>();

                WishCookieItemVM cookiItem = new WishCookieItemVM()
                {
                    Id = dress.Id,
                    Quantity = 1
                };
                wish.WishCookieItemVMs.Add(cookiItem);
                wish.TotalPrice = dress.Price;
            }
            else
            {
                wish = JsonConvert.DeserializeObject<WishVM>(wishstr);

                WishCookieItemVM existed = wish.WishCookieItemVMs.FirstOrDefault(b => b.Id == id);

                if (existed == null)
                {
                    WishCookieItemVM cookiItem = new WishCookieItemVM()
                    {
                        Id = dress.Id,
                        Quantity = 1
                    };
                    wish.WishCookieItemVMs.Add(cookiItem);
                    wish.TotalPrice += dress.Price;
                }
                else
                {
                    wish.WishCookieItemVMs.Remove(existed);
                    wish.TotalPrice -= dress.Price;
                }
            }

            wishstr = JsonConvert.SerializeObject(wish);
            HttpContext.Response.Cookies.Append("Wish", wishstr);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult RemoveWish(int? id)
        {
            WishVM wish = JsonConvert.DeserializeObject<WishVM>(HttpContext.Request.Cookies["Wish"]);
            if (wish != null)
            {
                List<WishCookieItemVM> removable = new List<WishCookieItemVM>();

                foreach (WishCookieItemVM item in wish.WishCookieItemVMs)
                {
                    if (item.Id == id)
                    {
                        wish.TotalPrice = 0;
                        removable.Add(item);
                    }
                }
                wish.WishCookieItemVMs.RemoveAll(b => removable.Any(r => r.Id == b.Id));
            }
            string wishstr = JsonConvert.SerializeObject(wish);
            HttpContext.Response.Cookies.Append("Basket", wishstr);

            return RedirectToAction("WishList", "Home");
        }
        public IActionResult ShowWishList()
        {
            if (HttpContext.Request.Cookies["Wish"] == null) return NotFound();

            WishVM wish = JsonConvert.DeserializeObject<WishVM>(HttpContext.Request.Cookies["Wish"]);

            return Content(HttpContext.Request.Cookies["Wish"]);
        }
    }
}
