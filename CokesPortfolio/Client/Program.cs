using Blazor.Analytics;
using Blazored.LocalStorage;
using CokesPortfolio.Client.Utilities;
using CokesPortfolio.Client.Utilities.PageProjects;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

namespace CokesPortfolio.Client
{
    partial class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<ThemeManager>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ProjectViewModel>();

            builder.Services.AddMudServices();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddGoogleAnalytics("G-SS7LV9P7KE");

            builder.Logging.SetMinimumLevel(builder.HostEnvironment.IsDevelopment() ? LogLevel.Debug : LogLevel.None);

            await builder.Build().RunAsync();
        }
    }
}
