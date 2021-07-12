using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace SoveTech.EntityFrameworkCore
{
    public static class SoveTechDbContextModelCreatingExtensions
    {
        public static void ConfigureSoveTech(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SoveTechConsts.DbTablePrefix + "YourEntities", SoveTechConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}