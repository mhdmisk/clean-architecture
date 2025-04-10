using Volo.Abp.Modularity;

namespace AbpSolution.Bookstore;

[DependsOn(
    typeof(BookstoreApplicationModule),
    typeof(BookstoreDomainTestModule)
)]
public class BookstoreApplicationTestModule : AbpModule
{

}
