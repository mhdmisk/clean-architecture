using AbpSolution.Bookstore.Samples;
using Xunit;

namespace AbpSolution.Bookstore.EntityFrameworkCore.Domains;

[Collection(BookstoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookstoreEntityFrameworkCoreTestModule>
{

}
