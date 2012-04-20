using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using MySql.Data.MySqlClient;

namespace Service
{
    public class CourseService
    {
        public CourseService()
        {

        }

        public int insert(CourseModel courseModel)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into `tb_course` (cname,credit,week,section,tid,pid,precourse,maxstu) values (@cname,@credit,@week,@section,@tid,@pid,@precourse,@maxstu)", conn);
                cmd.Parameters.AddWithValue("@cname", courseModel.Cname);
                cmd.Parameters.AddWithValue("@credit", courseModel.Credit);
                cmd.Parameters.AddWithValue("@week", courseModel.Week);
                cmd.Parameters.AddWithValue("@section", courseModel.Section);
                cmd.Parameters.AddWithValue("@tid", courseModel.Tid);
                cmd.Parameters.AddWithValue("@pid", courseModel.Pid);
                cmd.Parameters.AddWithValue("@precourse", courseModel.Precourse);
                cmd.Parameters.AddWithValue("@maxstu", courseModel.Maxstu);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return 1;
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
        public DataTable getAllCourse()
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from `tb_course` order by cid desc", conn);
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
        public DataTable getAllCourseByTid(int tid)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from `tb_course` where `tid`=@tid", conn);
                cmd.Parameters.AddWithValue("@tid", tid);
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
        public int delete(int cid)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from `tb_course` where `cid`=@cid", conn);
                cmd.Parameters.AddWithValue("@cid", cid);
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
        public int update(CourseModel couModel)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update `tb_course` set `cname`=@cname, `credit`=@credit, `week`=@week, `section`=@section, `tid`=@tid, `pid`=@pid, `precourse`=@precourse, `maxstu`=@maxstu where `cid`=@cid", conn);
                cmd.Parameters.AddWithValue("@cname", couModel.Cname);
                cmd.Parameters.AddWithValue("@credit", couModel.Credit);
                cmd.Parameters.AddWithValue("@week", couModel.Week);
                cmd.Parameters.AddWithValue("@section", couModel.Section);
                cmd.Parameters.AddWithValue("@tid", couModel.Tid);
                cmd.Parameters.AddWithValue("@pid", couModel.Pid);
                cmd.Parameters.AddWithValue("@precourse", couModel.Precourse);
                cmd.Parameters.AddWithValue("@maxstu", couModel.Maxstu);
                cmd.Parameters.AddWithValue("@cid", couModel.Cid);
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
        public List<CourseModel> getAllCourseBySid(int sid,int semester)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from `tb_course` where cid in (select cid from `tb_sc` where `sid`=@sid and `semester`=@semester)", conn);
                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@semester", semester);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                int legth = dt.Rows.Count;
                DataRow[] dataRows = new DataRow[legth];
                dt.Rows.CopyTo(dataRows, 0);
                List<CourseModel> courseModelList = new List<CourseModel>();
                foreach (DataRow dr in dataRows)
                {
                    courseModelList.Add(new CourseModel(int.Parse(dr["cid"].ToString()),
                        dr["cname"].ToString(),
                        int.Parse(dr["credit"].ToString()),
                        int.Parse(dr["week"].ToString()),
                        int.Parse(dr["section"].ToString()),
                        int.Parse(dr["tid"].ToString()),
                        int.Parse(dr["pid"].ToString()),
                        int.Parse(dr["precourse"].ToString()),
                        int.Parse(dr["maxstu"].ToString())));
                }
                conn.Close();
                return courseModelList;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
    }
}
