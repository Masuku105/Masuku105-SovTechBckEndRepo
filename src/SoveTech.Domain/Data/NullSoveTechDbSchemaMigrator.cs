using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SoveTech.Data
{
    /* This is used if database provider does't define
     * ISoveTechDbSchemaMigrator implementation.
     */
    public class NullSoveTechDbSchemaMigrator : ISoveTechDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}