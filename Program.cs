using IT_Asset_ManagementClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://itassetmanagementapi20250702124646.azurewebsites.net/")
});
builder.Services.AddScoped<AssetMasterService>();
builder.Services.AddScoped<ChallansService>();
builder.Services.AddScoped<OpeningEntryService>();

await builder.Build().RunAsync();
