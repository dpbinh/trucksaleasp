using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using TruckSaleWebApp.Utils;

namespace TruckSaleWebApp.Service
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class ApiUserAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
            actionContext.Response.ReasonPhrase = "Not Permission to access resource";
        }

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            if (HttpContext.Current.Session[Contents.LOGIN_KEY] != null)
            {
                return true;
            }
            return false;
        }
    }
}