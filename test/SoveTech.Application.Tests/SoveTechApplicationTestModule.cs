using Volo.Abp.Modularity;

namespace SoveTech
{
    [DependsOn(
        typeof(SoveTechApplicationModule),
        typeof(SoveTechDomainTestModule)
        )]
    public class SoveTechApplicationTestModule : AbpModule
    {

    }
}