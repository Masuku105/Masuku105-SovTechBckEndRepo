using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SoveTech.EntityFrameworkCore
{
    [DependsOn(
        typeof(SoveTechEntityFrameworkCoreModule)
        )]
    public class SoveTechEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SoveTechMigrationsDbContext>();
        }
    }
}
