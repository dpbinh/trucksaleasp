using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Repository
{
    public class ProductGroupRepository : IProductGroupRepository
    {
        public IList<ProductGroup> FindAllProducts()
        {
            IList<ProductGroup> result = new List<ProductGroup>();
            using (TruckSaleDb db = new TruckSaleDb())
            {
                result = db.Productgroups.ToList();
            }
            return result;
        }

        public ProductGroup FindOne(long id)
        {
            ProductGroup group = null;
            using (TruckSaleDb db = new TruckSaleDb())
            {
                group = db.Productgroups.Single(p => p.Id == id);
            }

            return group;
        }
    }
}