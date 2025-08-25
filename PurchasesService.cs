namespace IT_Asset_ManagementClient
{
    using IT_Asset_ManagementClient.Models;
    using System.Net.Http.Json;

    public class PurchasesService
    {
        private readonly HttpClient _http;

        public PurchasesService(HttpClient http) => _http = http;

        public async Task<List<Purchase>> GetPurchasesAsync()
            => await _http.GetFromJsonAsync<List<Purchase>>("api/Purchases");

        public async Task<Purchase?> GetPurchaseAsync(int id)
            => await _http.GetFromJsonAsync<Purchase>($"api/Purchases/{id}");

        public async Task<Purchase?> CreatePurchaseAsync(PurchasesCreateDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/Purchases", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Purchase>();
        }

        public async Task<bool> DeletePurchaseAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/Purchases/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
