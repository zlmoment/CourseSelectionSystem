using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using MySql.Data.MySqlClient;

namespace Service
{
    public class StudentService
    {
        public int insert(int uid, string stunum, string sname, int gender, string startyear, int collegeid)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into `tb_student` (uid,stunum,sname,gender,startyear,collegeid) values (@uid,@stunum,@sname,@gender,@startyear,@collegeid)",conn);
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@stunum", stunum);
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@startyear", startyear);
                cmd.Parameters.AddWithValue("@collegeid", collegeid);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                //返回主键值
                cmd = new MySqlCommand("select * from `tb_student` where `uid`=@uid", conn);
                cmd.Parameters.AddWithValue("@uid", uid);
                MySqlDataReader reader = cmd.ExecuteReader();
                int sid = 0;
                if (reader.Read())
                {
                    sid = int.Parse(reader["sid"].ToString());
                }
                conn.Close();
                return sid;
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
    }
}
