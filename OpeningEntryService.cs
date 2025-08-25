namespace IT_Asset_ManagementClient
{
    using global::IT_Asset_ManagementClient.Models;
    
    using System.Net.Http.Json;

    public class OpeningEntryService
    {
        private readonly HttpClient _http;

        public OpeningEntryService(HttpClient http) => _http = http;

        public async Task<List<OpeningEntry>> GetOpeningsAsync()
            => await _http.GetFromJsonAsync<List<OpeningEntry>>("api/OpeningEntry");

        public async Task<OpeningEntry?> GetOpeningAsync(int id)
            => await _http.GetFromJsonAsync<OpeningEntry>($"api/OpeningEntry/{id}");

        public async Task<OpeningEntry?> CreateOpeningAsync(OpeningEntryCreateDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/OpeningEntry", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<OpeningEntry>();
        }

        public async Task<bool> DeleteOpeningAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/OpeningEntry/{id}");
            return response.IsSuccessStatusCode;
        }
    }

}
