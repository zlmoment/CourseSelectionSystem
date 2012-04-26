using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace Service
{
    public class CollegeService
    {
        public CollegeService()
        {

        }
        public CollegeModel getCollegeNameByCid(int cid)
        {
            MySqlConnection conn = GetConn.getConn();
            CollegeModel collegeModel = new CollegeModel();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from `tb_college` where cid=@cid", conn);
                cmd.Parameters.AddWithValue("@cid", cid);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    collegeModel.Cid = int.Parse(reader["cid"].ToString());
                    collegeModel.Cname = reader["cname"].ToString();
                }
                conn.Close();
                return collegeModel;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        public DataTable getAllCollege()
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from `tb_college`", conn);
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
    }
}
