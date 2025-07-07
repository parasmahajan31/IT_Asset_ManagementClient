namespace IT_Asset_ManagementClient
{
    using IT_Asset_ManagementClient.Models;
    using System.Net.Http.Json;

    public class ChallansService
    {
        private readonly HttpClient _http;

        public ChallansService(HttpClient http) => _http = http;

        public async Task<List<Challans>> GetChallansAsync()
            => await _http.GetFromJsonAsync<List<Challans>>("api/Challans");

        public async Task<Challans?> GetChallanAsync(int id)
            => await _http.GetFromJsonAsync<Challans>($"api/Challans/{id}");

        public async Task<Challans?> CreateChallanAsync(ChallansCreateDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/Challans", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Challans>();
        }

        public async Task<bool> DeleteChallanAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/Challans/{id}");
            return response.IsSuccessStatusCode;
        }
    }

}
