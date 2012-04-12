using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Service
{
    public class NewsService
    {
        public NewsService()
        {
        }

        public int insert(NewsModel newsModel)
        {
            string title = newsModel.Title;
            string pubtime = newsModel.Pubtime;
            string content = newsModel.Content;

            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into `tb_news` (title,pubtime,content) values (@title,@pubtime,@content)", conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@pubtime", pubtime);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                //返回主键值nid
                cmd = new MySqlCommand("select * from `tb_news` where `title`=@title", conn);
                cmd.Parameters.AddWithValue("@title", title);
                MySqlDataReader reader = cmd.ExecuteReader();
                int nid = 0;
                if (reader.Read())
                {
                    nid = int.Parse(reader["nid"].ToString());
                }
                conn.Close();
                return nid;
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
        public bool update(NewsModel newsModel)
        {
            string title = newsModel.Title;
            string pubtime = newsModel.Pubtime;
            string content = newsModel.Content;
            int nid = newsModel.Nid;

            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update `tb_news` set title=@title,pubtime=@pubtime,content=@content where nid=@nid", conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@pubtime", pubtime);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@nid", nid);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                conn.Close();
                return false ;
            }
        }
        public bool delete(int[] toBeDeleted)
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                MySqlCommand cmd;

                int totalCount = toBeDeleted.Length;
                int i = 0;
                for (; i < totalCount; i++)
                {
                    if (toBeDeleted[i] != 0)
                    {
                        cmd = new MySqlCommand("delete from `tb_news` where `nid`=@nid", conn);
                        cmd.Parameters.AddWithValue("@nid", toBeDeleted[i]);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                }
                
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public NewsModel[] getAllNews()
        {
            MySqlConnection conn = GetConn.getConn();
            try
            {
                conn.Open();
                NewsModel[] newsModelList;
                //int totalCount;
                //MySqlCommand cmd = new MySqlCommand("select count(*) from `tb_news`", conn);
                //totalCount = (int)cmd.ExecuteScalar();
                //newsModelList = new NewsModel[totalCount];
                //cmd.Dispose();
                MySqlCommand cmd = new MySqlCommand("select * from `tb_news` order by nid desc", conn);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //DataSet myDataSet = new DataSet();
                da.Fill(dt);
                int totalCount ;
                totalCount = dt.Rows.Count;
                newsModelList = new NewsModel[totalCount];
                int i = 0;
                for (; i < totalCount; i++)
                {
                    newsModelList[i] = new NewsModel();
                }
                i = 0;
                foreach (DataRow myRow in dt.Rows)
                {
                    newsModelList[i].Nid = int.Parse(myRow["nid"].ToString());
                    newsModelList[i].Title = myRow["title"].ToString();
                    newsModelList[i].Content = myRow["content"].ToString();
                    newsModelList[i].Pubtime = myRow["pubtime"].ToString();
                    i++;
                }
                //MySqlDataReader reader = cmd.ExecuteReader();
                //int i = 0;
                ////if (reader.Read())
                //{
                //    newsModelList[i].Nid = reader.GetInt32("nid");
                //    newsModelList[i].Title = reader.GetString("title");
                //    newsModelList[i].Content = reader.GetString("content");
                //    newsModelList[i].Pubtime = reader.GetString("pubtime");
                //    i++;
                //}
                conn.Close();
                return newsModelList;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
    }
}
