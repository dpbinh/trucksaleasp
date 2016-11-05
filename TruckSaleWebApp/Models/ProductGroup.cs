using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Models
{
    public class ProductGroup
    {
        public ProductGroup()
        {
            this.Products = new HashSet<Product>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}