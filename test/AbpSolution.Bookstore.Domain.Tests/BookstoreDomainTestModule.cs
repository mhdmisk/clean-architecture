using Volo.Abp.Modularity;

namespace AbpSolution.Bookstore;

[DependsOn(
    typeof(BookstoreDomainModule),
    typeof(BookstoreTestBaseModule)
)]
public class BookstoreDomainTestModule : AbpModule
{

}
