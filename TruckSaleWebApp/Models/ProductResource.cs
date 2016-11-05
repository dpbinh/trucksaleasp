using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Models
{
    public class ProductResource
    {
        public long Id { get; set; }

        public string ResourcePath { get; set; }

        public string ResourceType { get; set; }

        public long productId { get; set; }
    }
}