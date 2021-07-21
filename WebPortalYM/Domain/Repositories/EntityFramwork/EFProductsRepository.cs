using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalYM.Domain.Entities;
using WebPortalYM.Domain.Repositories.Abstract;

namespace WebPortalYM.Domain.Repositories.EntityFramwork
{
    public class EFProductsRepository : IProductsRepository
    {
        private readonly AppDbContext context;

        public EFProductsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> Products()
        {
            return context.Products;
        }

        public Product GetProductById(int id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Product> GetProductsByOrderId(int id)
        {
            return (IQueryable<Product>)context.Orders.Include(x => x.Products).FirstOrDefault(x => x.Id == id).Products;
        }

        public void SaveProduct(Product entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            context.Products.Remove(new Product() { Id = id });
            context.SaveChanges();
        }
    }
}
