using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TruckSaleWebApp.Areas.Admin.Controllers
{

    public class AdminHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Product(long id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }
    }
}