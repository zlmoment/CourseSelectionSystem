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
            DataTable dt = couService.getAllCourse();
            dt.Columns.Add("trans_week", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["week"].ToString() == "1")
                {
                    dr["trans_week"] = "1-16";
                }
                else if (dr["week"].ToString() == "2")
                {
                    dr["trans_week"] = "1-8";
                }
                else
                {
                    dr["trans_week"] = "9-16";
                }

            }
            return dt;
        }
        public int deleteCourse(int cid)
        {
            return new CourseService().delete(cid);
        }
        public int updatecourse(CourseModel couModel)
        {
            return new CourseService().update(couModel);
        }
        public DataTable getAllCourseByTid(int tid)
        {
            CourseService couService = new CourseService();
            DataTable dt = couService.getAllCourseByTid(tid);
            dt.Columns.Add("trans_week", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["week"].ToString() == "1")
                {
                    dr["trans_week"] = "1-16";
                }
                else if (dr["week"].ToString() == "2")
                {
                    dr["trans_week"] = "1-8";
                }
                else
                {
                    dr["trans_week"] = "9-16";
                }

            }
            return dt;
        }
    }
}
