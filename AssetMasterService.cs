using System.Net.Http.Json;
using IT_Asset_ManagementClient.Models;


namespace IT_Asset_ManagementClient;


public class AssetMasterService
{
    private readonly IHttpClientFactory _http;
    private HttpClient Api => _http.CreateClient("Api");


    public AssetMasterService(IHttpClientFactory http) => _http = http;


    public async Task<List<AssetMaster>> GetAssetsAsync(CancellationToken ct = default)
    => await Api.GetFromJsonAsync<List<AssetMaster>>("api/AssetMaster", ct) ?? new();


    public Task<AssetMaster?> GetAssetAsync(int id, CancellationToken ct = default)
    => Api.GetFromJsonAsync<AssetMaster>($"api/AssetMaster/{id}", ct);


    public async Task<AssetMaster?> CreateAssetAsync(AssetMasterCreateDto dto, CancellationToken ct = default)
    {
        var resp = await Api.PostAsJsonAsync("api/AssetMaster", dto, ct);
        resp.EnsureSuccessStatusCode();
        return await resp.Content.ReadFromJsonAsync<AssetMaster>(cancellationToken: ct);
    }


    public async Task<bool> DeleteAssetAsync(int id, CancellationToken ct = default)
    {
        var resp = await Api.DeleteAsync($"api/AssetMaster/{id}", ct);
        return resp.IsSuccessStatusCode;
    }
}