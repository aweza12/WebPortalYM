using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Entities.Enums;

namespace WebPortalYM.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public ICollection<Product> Products { get; set; }

        public string Comment { get; set; }
    }
}
