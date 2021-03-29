using System;
using System.Net.Http;
using System.Threading.Tasks;
using Confab.Web.Core;
using Confab.Web.UI.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;

namespace Confab.Web.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddCore();
            builder.Services.AddScoped<IApiResponseHandler, ApiResponseHandler>();
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri("http://localhost:5000")});
            builder.Services.AddMudServices();
            builder.Services.AddMudBlazorSnackbar(config =>
            {
                config.PositionClass = Defaults.Classes.Position.TopRight;
                config.PreventDuplicates = false;
                config.NewestOnTop = false;
                config.ShowCloseIcon = true;
                config.VisibleStateDuration = 5000;
                config.HideTransitionDuration = 200;
                config.ShowTransitionDuration = 200;
            });
            var host = builder.Build();
            var authenticationService = host.Services.GetRequiredService<IAuthenticationService>();
            await authenticationService.InitializeAsync();
            await host.RunAsync();
        }
    }
}
