using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;

namespace MultiShop.Controllers
{
	public class OrderController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly UserManager<AppUser> _userManager;

		public OrderController(ApplicationDbContext context, UserManager<AppUser> userManager)
		{
			_context = context;
			_userManager = userManager;
		}
		public async Task<IActionResult> Checkout()
		{
            if (User.Identity.IsAuthenticated)
            {
				AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

				List<BasketItem> items = await _context.BasketItems.Include(b => b.Dress).Include(b => b.AppUser).Where(b => b.AppUserId == user.Id).ToListAsync();
				ViewBag.Items = items;
				return View();
			}
            else
            {
				return RedirectToAction("register", "account");
            }
		}
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult> Checkout(Order order)
		{
			if (!ModelState.IsValid) return View();

			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

			List<BasketItem> items = await _context.BasketItems.Include(b => b.Dress).Include(b => b.AppUser).Where(b => b.AppUserId == user.Id).ToListAsync();

			order.BasketItems = items;
			order.Date = DateTime.Now;
			order.AppUser = user; 
			order.Status = null;
			order.TotalPrice = default;

			foreach (BasketItem item in items)
			{
				order.TotalPrice += item.Price * item.Quantity;
			}
			await _context.AddAsync(order);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index", "Home");
		}
	}
}
