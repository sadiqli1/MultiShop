using System;
using System.Collections.Generic;
using System.IO;
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
    public class SliderController:Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Sliders.ToListAsync();
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if(!ModelState.IsValid)return View();

            if (slider.Photo is null)
            {
                ModelState.AddModelError("Photo", "You have to choose 1 image at least");
                return View();
            }

            if (!slider.Photo.ImageisOkay(2))
            {
                ModelState.AddModelError("Photo", "Please chosse correct image");
                return View();
            }

            Slider existed = await _context.Sliders.FirstOrDefaultAsync(s => s.Order == slider.Order);

            if(existed != null)
            {
                ModelState.AddModelError("Order", "The same order cannot be entered");
                return View();
            }

            slider.Image = await slider.Photo.CreateFile(_env.WebRootPath, "assets/img/slider");

            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null || id == 0) return NotFound();

            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();

            return View(slider);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            if (id is null || id == 0) return NotFound();

            Slider existed = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);

            if (!ModelState.IsValid) return View(existed);

            if (slider.Photo == null)
            {
                string filename = existed.Image;
                _context.Entry(existed).CurrentValues.SetValues(slider);
                existed.Image = filename;
            }
            else
            {
                if (!slider.Photo.ImageisOkay(2))
                {
                    ModelState.AddModelError("Photo", "Please chosse correct image");
                    return View(existed);
                }
                FileValidator.DeleteFile(_env.WebRootPath, "admin/images/slider", existed.Image);
                _context.Entry(existed).CurrentValues.SetValues(slider);
                existed.Image = await slider.Photo.CreateFile(_env.WebRootPath, "assets/img/slider");
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Slider existed = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (existed == null) return NotFound();

            FileValidator.DeleteFile(_env.WebRootPath, "assets/img/slider", existed.Image);

            _context.Sliders.Remove(existed);
            _context.SaveChanges();
            return Json(new { status = 200 });
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id is null || id == 0) return NotFound();
            Slider existed = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (existed == null) return NotFound();
            return View(existed);
        }
    }
}