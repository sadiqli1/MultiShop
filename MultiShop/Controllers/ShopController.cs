using System;
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
        public async Task<IActionResult> Index(int? sort, int? id, int page = 1)
        {
            List<Dress> sorts = new List<Dress>();
            if (sort!=null &&id==null)
            {
                switch (sort)
                {
                    case 1:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Name).Skip((page - 1) * 9).Take(9).ToListAsync();
                        break;
                    case 2:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderByDescending(x => x.Name).Skip((page - 1) * 9).Take(9).ToListAsync();
                        break;
                    case 3:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Price).Skip((page - 1) * 9).Take(9).ToListAsync();
                        break;
                    default:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).Skip((page - 1) * 9).Take(9).ToListAsync();
                        break;
                }

                ViewBag.CurentPage = page;

                ViewBag.TotalPage = Math.Ceiling((decimal)_context.Dresses.Count() / 9);

                return View(sorts);
            }

            if (id != null&&sort==null)
            {
                List<Dress> dress = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).Where(d => d.CategoryId == id).Skip((page - 1) * 9).Take(9).ToListAsync();

                ViewBag.CurentPage = page;

                ViewBag.TotalPage = Math.Ceiling((decimal)_context.Dresses.Count() / 9);

                return View(dress);
            }

            if (sort != null && id != null)
            {
                switch (sort)
                {
                    case 1:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Name).Where(d => d.CategoryId == id).Skip((page - 1) * 9).Take(9).ToListAsync();
                        break;
                    case 2:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderByDescending(x => x.Name).Where(d => d.CategoryId == id).Skip((page - 1) * 9).Take(9).ToListAsync();
                        break;
                    case 3:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).OrderBy(x => x.Price).Where(d => d.CategoryId == id).Skip((page - 1) * 9).Take(9).ToListAsync();
                        break;
                    default:
                        sorts = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).Where(d => d.CategoryId == id).Skip((page - 1) * 9).Take(9).ToListAsync();
                        break;
                }
                ViewBag.CurentPage = page;

                ViewBag.TotalPage = Math.Ceiling((decimal)_context.Dresses.Count() / 9);
                return View(sorts);
            }
            if(sort == null && id == null)
            {
                List<Dress> dress = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).Skip((page - 1) * 9).Take(9).ToListAsync();
                ViewBag.CurentPage = page;

                ViewBag.TotalPage = Math.Ceiling((decimal)_context.Dresses.Count() / 9);
                return View(dress);
            }

            return RedirectToAction("Index");
        }
    }
}
