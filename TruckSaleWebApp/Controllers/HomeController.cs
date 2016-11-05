using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TruckSaleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult Pricing()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }
    }
}
