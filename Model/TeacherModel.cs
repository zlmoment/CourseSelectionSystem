﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class TeacherModel
    {
        private int tid;
        private int uid;
        private string tname;
        private int gender;
        private DateTime birthday;
        private string phone;

        public TeacherModel(int tid, int uid, string tname, int gender, DateTime birthday, string phone)
        {
            this.tid = tid;
            this.uid = uid;
            this.tname = tname;
            this.gender = gender;
            this.birthday = birthday;
            this.phone = phone;
        }

        public TeacherModel()
        {

        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        

        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        

        public string Tname
        {
            get { return tname; }
            set { tname = value; }
        }
        

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        

        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }
        
    }
}
