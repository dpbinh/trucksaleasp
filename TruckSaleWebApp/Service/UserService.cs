using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Bean;
using TruckSaleWebApp.Models;
using TruckSaleWebApp.Repository;
using TruckSaleWebApp.Utils;

namespace TruckSaleWebApp.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public void ChangePassword(UserBean userbean)
        {
            try
            {
                User user = _userRepo.GetUserByUserName(userbean.UserName);
                if (user == null)
                {
                    throw new Exception("User Name not exist");
                }

                string decode = PasswordHelper.EncodePassword(userbean.OldPassword, user.Vcode);
                if (decode != user.Password)
                {
                    throw new Exception("Old Password not match");
                }

                string vcode = PasswordHelper.GeneratePassword(PasswordHelper.DEFAULT_PASSWORD_LENGTH);
                string newPass = PasswordHelper.EncodePassword(userbean.Password, vcode);
                user.Password = newPass;
                user.Vcode = vcode;
                _userRepo.Update(user);

            } catch(Exception e)
            {
                throw new Exception("Change password has failed: " + e.Message);
            }
        }

        public UserBean Login(UserBean userbean)
        {
            UserBean result = null;
            try 
            {
                User user = _userRepo.GetUserByUserName(userbean.UserName);
                if(user == null)
                {
                    throw new Exception("User Name not exist");
                }

                string decode = PasswordHelper.EncodePassword(userbean.Password, user.Vcode);
                if(decode != user.Password)
                {
                    throw new Exception("Password not match");
                }

                result = new UserBean()
                {
                    Id = user.Id,
                    UserName = user.UserName
                };
            } catch(Exception e)
            {
                throw new Exception("Login fail: " + e.Message);
            }

            return result;
        }

    }
}