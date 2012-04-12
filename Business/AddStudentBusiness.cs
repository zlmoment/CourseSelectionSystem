using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service;

namespace Business
{
    public class AddStudentBusiness
    {
        public int addstudent(string stunum, string sname, int gender, string startyear, int collegeid)
        {
            UserService userService = new UserService();
            int uid,sid = 0;
            uid = userService.insert(stunum, "123456", 1);
            if (uid != 0)
            {
                StudentService studentService = new StudentService();
                sid = studentService.insert(uid, stunum, sname, gender, startyear, collegeid);
            }
            return sid;
        }
        
    }
}
