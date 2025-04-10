
using AbpSolution.Bookstore.Items;
using System.ComponentModel.DataAnnotations;
using System;

namespace AbpSolution.Bookstore.Items
{
    public class CreateUpdateItemDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public ItemType Type { get; set; } = ItemType.New;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }
    }
}
