using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;

namespace MultiShop.Areas.MultiShopAdmin.Controllers
{
    [Area("MultiShopAdmin")]
    public class DressController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DressController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Dress> dresses = _context.Dresses
                .Include(d => d.Category)
                .Include(d => d.DressInformation)
                .ToList();
            return View(dresses);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Information = _context.DressInformations.ToList();
            return View();
        }
    }
}
