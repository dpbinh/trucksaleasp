using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TruckSaleWebApp.Bean;
using TruckSaleWebApp.Service;

namespace TruckSaleWebApp.Areas.Admin.Controllers
{
    [RoutePrefix("api/adminresource")]
    public class AdminResourceController : ApiController
    {
        private IProductService _productService;
        public AdminResourceController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("resource/{id}/{type}")]
        [HttpPost]
        public ActionResult Post(long id, string type)
        {
            var request = HttpContext.Current.Request;
            if (request.Files.Count <= 0)
            {
                return new ActionResult()
                {
                    Message = "No file selected"
                };
            }
            return new ActionResult(() => { return _productService.UpdateResource(id, type, request.Files[0]); });
        }

        public ActionResult Delete(long id)
        {
            return new ActionResult(() => {   _productService.RemoveResource(id); return null; });
        }
    }
}