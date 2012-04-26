using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PlaceModel
    {
        private int pid;
        private string pname;

        public PlaceModel(int pid, string pname)
        {
            this.pid = pid;
            this.pname = pname;
        }

        public PlaceModel()
        {

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
