using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Xunit;

namespace AbpSolution.Bookstore.SaleItems
{
    //public class SaleItemAppService_Tests<TStartupModule> : BookstoreApplicationTestBase<TStartupModule>
    //    where TStartupModule : IAbpModule
    //{

    //    private readonly ISaleItemAppService _saleItemAppService;

    //    protected SaleItemAppService_Tests()
    //    {
    //        _saleItemAppService = GetRequiredService<ISaleItemAppService>();
    //    }

    //    [Fact]
    //    public async Task Should_Get_List_Of_SaleItems()
    //    {
    //        //Act
    //        var result = await _saleItemAppService.GetListAsync(
    //            new PagedAndSortedResultRequestDto()
    //        );

    //        //Assert
    //        result.TotalCount.ShouldBeGreaterThan(0);
    //        //result.Items.ShouldContain(b => b.Name == "1984");
    //    }
    //}
}
