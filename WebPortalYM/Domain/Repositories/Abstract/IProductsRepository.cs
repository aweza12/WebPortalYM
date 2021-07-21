using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Entities;

namespace WebPortalYM.Domain.Repositories.Abstract
{
    public interface IProductsRepository
    {
        IQueryable<Product> Products();
        Product GetProductById(int id);
        IQueryable<Product> GetProductsByOrderId(int id);
        void SaveProduct(Product entity);
        void DeleteProduct(int id);
    }
}
