using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalYM.Domain.Entities.Enums
{
    public enum OrderStatus
    {
        New, 
        Paid, 
        Shipped, 
        Delivered, 
        Closed
    }
}
