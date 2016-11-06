using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TruckSaleWebApp.Utils;

namespace TruckSaleWebApp.Service
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class UserAuthorize : AuthorizeAttribute
    {
        public RoleType Role { get; set; }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                         new RouteValueDictionary(new { controller = "AdminHome", action = "Login" })
            );
        }


        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session[Contents.LOGIN_KEY] != null)
            {
                return true;
            }
            return false;
        }
    }
}