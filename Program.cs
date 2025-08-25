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
builder.Services.AddHttpClient("Api", client =>
{
#if DEBUG
    client.BaseAddress = new Uri("https://localhost:7047/");
#else
client.BaseAddress = new Uri("https://itassetmanagementapi20250702124646.azurewebsites.net/");
#endif
});
builder.Services.AddScoped<AssetMasterService>();

// services
builder.Services.AddScoped<UserService>();

builder.Services.AddScoped<ChallansService>();
builder.Services.AddScoped<OpeningEntryService>();


await builder.Build().RunAsync();