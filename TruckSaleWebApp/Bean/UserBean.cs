﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Bean
{
    public class UserBean
    {
        public long Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string OldPassword { get; set; }
    }
}