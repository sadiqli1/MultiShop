using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Areas.MultiShopAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("MultiShopAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
