using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TruckSaleWebApp.Bean;
using TruckSaleWebApp.Service;

namespace TruckSaleWebApp.Controllers
{
    public class ManufactureController : ApiController
    {
        private IProductService _productService;
 
        public ManufactureController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Get()
        {
            return new ActionResult(() => { return _productService.GetAllProductGroup(); });
        }

        public ActionResult Get(long id)
        {
            return new ActionResult(() => { return _productService.GetManufacture(id); });
        }

    }
}
