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

        public ActionResult Post([FromBody] ProductShortInfoBean productbean)
        {
            ActionResult result = new ActionResult();
            result.Execute(() =>
            {
                 _productService.AddNewProduct(productbean);
                return null;
            });
            return result;
        }

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
    }
}
