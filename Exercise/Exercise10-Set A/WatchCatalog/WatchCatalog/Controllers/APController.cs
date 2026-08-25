using Microsoft.AspNetCore.Mvc;

namespace WatchCatalog.Controllers
{
    public class APController : Controller
    {
        public IActionResult ap_homepage()
        {
            return View();
        }
        public IActionResult RoyalOak()
        {
            return View();
        }
        public IActionResult Offshore()
        {
            return View();
        }
    }
}
