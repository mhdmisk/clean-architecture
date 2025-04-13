using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpSolution.Bookstore.SaleItems
{
    public class SaleItemAppService : CrudAppService<
        SaleItem,
        SaleItemDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        CreateUpdateSaleItemDto>,
    ISaleItemAppService
    {
        public SaleItemAppService(IRepository<SaleItem, Guid> repository)
            : base(repository)
        {

        }
    }
}
