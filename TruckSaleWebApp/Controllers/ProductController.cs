using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TruckSaleWebApp.Bean;
using TruckSaleWebApp.Service;

namespace TruckSaleWebApp.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Get()
        {
            return new ActionResult(() => { return _productService.GetAllProducts(); });
        }

        public ActionResult Get(long id)
        {
            return new ActionResult(() => { return _productService.GetProduct(id); });
        }

        [Route("manufacture/{id}")]
        public ActionResult GetByManufacture(long id)
        {
            return new ActionResult(() => { return _productService.GetProductByManufacture(id); });
        }

        [Route("pricing")]
        public ActionResult GetPricing()
        {
            return new ActionResult(() => { return _productService.GetPricing(); });
        }
    }
}
