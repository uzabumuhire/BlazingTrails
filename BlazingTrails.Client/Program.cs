using BlazingTrails.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

// Create an instance of a WebAssemblyHostBuilder
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Defines the root components for the application
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configure and register services with IServiceCollection
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Build and run an instance of WebAssemblyHost using the 
// configuration defined with the WebAssemblyHostBuilder
await builder.Build().RunAsync();
