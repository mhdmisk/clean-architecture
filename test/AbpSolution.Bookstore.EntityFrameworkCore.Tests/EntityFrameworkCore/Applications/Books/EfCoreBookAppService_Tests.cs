using AbpSolution.Bookstore.Books;
using Xunit;

namespace AbpSolution.Bookstore.EntityFrameworkCore.Applications.Books;

[Collection(BookstoreTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BookstoreEntityFrameworkCoreTestModule>
{

}