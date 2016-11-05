﻿using System.Web.Mvc;

namespace TruckSaleWebApp.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name : "Admin_default",
                url: "Admin/{controller}/{action}/{id}",
                defaults : new {controller = "AdminHome", action = "Index", id = UrlParameter.Optional }
           
            );
        }
    }
}