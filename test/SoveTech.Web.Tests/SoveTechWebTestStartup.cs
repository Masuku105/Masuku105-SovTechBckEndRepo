using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace SoveTech
{
    public class SoveTechWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<SoveTechWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}