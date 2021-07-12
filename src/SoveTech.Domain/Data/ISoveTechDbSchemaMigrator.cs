using System.Threading.Tasks;

namespace SoveTech.Data
{
    public interface ISoveTechDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
