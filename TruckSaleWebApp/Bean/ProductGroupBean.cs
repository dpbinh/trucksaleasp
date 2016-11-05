using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Bean
{
    public class ProductGroupBean
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Img { get; set; }

        public ProductGroupBean()
        {

        }

        public ProductGroupBean(ProductGroup productg)
        {
            this.Id = productg.Id;
            this.Name = productg.Name;
            this.Img = productg.Img;
        }
    }
}