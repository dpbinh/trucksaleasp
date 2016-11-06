using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSaleWebApp.Bean;

namespace TruckSaleWebApp.Service
{
    public interface IUserService
    {
        UserBean Login(UserBean user);

        void ChangePassword(UserBean user);
    }
}
