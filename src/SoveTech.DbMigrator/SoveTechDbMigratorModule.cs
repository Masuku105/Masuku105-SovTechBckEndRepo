using SoveTech.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SoveTech.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SoveTechEntityFrameworkCoreDbMigrationsModule),
        typeof(SoveTechApplicationContractsModule)
        )]
    public class SoveTechDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
