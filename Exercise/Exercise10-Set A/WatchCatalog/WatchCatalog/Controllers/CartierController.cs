using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WatchCatalog.Models;

namespace WatchCatalog.Controllers
{
    public class CartierController : Controller
    {
        public IActionResult cartier_homepage()
        {
            return View();
        }
        public IActionResult Tank()
        {
            return View();
        }
        public IActionResult Santos()
        {
            return View();
        }
        public IActionResult dress_homepage()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
