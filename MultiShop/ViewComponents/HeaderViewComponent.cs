using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;
using MultiShop.ViewModels;

namespace MultiShop.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public HeaderViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            LayoutVM model = new LayoutVM()
            {
                Settings = await _context.Settings.ToListAsync(),
                Categories = await _context.Categories.ToListAsync()
            };
            return View(model);
        }
    }
}
