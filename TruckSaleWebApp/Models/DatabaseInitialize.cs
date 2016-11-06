using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Utils;

namespace TruckSaleWebApp.Models
{
    public class DatabaseInitialize 
    {
        private static readonly string DEFAULT_USER_NAME = "admin";

        private static readonly string DEFAULT_PASSWORD = "trucksalebh";
        public static void Init()
        {
            using (var db = new TruckSaleDb())
            {
                var users = db.Users.Where(u => u.UserName == DEFAULT_USER_NAME).ToList();
                if(users.Count < 1)
                {
                    string vcode = PasswordHelper.GeneratePassword(PasswordHelper.DEFAULT_PASSWORD_LENGTH);
                    string encoded = PasswordHelper.EncodePassword(DEFAULT_PASSWORD, vcode);
                    var roles = db.Roles.Where(r => r.Name == RoleType.ADMIN.ToString()).ToList();
                    if(roles.Count > 0)
                    {
                        User user = new User()
                        {
                            UserName = DEFAULT_USER_NAME,
                            Password = encoded,
                            Vcode = vcode,
                            RoleId = roles[0].Id,
                            Role = roles[0]
                        };
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                    
                }

            }
        }
    }
}