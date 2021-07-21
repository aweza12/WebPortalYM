using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Entities;

namespace WebPortalYM.Domain.Repositories.Abstract
{
    public interface IOrdersRepository
    {
        IQueryable<Order> GetOrders();
        Order GetOrderById(int id);
        IQueryable<Order> GetOrdersByCustomerId(int id);
        void SaveOrder(Order entity);
        void DeleteOrder(int id);
    }
}
