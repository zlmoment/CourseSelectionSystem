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
        public DataTable getAllTeacherOnlyTidTname()
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select `tid`,`tname` from `tb_teacher` order by tid desc", conn);
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
        public int update(TeacherModel teaModel)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update `tb_teacher` set `tname`=@tname, `gender`=@gender, `birthday`=@birthday, `phone`=@phone where `tid`=@tid", conn);
                cmd.Parameters.AddWithValue("@tname", teaModel.Tname);
                cmd.Parameters.AddWithValue("@gender", teaModel.Gender);
                cmd.Parameters.AddWithValue("@birthday", teaModel.Birthday);
                cmd.Parameters.AddWithValue("@phone", teaModel.Phone);
                cmd.Parameters.AddWithValue("@tid", teaModel.Tid);
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
        public int delete(int tid)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from `tb_teacher` where `tid`=@tid", conn);
                cmd.Parameters.AddWithValue("@tid", tid);
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

        public TeacherModel getTeacherByTid(int tid)
        {
            MySqlConnection conn = GetConn.getConn();
            TeacherModel teacherModel = new TeacherModel();
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from `tb_teacher` where `tid`=@tid", conn);
                cmd.Parameters.AddWithValue("@tid", tid);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    teacherModel.Tid = int.Parse(reader["tid"].ToString());
                    teacherModel.Uid = int.Parse(reader["uid"].ToString());
                    teacherModel.Tname = reader["tname"].ToString();
                    teacherModel.Gender = int.Parse(reader["gender"].ToString());
                    teacherModel.Birthday = reader["birthday"].ToString();
                    teacherModel.Phone = reader["phone"].ToString();
                }
                conn.Close();
                return teacherModel;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }

        public string getTnameByTid(int tid)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                cmd = new MySqlCommand("select tname from `tb_teacher` where `tid`=@tid", conn);
                cmd.Parameters.AddWithValue("@tid", tid);
                MySqlDataReader reader = cmd.ExecuteReader();
                String tname = "";
                if (reader.Read())
                {
                    tname = (string)reader["tname"];
                }
                conn.Close();
                return tname;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
    }
}
