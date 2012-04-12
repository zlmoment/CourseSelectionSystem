using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class PlaceModel
    {
        private int pid;
        private string pname;
        private int parentpid;

        public PlaceModel(int pid, string pname, int parentpid)
        {
            this.pid = pid;
            this.pname = pname;
            this.parentpid = parentpid;
        }

        public PlaceModel()
        {

        }

        public int Parentpid
        {
            get { return parentpid; }
            set { parentpid = value; }
        }
        

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        
    }
}
