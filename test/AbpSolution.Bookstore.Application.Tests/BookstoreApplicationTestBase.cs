using Volo.Abp.Modularity;

namespace AbpSolution.Bookstore;

public abstract class BookstoreApplicationTestBase<TStartupModule> : BookstoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
