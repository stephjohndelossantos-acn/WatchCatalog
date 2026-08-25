using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WatchCatalog.Models;

namespace WatchCatalog.Controllers
{
    public class RolexController : Controller
    {
        public IActionResult rolex_homepage()
        {
            return View();
        }
        public IActionResult Obsidian()
        {
            return View();
        }
        public IActionResult Daytona()
        {
            return View();
        }
        public IActionResult Submariner()
        {
            return View();
        }
        public IActionResult GMT()
        {
            return View();
        }
        public IActionResult chrono_homepage()
        {
            return View();
        }
        public IActionResult divers_homepage()
        {
            return View();
        }
        public IActionResult gmt_homepage()
        {
            return View();
        }
        public IActionResult Seiko()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
