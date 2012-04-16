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
        public DataTable getAllStudent()
        {
            StudentService stuService = new StudentService();
            return stuService.getAllStudent();
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
        public StudentModel getStuBySid(int sid)
        {
            return new StudentService().getStuBySid(sid);
        }
    }
}
