using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace Service
{
    public class PlaceService
    {

        public PlaceModel getPlacebyPid(int pid)
        {
            MySqlConnection conn = GetConn.getConn();
            PlaceModel pModel = new PlaceModel();
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from `tb_place` where `pid`=@pid", conn);
                cmd.Parameters.AddWithValue("@pid", pid);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pModel.Pid = int.Parse(reader["pid"].ToString());
                    pModel.Pname = (string)reader["pname"];
                    pModel.Parentpid = int.Parse(reader["parentpid"].ToString());
                }
                conn.Close();
                return pModel;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
    }
}
