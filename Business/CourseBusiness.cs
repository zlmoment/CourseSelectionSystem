using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Service;
using System.Data;

namespace Business
{
    public class CourseBusiness
    {
        public CourseBusiness()
        {
        }
        public int addCourse(CourseModel courseModel)
        {
            return new CourseService().insert(courseModel);
        }
        public DataTable getAllCourse()
        {
            CourseService couService = new CourseService();
            return couService.getAllCourse();
        }
    }
}
