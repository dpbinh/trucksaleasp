using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TruckSaleWebApp.Utils
{
    public static class Utilities
    {
        public static string IsActive(this HtmlHelper html, string control, string action)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            var returnActive = control.ToUpper() == routeControl.ToUpper() &&
                               action.ToUpper() == routeAction.ToUpper();

            return returnActive ? "active" : "";
        }
    }
}