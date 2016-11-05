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
    public class ResourceController : ApiController
    {
        private IProductService _productService;
        public ResourceController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Get(long id)
        {
            return new ActionResult(() => { return _productService.GetAllResourceByProduct(id); });
        }
    }
}
