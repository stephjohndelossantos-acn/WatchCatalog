using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using WatchCatalog.Models;

namespace WatchCatalog.Services
{
    public class PurchaseApiClient
    {
        private readonly HttpClient _httpClient;

        public PurchaseApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Purchase>> GetPurchasesAsync()
        {
            var response = await _httpClient.GetAsync("api/Purchase");
            if (!response.IsSuccessStatusCode)
            {
                return new List<Purchase>();
            }

            return await response.Content.ReadFromJsonAsync<List<Purchase>>() ?? new List<Purchase>();
        }

        public async Task<Purchase?> GetPurchaseAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/Purchase/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content.ReadFromJsonAsync<Purchase>();
        }

        public async Task<bool> CreatePurchaseAsync(Purchase purchase)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Purchase", purchase);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePurchaseAsync(Purchase purchase)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Purchase/{purchase.Id}", purchase);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePurchaseAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Purchase/{id}");
            return response.IsSuccessStatusCode || response.StatusCode == HttpStatusCode.NotFound;
        }
    }
}
