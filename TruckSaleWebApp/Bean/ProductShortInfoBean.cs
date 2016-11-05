using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Bean
{
    public class ProductShortInfoBean
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public long Groupid { get; set; }
        public string GroupName { get; set; }

        public string Img { get; set; }
        public ProductShortInfoBean()
        {

        }

        public ProductShortInfoBean(Product product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.Price = product.Price.Value;
            this.Img = product.Img;
            if(product.ProductGroup != null)
            {
                this.Groupid = product.ProductGroupId.Value;
                this.GroupName = product.ProductGroup.Name;
            }
           
        }
    }
}