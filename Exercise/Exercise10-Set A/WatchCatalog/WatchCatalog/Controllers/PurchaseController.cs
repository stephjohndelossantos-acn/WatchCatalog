using Microsoft.AspNetCore.Mvc;
using WatchCatalog.Models;
using WatchCatalog.Services;

namespace WatchCatalog.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly PurchaseApiClient _purchaseApiClient;

        public PurchaseController(PurchaseApiClient purchaseApiClient)
        {
            _purchaseApiClient = purchaseApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var purchases = await _purchaseApiClient.GetPurchasesAsync();
            return View(purchases.OrderByDescending(x => x.PurchaseDate).ToList());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _purchaseApiClient.GetPurchaseAsync(id.Value);
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

            var created = await _purchaseApiClient.CreatePurchaseAsync(purchase);
            if (!created)
            {
                ModelState.AddModelError(string.Empty, "Unable to create purchase through API.");
                return View(purchase);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _purchaseApiClient.GetPurchaseAsync(id.Value);
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

            purchase.Price = 0;
            purchase.Quantity = 1;

            var updated = await _purchaseApiClient.UpdatePurchaseAsync(purchase);
            if (!updated)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _purchaseApiClient.GetPurchaseAsync(id.Value);
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
            await _purchaseApiClient.DeletePurchaseAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
