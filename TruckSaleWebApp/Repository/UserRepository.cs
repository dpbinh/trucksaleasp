using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Repository
{
    public class UserRepository : IUserRepository
    {
        public User Get(long id)
        {
            User user = null;
            using(var db = new TruckSaleDb())
            {
                var list = db.Users.Where(u => u.Id == id).ToList();
                if(list.Count > 0)
                {
                    user = list[0];
                }
            }
            return user;
        }

        public User GetUserByUserName(string userName)
        {
            User user = null;
            using (var db = new TruckSaleDb())
            {
                var list = db.Users.Where(u => u.UserName == userName).ToList();
                if (list.Count > 0)
                {
                    user = list[0];
                }
            }
            return user;
        }

        public void Update(User user)
        {
            using (var db = new TruckSaleDb())
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}