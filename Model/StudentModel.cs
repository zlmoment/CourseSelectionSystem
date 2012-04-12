using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class StudentModel
    {
        private int sid;
        private int uid;
        private string stunum;
        private string sname;
        private int gender;
        private string startyear;
        private int collegeid;

        public StudentModel(int sid, int uid, string stunum, string sname, int gender, string startyear, int collegeid)
        {
            this.sid = sid;
            this.uid = uid;
            this.stunum = stunum;
            this.sname = sname;
            this.gender = gender;
            this.startyear = startyear;
            this.collegeid = collegeid;
        }

        public StudentModel()
        {

        }

        public int Collegeid
        {
            get { return collegeid; }
            set { collegeid = value; }
        }
        

        public string Startyear
        {
            get { return startyear; }
            set { startyear = value; }
        }
        

        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        

        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }
        

        public string Stunum
        {
            get { return stunum; }
            set { stunum = value; }
        }
        

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        
    }
}
