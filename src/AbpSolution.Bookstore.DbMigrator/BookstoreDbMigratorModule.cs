using AbpSolution.Bookstore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpSolution.Bookstore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookstoreEntityFrameworkCoreModule),
    typeof(BookstoreApplicationContractsModule)
)]
public class BookstoreDbMigratorModule : AbpModule
{
}
