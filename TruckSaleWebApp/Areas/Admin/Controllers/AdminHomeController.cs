using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TruckSaleWebApp.Service;
using TruckSaleWebApp.Utils;

namespace TruckSaleWebApp.Areas.Admin.Controllers
{

    public class AdminHomeController : Controller
    {
 
        public ActionResult Index()
        {
            return new RedirectToRouteResult(new RouteValueDictionary(new { controller = "AdminHome", action = "Products" }));
        }

        public ActionResult Login()
        {
            return View();
        }

        [UserAuthorize]
        public ActionResult Product(long id)
        {
            ViewBag.Id = id;
            return View();
        }

        [UserAuthorize]
        public ActionResult Products()
        {
            return View();
        }

        [UserAuthorize]
        public ActionResult Logout()
        {
            var session = Session[Contents.LOGIN_KEY] = null;
            return new RedirectToRouteResult(new RouteValueDictionary(new { controller = "AdminHome", action = "Login" }));
        }

        [UserAuthorize]
        public ActionResult ChangePassword()
        {
            return View();
        }
            
    }
}