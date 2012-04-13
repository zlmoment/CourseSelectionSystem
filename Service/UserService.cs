using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using MySql.Data.MySqlClient;

namespace Service
{
    public class UserService
    {
        public UserService()
        {

        }
        public int insert(string username, string password, int type)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into `tb_user` (username,password,type) values (@username,@password,@type)",conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                //返回主键值uid
                cmd = new MySqlCommand("select * from `tb_user` where `username`=@username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                int uid = 0;
                if (reader.Read())
                {
                    uid = int.Parse(reader["uid"].ToString());
                }
                conn.Close();
                return uid;
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }

        public int CheckPasswd(string username, string password)
        {
            UserModel userModel = new UserModel();
            try
            {
                MySqlConnection conn = GetConn.getConn();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from `tb_user` where `username`=@username and `password`=@password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                int type;
                if (reader.Read())
                {
                    userModel.Type = (int)reader["type"];
                    type = userModel.Type;
                    conn.Close();
                    return type;
                }
                else
                {
                    conn.Close();
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int getUidByUsername(string username)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select * from `tb_user` where `username`=@username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                int uid = 0;
                if (reader.Read())
                {
                    uid = int.Parse(reader["uid"].ToString());
                }
                conn.Close();
                return uid;
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
        public bool UpdatePasswd(string username, string password)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update tb_user set password=@password where username=@username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
