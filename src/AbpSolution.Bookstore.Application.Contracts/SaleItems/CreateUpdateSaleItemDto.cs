
using System.ComponentModel.DataAnnotations;
using System;

namespace AbpSolution.Bookstore.SaleItems
{
    public class CreateUpdateSaleItemDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public SaleItemType Type { get; set; } = SaleItemType.New;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }
    }
}
