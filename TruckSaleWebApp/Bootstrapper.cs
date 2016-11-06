using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TruckSaleWebApp.Repository;
using TruckSaleWebApp.Service;
using Unity.Mvc5;

namespace TruckSaleWebApp
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductGroupRepository, ProductGroupRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IProductResourceRepository, ProductResouceRepository>();
        }
    }
}