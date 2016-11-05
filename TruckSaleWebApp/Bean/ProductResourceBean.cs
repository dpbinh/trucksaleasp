using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Bean
{
    public class ProductResourceBean
    {
        public long Id { get; set; }

        public string ResourcePath { get; set; }

        public string ResourceType { get; set; }

        public long productId { get; set; }

        public ProductResourceBean()
        {

        }

        public ProductResourceBean(ProductResource resource)
        {
            this.Id = resource.Id;
            this.ResourcePath = resource.ResourcePath;
            this.ResourceType = resource.ResourceType;
        }
    }
}