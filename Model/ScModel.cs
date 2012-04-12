using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class ScModel
    {
        private int id;
        private int sid;
        private int cid;

        public ScModel(int id, int sid, int cid)
        {
            this.id = id;
            this.sid = sid;
            this.cid = cid;
        }

        public ScModel()
        {

        }

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }
        

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
    }
}
