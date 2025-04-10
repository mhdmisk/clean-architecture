using System;
using Volo.Abp.Application.Dtos;

namespace AbpSolution.Bookstore.Items
{
    public class ItemDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public ItemType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
