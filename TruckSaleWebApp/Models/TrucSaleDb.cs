using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Models
{
    public class TruckSaleDb : DbContext
    {
        public TruckSaleDb() : base("name=trucksaleconnstr")
        {
        }
 

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductGroup> Productgroups { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ProductResource> ProductResources { get; set; }
    }
}