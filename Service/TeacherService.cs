using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Model;
using System.Data;

namespace Service
{
    public class TeacherService
    {
        public int insert(TeacherModel teacherModel)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into `tb_teacher` (uid,tname,gender,birthday,phone) values (@uid,@tname,@gender,@birthday,@phone)", conn);
                cmd.Parameters.AddWithValue("@uid", teacherModel.Uid);
                cmd.Parameters.AddWithValue("@tname", teacherModel.Tname);
                cmd.Parameters.AddWithValue("@gender", teacherModel.Gender);
                cmd.Parameters.AddWithValue("@birthday", teacherModel.Birthday);
                cmd.Parameters.AddWithValue("@phone", teacherModel.Phone);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                //返回主键值tid
                return this.getTidByUid(teacherModel.Uid);
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
        public DataTable getAllTeacher()
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from `tb_teacher` order by tid desc", conn);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        public int getTidByUid(int uid)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select * from `tb_teacher` where `uid`=@uid", conn);
                cmd.Parameters.AddWithValue("@uid", uid);
                MySqlDataReader reader = cmd.ExecuteReader();
                int tid = 0;
                if (reader.Read())
                {
                    tid = int.Parse(reader["tid"].ToString());
                }
                conn.Close();
                return tid;
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
    }
}
