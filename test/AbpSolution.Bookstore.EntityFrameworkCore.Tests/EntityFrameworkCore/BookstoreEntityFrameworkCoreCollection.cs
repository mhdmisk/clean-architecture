using Xunit;

namespace AbpSolution.Bookstore.EntityFrameworkCore;

[CollectionDefinition(BookstoreTestConsts.CollectionDefinitionName)]
public class BookstoreEntityFrameworkCoreCollection : ICollectionFixture<BookstoreEntityFrameworkCoreFixture>
{

}
