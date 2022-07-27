using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;
using MultiShop.Utilites;

namespace MultiShop.Areas.MultiShopAdmin.Controllers
{
    [Area("MultiShopAdmin")]
    public class DressController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public DressController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Dress> dresses = _context.Dresses
                .Include(d => d.Category)
                .Include(d=>d.Images)
                .Include(d => d.DressInformation)
                .ToList();
            return View(dresses);
        }
        public IActionResult Create()
        {
            ViewBag.Information = _context.DressInformations.ToList();
            ViewBag.Category = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Dress dress)
        {
            ViewBag.Information = _context.DressInformations.ToList();
            ViewBag.Category = _context.Categories.ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (dress.MainPhoto == null || dress.Photos == null)
            {
                ModelState.AddModelError(string.Empty, "You must choose 1 main image and 1 another image");
                return View();
            }
            if (!dress.MainPhoto.ImageisOkay(2))
            {
                ModelState.AddModelError("MainPhoto", "Please chosse correct photo");
                return View();
            }
            dress.Images = new List<Image>();
            foreach (IFormFile item in dress.Photos)
            {
                if (!item.ImageisOkay(2))
                {
                    ModelState.AddModelError("Photos", "Please chosse correct photo");
                    return View();
                }
                Image another = new Image()
                {
                    Name = await item.CreateFile(_env.WebRootPath, "assets/img"),
                    Alternative = item.Name,
                    isMain = false,
                    Dress = dress
                };
                dress.Images.Add(another);
            }
            Image main = new Image()
            {
                Name = await dress.MainPhoto.CreateFile(_env.WebRootPath, "assets/img"),
                Alternative = dress.MainPhoto.Name,
                isMain = true,
                Dress = dress
            };
            dress.Images.Add(main);
            await _context.AddAsync(dress);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if(id == null || id ==0) return NotFound();
            Dress existed = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).FirstOrDefaultAsync(d => d.Id == id);
            if(existed == null) return NotFound();
            ViewBag.Information = _context.DressInformations.ToList();
            ViewBag.Category = _context.Categories.ToList();
            return View(existed);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int? id, Dress dress)
        {
            if(id is null || id == 0) return NotFound();
            Dress existed = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).FirstOrDefaultAsync(d => d.Id == id);

            ViewBag.Information = _context.DressInformations.ToList();
            ViewBag.Category = _context.Categories.ToList();

            if (!ModelState.IsValid) return View(existed);

            if(dress.MainPhoto == null)
            {
                dress.Images.FirstOrDefault(i => i.isMain == true).Name = existed.Images.FirstOrDefault(i => i.isMain == true).Name;
            }
            else
            {
                if (!dress.MainPhoto.ImageisOkay(2))
                {
                    ModelState.AddModelError("MainPhoto", "Please chosse correct image");
                    return View(existed);
                }
                FileValidator.DeleteFile(_env.WebRootPath, "assets/img", existed.Images.FirstOrDefault(i => i.isMain == true).Name);
                dress.Images = new List<Image>();
                Image main = new Image()
                {
                    Name = await dress.MainPhoto.CreateFile(_env.WebRootPath, "assets/img"),
                    Alternative = dress.Name,
                    isMain = true,
                    Dress = existed
                };
                _context.Entry(existed).CurrentValues.SetValues(dress);
                existed.Images.FirstOrDefault(i => i.isMain == true).Name = main.Name;
                existed.Images.FirstOrDefault(i => i.isMain == true).Alternative = main.Alternative;

                existed.Images.Add(main);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
