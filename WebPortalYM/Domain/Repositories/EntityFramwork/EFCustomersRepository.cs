using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Entities;
using WebPortalYM.Domain.Repositories.Abstract;

namespace WebPortalYM.Domain.Repositories.EntityFramwork
{
    public class EFCustomersRepository : ICustomersRepository
    {
        private readonly AppDbContext context;
        public EFCustomersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Customer> GetCustomers()
        {
            return context.Customers;
        }

        public Customer GetCustomerById(int id)
        {
            return context.Customers.FirstOrDefault(x => x.Id == id);
        }

        public Customer GetCustomerByOrderId(int id)
        {
            return context.Orders.Include(x => x.Customer).FirstOrDefault(x => x.Id == id).Customer;
        }

        public void SaveCustomer(Customer entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            context.Customers.Remove(new Customer() { Id = id });
            context.SaveChanges();
        }
    }
}
