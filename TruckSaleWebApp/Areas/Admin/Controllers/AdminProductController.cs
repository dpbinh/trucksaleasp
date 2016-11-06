using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TruckSaleWebApp.Bean;
using TruckSaleWebApp.Service;

namespace TruckSaleWebApp.Areas.Admin.Controllers
{
    [RoutePrefix("api/adminproduct")]
    public class AdminProductController : ApiController
    {
        private IProductService _productService;

        public AdminProductController(IProductService productService)
        {
            _productService = productService;
        }

        [ApiUserAuthorize]
        public ActionResult Post([FromBody] ProductShortInfoBean productbean)
        {
            return new ActionResult(() => { _productService.AddNewProduct(productbean); return null; });
        }

        [ApiUserAuthorize]
        public ActionResult Put([FromBody] ProductShortInfoBean productBean)
        {
            return new ActionResult(() => {   _productService.UpdateProduct(productBean); return null; });
        }

        [ApiUserAuthorize]
        [Route("specification")]
        [HttpPut]
        public ActionResult Put([FromBody] ProductBean productbean)
        {
            return new ActionResult(() => { _productService.UpdateSpecification(productbean); return null; });
        }

        [ApiUserAuthorize]
        [Route("avatar/{id}")]
        [HttpPost]
        public ActionResult UpdateProductAvatar(long id)
        {
            var request = HttpContext.Current.Request;
            if (request.Files.Count <= 0)
            {
                return new ActionResult()
                {
                    Message = "No file selected"
                };
            }
            return new ActionResult(() => { return _productService.UpdateProductAvatar(id, request.Files[0]); });
        }

        [ApiUserAuthorize]
        [Route("manufacture/{id}/{manufactureId}")]
        [HttpPut]
        public ActionResult UpdateManufacture(long id, long manufactureId)
        {
            return new ActionResult(() => { _productService.UpdateManufacture(id, manufactureId); return null; });
        }

        [ApiUserAuthorize]
        public ActionResult Delete(long id)
        {
            return new ActionResult(() => { _productService.DeleteProduct(id); return null; });
        }
    }
}
