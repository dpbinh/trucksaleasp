using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace TruckSaleWebApp.Bean
{
    public class PricingBean
    {
        public string Manufacture { get; set; }

        public long ManufactureId { get; set; }

        private IList<ProductShortInfoBean> products = new List<ProductShortInfoBean>();

        public IList<ProductShortInfoBean> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }

    }
}