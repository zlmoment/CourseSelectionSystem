using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service;

namespace Business
{
    public class UserLoginBusiness
    {
        public int CheckPasswd(string username, string password)
        {
            UserService user = new UserService();
            int type;
            type = user.CheckPasswd(username, password);
            return type;
        }
    }
}
