using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpSolution.Bookstore.SaleItems
{
    public interface ISaleItemAppService :
    ICrudAppService<
        SaleItemDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateSaleItemDto> 
    {
    }
}
