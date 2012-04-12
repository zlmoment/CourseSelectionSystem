using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class NewsModel
    {
        private int nid;
        private string title;
        private string pubtime;
        private string content;

        public NewsModel(int nid, string title, string pubtime, string content)
        {
            this.nid = nid;
            this.title = title;
            this.pubtime = pubtime;
            this.content = content;
        }

        public NewsModel()
        {

        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }


        public string Pubtime
        {
            get { return pubtime; }
            set { pubtime = value; }
        }
        

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        

        public int Nid
        {
            get { return nid; }
            set { nid = value; }
        }
        
    }
}
