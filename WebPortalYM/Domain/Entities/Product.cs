using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Enums;

namespace WebPortalYM.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ProductSize ProductSize { get; set; }
        public int AvailableQuantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
