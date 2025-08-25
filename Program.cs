using IT_Asset_ManagementClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection; // <-- Add this


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


// default client for same-origin
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// named API client
// Program.cs (Blazor WASM)
builder.Services.AddHttpClient("Api", client =>
{
    client.BaseAddress = new Uri("https://itassetmanagementapi20250702124646.azurewebsites.net/");
});

builder.Services.AddScoped<AssetMasterService>();
builder.Services.AddScoped<PurchasesService>();
// services
builder.Services.AddScoped<UserService>();

builder.Services.AddScoped<ChallansService>();
builder.Services.AddScoped<OpeningEntryService>();


await builder.Build().RunAsync();