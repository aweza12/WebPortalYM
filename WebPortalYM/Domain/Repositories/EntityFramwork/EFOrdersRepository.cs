using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Entities;
using WebPortalYM.Domain.Repositories.Abstract;

namespace WebPortalYM.Domain.Repositories.EntityFramwork
{
    public class EFOrdersRepository : IOrdersRepository
    {
        private readonly AppDbContext context;
        public EFOrdersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Order> GetOrders()
        {
            return context.Orders;
        }

        public Order GetOrderById(int id)
        {
            return context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Order> GetOrdersByCustomerId(int id)
        {
            return context.Orders.Include(x => x.Customer).Where(x => x.Customer.Id == id);
        }

        public void SaveOrder(Order entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            context.Orders.Remove(new Order() { Id = id });
            context.SaveChanges();
        }
    }
}
