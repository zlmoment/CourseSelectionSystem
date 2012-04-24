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
            TeacherService teachService = new TeacherService();
            dt.Columns.Add("tname", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["tname"] = teachService.getTnameByTid(int.Parse(dr["tid"].ToString()));
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

        public CourseInfo getCourseInfobyCid(int cid)
        {
            CourseModel cModel = new CourseService().getCoursebyCid(cid);
            TeacherModel tModel = new TeacherService().getTeacherByTid(cModel.Tid);
            PlaceModel pModel = new PlaceService().getPlacebyPid(cModel.Pid);
            string precName = (new CourseService().getCoursebyCid(cModel.Precourse)).Cname;
            CourseInfo courseInfo = new CourseInfo(cModel, tModel, pModel, precName);
            return courseInfo;
        }

        public int selectCourse(int sid, int cid) 
        {
            int semester = 1;
            ScModel scModel = new ScModel(sid, cid, semester);
            CourseService courseService = new CourseService();
            return courseService.insertSelectedCourse(scModel);
        }

        public bool deleteCourse(int sid, int cid)
        {
            //int semester = 1;
            CourseService courseService = new CourseService();
            if (courseService.deleteSelectedCourse(sid, cid))
            {
                return true;
            }
            else
                return false;
        }
        public DataTable getAllCoursebySid(int sid)
        {
            CourseService couService = new CourseService();
            DataTable dt = couService.getCourseBySid(sid,1);
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
            TeacherService teachService = new TeacherService();
            dt.Columns.Add("tname", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["tname"] = teachService.getTnameByTid(int.Parse(dr["tid"].ToString()));
            }
            return dt;
        }
    }
}
