using IT_Asset_ManagementClient.Models;
using System.Net.Http.Json;
using System.Net.NetworkInformation;

namespace IT_Asset_ManagementClient
{


    public class AssetMasterService
    {
        private readonly HttpClient _http;

        public AssetMasterService(HttpClient http) => _http = http;

        public async Task<List<AssetMaster>> GetAssetsAsync()
            => await _http.GetFromJsonAsync<List<AssetMaster>>("api/AssetMaster");

        public async Task<AssetMaster?> GetAssetAsync(int id)
            => await _http.GetFromJsonAsync<AssetMaster>($"api/AssetMaster/{id}");

        public async Task<AssetMaster?> CreateAssetAsync(AssetMasterCreateDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/AssetMaster", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<AssetMaster>();
        }

        public async Task<bool> DeleteAssetAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/AssetMaster/{id}");
            return response.IsSuccessStatusCode;
        }
    }


}
