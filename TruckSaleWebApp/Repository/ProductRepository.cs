using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> GetAllProducts()
        {
            IList<Product> result = new List<Product>();
            using (var db = new TruckSaleDb())
            {

                result = db.Products.Include("ProductGroup").ToList();
            }

            return result;
        }

        public Product GetProduct(long id)
        {
            Product result = null;
            using(var db = new TruckSaleDb())
            {
                result = db.Products.Include("ProductGroup").Single(p => p.Id == id);
            }

            return result;

        }

        public void Save(Product product)
        {
            using (var db = new TruckSaleDb())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using(var db = new TruckSaleDb())
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}