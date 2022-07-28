using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;

namespace MultiShop.Controllers
{
    public class DressController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DressController(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null || id == 0) return NotFound();
            Dress existed = await _context.Dresses.Include(d => d.Images).Include(d => d.Category).Include(d => d.DressInformation).FirstOrDefaultAsync(d => d.Id == id);
            if(existed == null) return NotFound();
            return View(existed);
        }
    }
}
