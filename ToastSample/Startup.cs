using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

//3rd party
using Blazored.Toast;

namespace ToastSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazoredToast();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
