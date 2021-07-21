using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Entities;

namespace WebPortalYM.Domain.Repositories.Abstract
{
    public interface ICustomersRepository
    {
        IQueryable<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        Customer GetCustomerByOrderId(int id);
        void SaveCustomer(Customer entity);
        void DeleteCustomer(int id);
    }
}
