using AbpSolution.Bookstore.Samples;
using Xunit;

namespace AbpSolution.Bookstore.EntityFrameworkCore.Applications;

[Collection(BookstoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookstoreEntityFrameworkCoreTestModule>
{

}
