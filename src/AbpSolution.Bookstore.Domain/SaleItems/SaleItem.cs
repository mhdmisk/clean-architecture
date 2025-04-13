using AbpSolution.Bookstore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSolution.Bookstore.SaleItems
{
    public class SaleItem : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public SaleItemType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
