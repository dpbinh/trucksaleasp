using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TruckSaleWebApp.Bean;
using TruckSaleWebApp.Service;
using TruckSaleWebApp.Utils;

namespace TruckSaleWebApp.Areas.Admin.Controllers
{
    [RoutePrefix("api/adminuser")]
    public class AdminUserController : ApiController
    {
        

        private IUserService _userService;
        public AdminUserController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("login/")]
        [HttpPost]
        public ActionResult PostLogin([FromBody] UserBean userbean)
        {
            return new ActionResult(() =>
            {
                UserBean user = _userService.Login(userbean);
                if(user == null)
                {
                    throw new Exception("Login failed check user name and password");
                }

                var session = HttpContext.Current.Session;
                session[Contents.LOGIN_KEY] = user.UserName;

                return user;
            });    
        }

        [ApiUserAuthorize]
        [Route("changepassword")]
        [HttpPost]
        public ActionResult ChangePassword([FromBody] UserBean userbean)
        {
            return new ActionResult(() =>
            {
                string username =  HttpContext.Current.Session[Contents.LOGIN_KEY].ToString();
                userbean.UserName = username;
                _userService.ChangePassword(userbean);
                return null;
            });
        } 
    }
}
