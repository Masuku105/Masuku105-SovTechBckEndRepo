using SoveTech.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SoveTech
{
    [DependsOn(
        typeof(SoveTechEntityFrameworkCoreTestModule)
        )]
    public class SoveTechDomainTestModule : AbpModule
    {

    }
}