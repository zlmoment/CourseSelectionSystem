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
        int global_semester = 0;
        public CourseBusiness()
        {
        }
        public CourseBusiness(int sid)
        {
            int startyear = int.Parse(new StudentBusiness().getStuBySid(sid).Startyear.ToString());
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            global_semester = (month >= 1 && month <= 6) ? 2 * (year - startyear) : 2 * (year - startyear) + 1;
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
            dt.Columns.Add("trans_section", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                switch (dr["section"].ToString())
                {
                    case "1": dr["trans_section"] = "周一（1）"; break;
                    case "2": dr["trans_section"] = "周一（2）"; break;
                    case "3": dr["trans_section"] = "周一（3）"; break;
                    case "4": dr["trans_section"] = "周一（4）"; break;
                    case "5": dr["trans_section"] = "周一（5）"; break;
                    case "6": dr["trans_section"] = "周一（6）"; break;
                    case "7": dr["trans_section"] = "周二（1）"; break;
                    case "8": dr["trans_section"] = "周二（2）"; break;
                    case "9": dr["trans_section"] = "周二（3）"; break;
                    case "10": dr["trans_section"] = "周二（4）"; break;
                    case "11": dr["trans_section"] = "周二（5）"; break;
                    case "12": dr["trans_section"] = "周二（6）"; break;
                    case "13": dr["trans_section"] = "周三（1）"; break;
                    case "14": dr["trans_section"] = "周三（2）"; break;
                    case "15": dr["trans_section"] = "周三（3）"; break;
                    case "16": dr["trans_section"] = "周三（4）"; break;
                    case "17": dr["trans_section"] = "周三（5）"; break;
                    case "18": dr["trans_section"] = "周三（6）"; break;
                    case "19": dr["trans_section"] = "周四（1）"; break;
                    case "20": dr["trans_section"] = "周四（2）"; break;
                    case "21": dr["trans_section"] = "周四（3）"; break;
                    case "22": dr["trans_section"] = "周四（4）"; break;
                    case "23": dr["trans_section"] = "周四（5）"; break;
                    case "24": dr["trans_section"] = "周四（6）"; break;
                    case "25": dr["trans_section"] = "周五（1）"; break;
                    case "26": dr["trans_section"] = "周五（2）"; break;
                    case "27": dr["trans_section"] = "周五（3）"; break;
                    case "28": dr["trans_section"] = "周五（4）"; break;
                    case "29": dr["trans_section"] = "周五（5）"; break;
                    case "30": dr["trans_section"] = "周五（6）"; break;
                    case "31": dr["trans_section"] = "周六（1）"; break;
                    case "32": dr["trans_section"] = "周六（2）"; break;
                    case "33": dr["trans_section"] = "周六（3）"; break;
                    case "34": dr["trans_section"] = "周六（4）"; break;
                    case "35": dr["trans_section"] = "周六（5）"; break;
                    case "36": dr["trans_section"] = "周六（6）"; break;
                    case "37": dr["trans_section"] = "周日（1）"; break;
                    case "38": dr["trans_section"] = "周日（2）"; break;
                    case "39": dr["trans_section"] = "周日（3）"; break;
                    case "40": dr["trans_section"] = "周日（4）"; break;
                    case "41": dr["trans_section"] = "周日（5）"; break;
                    case "42": dr["trans_section"] = "周日（6）"; break;
                }
            }
            TeacherService teachService = new TeacherService();
            dt.Columns.Add("tname", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["tname"] = teachService.getTnameByTid(int.Parse(dr["tid"].ToString()));
            }
            dt.Columns.Add("trans_pid", typeof(string));
            PlaceService placeService = new PlaceService();
            foreach (DataRow dr in dt.Rows)
            {
                dr["trans_pid"] = placeService.getPlacebyPid(int.Parse(dr["pid"].ToString())).Pname;
            }
            //已选人数
            dt.Columns.Add("takenstunum", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["takenstunum"] = couService.getTakeStuNumByCid(int.Parse(dr["cid"].ToString()), global_semester);
            }
            return dt;
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
            int startyear = int.Parse(new StudentBusiness().getStuBySid(sid).Startyear.ToString());
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int semester = (month >= 1 && month <= 6) ? 2 * (year - startyear) : 2 * (year - startyear) + 1;
            ScModel scModel = new ScModel(sid, cid, semester);
            CourseService courseService = new CourseService();
            //判断是否有先修
            if (!courseService.ifPrecourceYes(sid,cid,semester))
            {
                return 2;
            }
            //判断是否冲突
            else if (courseService.isSectionNotAvailable(sid,cid,semester))
            {
                return 3;
            }
            else
            {
                return courseService.insertSelectedCourse(scModel);
            }
            
        }

        public bool deleteSelectedCourse(int sid, int cid)
        {
            CourseService courseService = new CourseService();
            if (courseService.deleteSelectedCourse(sid, cid, global_semester))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int deleteCourse(int cid)
        {
            CourseService courseService = new CourseService();
            return courseService.delete(cid);
        }
        public DataTable getSelectedCourse(int sid)
        {
            int startyear = int.Parse(new StudentBusiness().getStuBySid(sid).Startyear.ToString());
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int semester = (month >= 1 && month <= 6) ? 2 * (year - startyear) : 2 * (year - startyear) + 1;
            CourseService couService = new CourseService();
            DataTable dt = couService.getSelectedCourse(sid, semester);
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
            dt.Columns.Add("trans_section", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                switch (dr["section"].ToString())
                {
                    case "1": dr["trans_section"] = "周一（1）"; break;
                    case "2": dr["trans_section"] = "周一（2）"; break;
                    case "3": dr["trans_section"] = "周一（3）"; break;
                    case "4": dr["trans_section"] = "周一（4）"; break;
                    case "5": dr["trans_section"] = "周一（5）"; break;
                    case "6": dr["trans_section"] = "周一（6）"; break;
                    case "7": dr["trans_section"] = "周二（1）"; break;
                    case "8": dr["trans_section"] = "周二（2）"; break;
                    case "9": dr["trans_section"] = "周二（3）"; break;
                    case "10": dr["trans_section"] = "周二（4）"; break;
                    case "11": dr["trans_section"] = "周二（5）"; break;
                    case "12": dr["trans_section"] = "周二（6）"; break;
                    case "13": dr["trans_section"] = "周三（1）"; break;
                    case "14": dr["trans_section"] = "周三（2）"; break;
                    case "15": dr["trans_section"] = "周三（3）"; break;
                    case "16": dr["trans_section"] = "周三（4）"; break;
                    case "17": dr["trans_section"] = "周三（5）"; break;
                    case "18": dr["trans_section"] = "周三（6）"; break;
                    case "19": dr["trans_section"] = "周四（1）"; break;
                    case "20": dr["trans_section"] = "周四（2）"; break;
                    case "21": dr["trans_section"] = "周四（3）"; break;
                    case "22": dr["trans_section"] = "周四（4）"; break;
                    case "23": dr["trans_section"] = "周四（5）"; break;
                    case "24": dr["trans_section"] = "周四（6）"; break;
                    case "25": dr["trans_section"] = "周五（1）"; break;
                    case "26": dr["trans_section"] = "周五（2）"; break;
                    case "27": dr["trans_section"] = "周五（3）"; break;
                    case "28": dr["trans_section"] = "周五（4）"; break;
                    case "29": dr["trans_section"] = "周五（5）"; break;
                    case "30": dr["trans_section"] = "周五（6）"; break;
                    case "31": dr["trans_section"] = "周六（1）"; break;
                    case "32": dr["trans_section"] = "周六（2）"; break;
                    case "33": dr["trans_section"] = "周六（3）"; break;
                    case "34": dr["trans_section"] = "周六（4）"; break;
                    case "35": dr["trans_section"] = "周六（5）"; break;
                    case "36": dr["trans_section"] = "周六（6）"; break;
                    case "37": dr["trans_section"] = "周日（1）"; break;
                    case "38": dr["trans_section"] = "周日（2）"; break;
                    case "39": dr["trans_section"] = "周日（3）"; break;
                    case "40": dr["trans_section"] = "周日（4）"; break;
                    case "41": dr["trans_section"] = "周日（5）"; break;
                    case "42": dr["trans_section"] = "周日（6）"; break;
                }
            }
            TeacherService teachService = new TeacherService();
            dt.Columns.Add("tname", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["tname"] = teachService.getTnameByTid(int.Parse(dr["tid"].ToString()));
            }
            dt.Columns.Add("trans_pid", typeof(string));
            PlaceService placeService = new PlaceService();
            foreach (DataRow dr in dt.Rows)
            {
                dr["trans_pid"] = placeService.getPlacebyPid(int.Parse(dr["pid"].ToString())).Pname;
            }
            return dt;
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
