using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Repository
{
    public interface IUserRepository
    {
        User GetUserByUserName(string userName);
        User Get(long id);
        void Update(User user);
    }
}
