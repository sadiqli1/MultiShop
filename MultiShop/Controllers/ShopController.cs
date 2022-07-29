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
        public async Task<IActionResult> Index(int? sort, int? id)
        {
            List<Dress> sorts = new List<Dress>();
            if (sort!=null &&id==null)
            {
                switch (sort)
                {
                    case 1:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Name).ToListAsync();
                        break;
                    case 2:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderByDescending(x => x.Name).ToListAsync();
                        break;
                    case 3:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Price).ToListAsync();
                        break;
                    default:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).ToListAsync();
                        break;
                }
                return View(sorts);
            }

            if (id != null&&sort==null)
            {
                List<Dress> dress = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).Where(d => d.CategoryId == id).ToListAsync();
                return View(dress);
            }

            if (sort != null && id != null)
            {
                switch (sort)
                {
                    case 1:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Name).Where(d => d.CategoryId == id).ToListAsync();
                        break;
                    case 2:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderByDescending(x => x.Name).Where(d => d.CategoryId == id).ToListAsync();
                        break;
                    case 3:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Price).Where(d => d.CategoryId == id).ToListAsync();
                        break;
                    default:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).Where(d => d.CategoryId == id).ToListAsync();
                        break;
                }
                return View(sorts);
            }
            if(sort == null && id == null)
            {
                List<Dress> dress = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).ToListAsync();
                return View(dress);
            }

            return RedirectToAction("Index");
        }
    }
}
