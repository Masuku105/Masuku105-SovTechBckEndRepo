using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SoveTech.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SoveTechMigrationsDbContextFactory : IDesignTimeDbContextFactory<SoveTechMigrationsDbContext>
    {
        public SoveTechMigrationsDbContext CreateDbContext(string[] args)
        {
            SoveTechEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SoveTechMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SoveTechMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SoveTech.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
