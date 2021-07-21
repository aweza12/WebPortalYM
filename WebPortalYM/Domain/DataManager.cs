using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Repositories.Abstract;

namespace WebPortalYM.Domain
{
    public class DataManager
    {
        public IProductsRepository Products { get; set; }

        public ICustomersRepository Customers { get; set; }
        
        public IOrdersRepository Orders { get; set; }

        public DataManager(IProductsRepository productsRepository, ICustomersRepository customersRepository, IOrdersRepository ordersRepository)
        {
            Products = productsRepository;
            Customers = customersRepository;
            Orders = ordersRepository;
        }
    }
}
