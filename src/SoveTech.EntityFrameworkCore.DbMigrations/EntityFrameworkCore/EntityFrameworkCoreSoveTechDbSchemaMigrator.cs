using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoveTech.Data;
using Volo.Abp.DependencyInjection;

namespace SoveTech.EntityFrameworkCore
{
    public class EntityFrameworkCoreSoveTechDbSchemaMigrator
        : ISoveTechDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSoveTechDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the SoveTechMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<SoveTechMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}