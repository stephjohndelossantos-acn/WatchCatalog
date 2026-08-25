using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WatchCatalog.Models;

namespace WatchCatalog.Controllers
{
    public class OmegaController : Controller
    {
        public IActionResult omega_homepage()
        {
            return View();
        }
        public IActionResult Speedmaster()
        {
            return View();
        }
        public IActionResult Seamaster()
        {
            return View();
        }
        public IActionResult Constellation()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
