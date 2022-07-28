using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;

namespace MultiShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            List<Dress> model = new List<Dress>();
            if (id == 1)
            {
                model = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Name).ToListAsync();
            }
            else if (id == 2)
            {
                model = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderByDescending(x => x.Name).ToListAsync();
            }
            else if (id == 3)
            {
                model = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Price).ToListAsync();
            }
            else
            {
                model = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).ToListAsync();
            }

            return View(model);
        }
    }
}
