using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class CollegeModel
    {
        private int cid;
        private string cname;

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }

        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }

        public CollegeModel(int cid, string cname)
        {
            this.cid = cid;
            this.cname = cname;
        }

        public CollegeModel()
        {

        }
        
    }
}
