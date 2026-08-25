using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WatchCatalog.Data;
using WatchCatalog.Models;

namespace WatchCatalog.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Purchases.OrderByDescending(x => x.PurchaseDate).ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchases.FirstOrDefaultAsync(m => m.Id == id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        public IActionResult Create(string? watchName = null, string? brand = null)
        {
            var model = new Purchase
            {
                WatchName = watchName ?? string.Empty,
                Brand = brand ?? string.Empty,
                Price = 0,
                Quantity = 1,
                PurchaseDate = DateTime.Today
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WatchName,Brand,PurchaseDate")] Purchase purchase)
        {
            purchase.Price = 0;
            purchase.Quantity = 1;

            if (!ModelState.IsValid)
            {
                return View(purchase);
            }

            _context.Add(purchase);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchases.FindAsync(id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WatchName,Brand,PurchaseDate")] Purchase purchase)
        {
            if (id != purchase.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(purchase);
            }

            try
            {
                var purchaseToUpdate = await _context.Purchases.FirstOrDefaultAsync(p => p.Id == id);
                if (purchaseToUpdate == null)
                {
                    return NotFound();
                }

                purchaseToUpdate.WatchName = purchase.WatchName;
                purchaseToUpdate.Brand = purchase.Brand;
                purchaseToUpdate.PurchaseDate = purchase.PurchaseDate;
                purchaseToUpdate.Price = 0;
                purchaseToUpdate.Quantity = 1;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseExists(purchase.Id))
                {
                    return NotFound();
                }

                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchases.FirstOrDefaultAsync(m => m.Id == id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchase = await _context.Purchases.FindAsync(id);
            if (purchase != null)
            {
                _context.Purchases.Remove(purchase);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseExists(int id)
        {
            return _context.Purchases.Any(e => e.Id == id);
        }

    }
}
