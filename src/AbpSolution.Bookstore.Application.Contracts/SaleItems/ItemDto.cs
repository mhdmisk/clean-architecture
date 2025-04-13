using System;
using Volo.Abp.Application.Dtos;

namespace AbpSolution.Bookstore.SaleItems
{
    public class SaleItemDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public SaleItemType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
