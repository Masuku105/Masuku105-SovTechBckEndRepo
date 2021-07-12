using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SoveTech.Web
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddApplication<SoveTechWebModule>();

        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
