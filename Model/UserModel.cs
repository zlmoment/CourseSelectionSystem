using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class UserModel
    {

        private int uid;
        private string username;
        private string password;
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        public UserModel(int uid, string username, string password, int type)
        {
            this.uid = uid;
            this.username = username;
            this.password = password;
            this.type = type;
        }

        public UserModel()
        {

        }
        
    }
}
