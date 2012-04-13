using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service;
using Model;

namespace Business
{
    public class UserBusiness
    {
        public int getUidByUsername(string username)
        {
            UserService userService = new UserService();
            return userService.getUidByUsername(username);
        }

        public int CheckPasswd(string username, string password)
        {
            UserService userService = new UserService();
            int type;
            type = userService.CheckPasswd(username, password);
            return type;
        }
        public bool changePasswd(string username, string password)
        {
            UserService userService = new UserService();
            return userService.UpdatePasswd(username, password);
        }
    }
}
