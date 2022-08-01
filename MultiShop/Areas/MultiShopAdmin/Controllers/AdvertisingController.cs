using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;
using MultiShop.Utilites;

namespace MultiShop.Areas.MultiShopAdmin.Controllers
{
    [Area("MultiShopAdmin")]
    public class AdvertisingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AdvertisingController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Advertising> advertisings = _context.Advertisings.ToList();
            return View(advertisings);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Advertising advertising)
        {
            if (!ModelState.IsValid) return View();

            if(advertising.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please chosse image");
                return View();
            }
            if (!advertising.Photo.ImageisOkay(2))
            {
                ModelState.AddModelError("Photo", "Please chosse the correct image");
                return View();
            }
            advertising.Image = await advertising.Photo.CreateFile(_env.WebRootPath, "assets/img");
            await _context.Advertisings.AddAsync(advertising);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Advertising existed = _context.Advertisings.FirstOrDefault(a => a.Id == id);
            if(existed == null) return NotFound();

            return View(existed);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int? id, Advertising advertising)
        {
            if (id == null || id == 0) return NotFound();

            Advertising existed = await _context.Advertisings.FirstOrDefaultAsync(a => a.Id == id);
            if (existed == null) return NotFound();

            if(!ModelState.IsValid) return View(existed);

            if(advertising.Photo == null)
            {
                string filename = existed.Image;
                _context.Entry(existed).CurrentValues.SetValues(advertising);
                existed.Image = filename;
            }
            else
            {
                if (!advertising.Photo.ImageisOkay(2))
                {
                    ModelState.AddModelError("Photo", "Please chosse correct image");
                    return View(existed);
                }
                FileValidator.DeleteFile(_env.WebRootPath, "assets/img", existed.Image);
                _context.Entry(existed).CurrentValues.SetValues(advertising);
                existed.Image = await advertising.Photo.CreateFile(_env.WebRootPath, "assets/img");
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id == 0) return NotFound();
            Advertising existed = await _context.Advertisings.FirstOrDefaultAsync(a => a.Id == id);
            if (existed == null) return NotFound();

            FileValidator.DeleteFile(_env.WebRootPath, "assets/img", existed.Image);

            _context.Advertisings.Remove(existed);
            await _context.SaveChangesAsync();

            return Json(new { status = 200 });
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null || id == 0) return NotFound();
            Advertising existed = await _context.Advertisings.FirstOrDefaultAsync(a => a.Id == id);
            if (existed == null) return NotFound();
            return View(existed);
        }
    }
}
