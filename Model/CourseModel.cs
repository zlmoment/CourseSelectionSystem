using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class CourseModel
    {
        private int cid;
        private string cname;
        private int credit;
        private int week;
        private int section;
        private int tid;
        private int pid;
        private int precourse;

        public CourseModel(int cid, string cname, int credit, int week, int section, int tid, int pid, int precourse)
        {
            this.cid = cid;
            this.cname = cname;
            this.credit = credit;
            this.week = week;
            this.section = section;
            this.tid = tid;
            this.pid = pid;
            this.precourse = precourse;
        }

        public CourseModel()
        {

        }

        public int Precourse
        {
            get { return precourse; }
            set { precourse = value; }
        }
        

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        

        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }
        

        public int Section
        {
            get { return section; }
            set { section = value; }
        }
        

        public int Week
        {
            get { return week; }
            set { week = value; }
        }
        

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        

        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }
        
    }
}
