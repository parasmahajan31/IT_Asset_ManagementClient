namespace IT_Asset_ManagementClient
{
    using IT_Asset_ManagementClient.Models;
    using System.Net.Http.Json;

    public class PurchasesService
    {
        private readonly HttpClient _http;

        public PurchasesService(HttpClient http) => _http = http;

        public async Task<List<Purchases>> GetPurchasesAsync()
            => await _http.GetFromJsonAsync<List<Purchases>>("api/Purchases");

        public async Task<Purchases?> GetPurchaseAsync(int id)
            => await _http.GetFromJsonAsync<Purchases>($"api/Purchases/{id}");

        public async Task<Purchases?> CreatePurchaseAsync(PurchasesCreateDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/Purchases", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Purchases>();
        }

        public async Task<bool> DeletePurchaseAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/Purchases/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
