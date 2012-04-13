using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service;
using Model;
using System.Data;

namespace Business
{
    public class TeacherBusiness
    {
        public TeacherBusiness()
        {

        }
        public int addteacher(TeacherModel teacherModel)
        {
            UserService userService = new UserService();
            int uid, tid = 0;
            uid = userService.insert(teacherModel.Tname, "123456", 2);
            if (uid != 0)
            {
                teacherModel.Uid = uid;
                TeacherService teacherService = new TeacherService();
                tid = teacherService.insert(teacherModel);
                //这里将来要模拟实现事务，如果tid为0，则删除user表里的记录
            }
            return tid;
        }
        public DataTable getAllTeacher()
        {
            TeacherService teaService = new TeacherService();
            return teaService.getAllTeacher();
        }
    }
}
