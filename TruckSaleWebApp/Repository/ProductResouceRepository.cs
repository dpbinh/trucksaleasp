using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Repository
{
    public class ProductResouceRepository : IProductResourceRepository
    {
        public ProductResource Add(ProductResource resource)
        {
            using(var db = new TruckSaleDb())
            {
                db.ProductResources.Add(resource);
                db.SaveChanges();
            }
            return resource;
        }

 
        public IList<ProductResource> GetByProduct(long productId)
        {
            IList<ProductResource> result = new List<ProductResource>();

            using (var db = new TruckSaleDb())
            {
                result = db.ProductResources.Where(r => r.productId == productId).ToList();
            }

            return result;
        }

        public ProductResource Remove(long id)
        {
            ProductResource result = null;
            using (var db = new TruckSaleDb())
            {
                var product = db.ProductResources.Single(r => r.Id == id);
                result = db.ProductResources.Remove(product);
            }

            return result;
        }
    }
}