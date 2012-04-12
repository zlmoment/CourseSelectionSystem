using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SystemModel
    {
        private int id;
        private string key;
        private string value;

        public SystemModel(int id, string key, string value)
        {
            this.id = id;
            this.key = key;
            this.value = value;
        }

        public SystemModel()
        {

        }

        public string Value
        {
            get { return value; }
            set { value = value; }
        }
        

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
    }
}
