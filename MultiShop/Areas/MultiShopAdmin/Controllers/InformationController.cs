using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;

namespace MultiShop.Areas.MultiShopAdmin.Controllers
{
    [Area("MultiShopAdmin")]
    public class InformationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public InformationController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<DressInformation> info = await _context.DressInformations.ToListAsync();
            return View(info);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(DressInformation information)
        {
            if(!ModelState.IsValid) return View();
            await _context.AddAsync(information);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null || id == 0) return NotFound();
            DressInformation existed = await _context.DressInformations.FirstOrDefaultAsync(d => d.Id == id);
            if (existed == null) return NotFound();
            return View(existed);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int? id, DressInformation information)
        {
            if(id is null || id == 0) return NotFound();

            DressInformation existed = await _context.DressInformations.FirstOrDefaultAsync(d => d.Id == id);
            if(existed == null) return NotFound();
            if (!ModelState.IsValid) return View(existed);

            _context.Entry(existed).CurrentValues.SetValues(information);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id == 0) return NotFound();
            DressInformation existed = await _context.DressInformations.FirstOrDefaultAsync(d => d.Id == id);
            if (existed == null) return NotFound();
            _context.Remove(existed);
            _context.SaveChanges();
            return Json(new { status = 200 });
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null || id == 0) return NotFound();
            DressInformation existed = await _context.DressInformations.FirstOrDefaultAsync(s => s.Id == id);
            if (existed == null) return NotFound();
            return View(existed);
        }
    }
}
