using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
