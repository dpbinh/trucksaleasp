using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Models
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Vcode { get; set; }
        public Nullable<long> RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}