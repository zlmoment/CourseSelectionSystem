using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using Service;

namespace Business
{
    public class StudentBusiness
    {
        public StudentBusiness()
        {
        }
        //在getAllStudent()里把datatable遍历，增加新的一列
        public DataTable getAllStudent()
        {
            StudentService stuService = new StudentService();
            DataTable dt = stuService.getAllStudent();
            //添加性别列
            dt.Columns.Add("trans_gender",typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["gender"].ToString() == "0")
                {
                    dr["trans_gender"] = "女";
                } 
                else
                {
                    dr["trans_gender"] = "男";
                }
                
            }
            //添加学院列
            dt.Columns.Add("trans_college", typeof(string));
            CollegeService collegeService = new CollegeService();
            foreach (DataRow dr in dt.Rows)
            {
                dr["trans_college"] = collegeService.getCollegeNameByCid(int.Parse(dr["collegeid"].ToString())).Cname;
            }
            return dt;
        }
        public int addstudent(string stunum, string sname, int gender, string startyear, int collegeid)
        {
            UserService userService = new UserService();
            int uid, sid = 0;
            uid = userService.insert(stunum, "123456", 1);
            if (uid != 0)
            {
                StudentService studentService = new StudentService();
                sid = studentService.insert(uid, stunum, sname, gender, startyear, collegeid);
            }
            return sid;
        }
        public int updatestudent(StudentModel stuModel)
        {
            return new StudentService().update(stuModel);
        }
        public int deleteStudent(int sid)
        {
            return new StudentService().delete(sid);
        }
        public StudentModel getStuBySid(int sid)
        {
            return new StudentService().getStuBySid(sid);
        }
        public int getSidByUid(int uid)
        {
            return new StudentService().getSidByUid(uid);
        }
    }
}
