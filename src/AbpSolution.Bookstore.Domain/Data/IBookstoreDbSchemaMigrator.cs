using System.Threading.Tasks;

namespace AbpSolution.Bookstore.Data;

public interface IBookstoreDbSchemaMigrator
{
    Task MigrateAsync();
}
