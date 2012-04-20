using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

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
        public DataTable getAllStudent()
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand("select * from `tb_student` order by sid", conn);
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
        public int update(StudentModel stuModel)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update `tb_student` set `stunum`=@stunum, `sname`=@sname, `gender`=@gender, `startyear`=@startyear, `collegeid`=@collegeid where `sid`=@sid", conn);
                cmd.Parameters.AddWithValue("@stunum", stuModel.Stunum);
                cmd.Parameters.AddWithValue("@sname", stuModel.Sname);
                cmd.Parameters.AddWithValue("@gender", stuModel.Gender);
                cmd.Parameters.AddWithValue("@startyear", stuModel.Startyear);
                cmd.Parameters.AddWithValue("@collegeid", stuModel.Collegeid);
                cmd.Parameters.AddWithValue("@sid", stuModel.Sid);
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
        public int delete(int sid)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from `tb_student` where `sid`=@sid", conn);
                cmd.Parameters.AddWithValue("@sid", sid);
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
        public StudentModel getStuBySid(int sid)
        {
            MySqlConnection conn = GetConn.getConn();
            StudentModel stuModel = new StudentModel();
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from `tb_student` where `sid`=@sid", conn);
                cmd.Parameters.AddWithValue("@sid", sid);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    stuModel.Sid = int.Parse(reader["sid"].ToString());
                    stuModel.Uid = int.Parse(reader["uid"].ToString());
                    stuModel.Sname = (string)reader["sname"];
                    stuModel.Stunum = (string)reader["stunum"];
                    stuModel.Startyear = (string)reader["startyear"];
                    stuModel.Collegeid = int.Parse(reader["collegeid"].ToString());
                }
                conn.Close();
                return stuModel;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
    }
}
