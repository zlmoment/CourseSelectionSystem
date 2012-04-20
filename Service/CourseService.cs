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
                MySqlCommand cmd = new MySqlCommand("insert into `tb_course` (cname,credit,week,section,tid,pid,precourse) values (@cname,@credit,@week,@section,@tid,@pid,@precourse)", conn);
                cmd.Parameters.AddWithValue("@cname", courseModel.Cname);
                cmd.Parameters.AddWithValue("@credit", courseModel.Credit);
                cmd.Parameters.AddWithValue("@week", courseModel.Week);
                cmd.Parameters.AddWithValue("@section", courseModel.Section);
                cmd.Parameters.AddWithValue("@tid", courseModel.Tid);
                cmd.Parameters.AddWithValue("@pid", courseModel.Pid);
                cmd.Parameters.AddWithValue("@precourse", courseModel.Precourse);
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
                        int.Parse(dr["precourse"].ToString())));
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
