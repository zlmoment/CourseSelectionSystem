using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Service;

namespace Business
{
    public class GetTimetableBusiness
    {
        private List<CourseModel> courseModelList;
        private List<CourseInfo> courseInfoList = new List<CourseInfo>();
        private CourseInfo courseInfo;
        private TeacherModel tModel;
        private PlaceModel pModel;
        string precName;

        public GetTimetableBusiness()
        {
        }

        public List<CourseInfo> getTimetable(int sid)
        {
            int semester = 1;
            courseModelList = new CourseService().getAllCourseBySid(sid, semester);
            if (courseModelList != null)
            {
                foreach (CourseModel cModel in courseModelList)
                {
                    tModel = new TeacherService().getTeacherByTid(cModel.Tid);
                    pModel = new PlaceService().getPlacebyPid(cModel.Pid);
                    precName = (new CourseService().getCoursebyCid(cModel.Precourse)).Cname;
                    courseInfo = new CourseInfo(cModel, tModel, pModel, precName);
                    courseInfoList.Add(courseInfo);
                }
            }           

            return courseInfoList;
        }
    }
}
