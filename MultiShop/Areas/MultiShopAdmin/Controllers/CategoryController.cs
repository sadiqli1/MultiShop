using System.Collections.Generic;
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
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            if(category.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please chosse image");
                return View(category);
            }
            if (!category.Photo.ImageisOkay(2))
            {
                ModelState.AddModelError("Photo", "Please chosse correct image");
                return View(category);
            }
            category.Image = await category.Photo.CreateFile(_env.WebRootPath, "assets/img/category");
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Category existed = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if(existed == null) return NotFound();
            return View(existed);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            if (id == null || id == 0) return NotFound();

            Category existed = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);

            if (existed == null) return NotFound();

            if (!ModelState.IsValid) return View(existed);

            if(category.Photo == null)
            {
                string filename = existed.Image;
                _context.Entry(existed).CurrentValues.SetValues(category);
                existed.Image = filename;
            }
            else
            {
                if (!category.Photo.ImageisOkay(2))
                {
                    ModelState.AddModelError("Photo", "Please chosse correct image");
                    return View(existed);
                }
                FileValidator.DeleteFile(_env.WebRootPath, "assets/img/category", existed.Image);
                _context.Entry(existed).CurrentValues.SetValues(category);
                existed.Image = await category.Photo.CreateFile(_env.WebRootPath, "assets/img/category");
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id is null || id == 0) return NotFound();
            Category existed = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (existed == null) return NotFound();

            FileValidator.DeleteFile(_env.WebRootPath, "assets/img/category", existed.Image);

            _context.Categories.Remove(existed);
            await _context.SaveChangesAsync();

            return Json(new {status = 200});
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null || id == 0) return NotFound();
            Category existed = await _context.Categories.FirstOrDefaultAsync(s => s.Id == id);
            if (existed == null) return NotFound();
            return View(existed);
        }
    }
}
