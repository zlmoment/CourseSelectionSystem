using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Service
{
    
    class GetConn
    {
        public static MySqlConnection getConn()
        {
            //String connectionString = "server=173.230.157.91;user id=zhaoyulee; password=beagoodman110; database=dotnet; pooling=false;charset=utf8";
            String connectionString = "server=127.0.0.1;user id=root; password=; database=dotnet; pooling=false;charset=utf8";
            MySqlConnection conn = null;
            conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
