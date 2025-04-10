using AbpSolution.Bookstore.Items;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpSolution.Bookstore.Books
{
    public class ItemAppService : CrudAppService<
        Item, 
        ItemDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        CreateUpdateItemDto>,
    IItemAppService
    {
        public ItemAppService(IRepository<Item, Guid> repository)
            : base(repository)
        {

        }
    }
}
