using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Business
{
    public class CourseInfo
    {
        private CourseModel cModel;
        private TeacherModel tModel;
        private PlaceModel pModel;

        private String cid { set; get; }
        private String cname { set; get; }
        private String credit { set; get; }
        private String duration { set; get; }
        public int sectionNom { set; get; }
        private String section { set; get; }
        private String tName { set; get; }
        private String tGender { set; get; }
        private String tBirthday { set; get; }
        private String tPhone { set; get; }
        private String pname { set; get; }
        private String precourseId { set; get; }
        private String precourseName { set; get; }
        private String maxstu { set; get; }

        public CourseInfo(CourseModel cModel, TeacherModel tModel, PlaceModel pModel, String precName)
        {
            this.cModel = cModel;
            this.tModel = tModel;
            this.pModel = pModel;
            this.precourseName = precName;

            updateCourseInfo();
        }

        private void updateCourseInfo()
        {
            this.cid = this.cModel.Cid.ToString();
            this.cname = this.cModel.Cname;
            this.credit = this.cModel.Credit.ToString();
            switch (this.cModel.Week)
            {
                case 1:
                    this.duration = "第1-16周";
                    break;
                case 2:
                    this.duration = "第1-8周";
                    break;
                case 3:
                    this.duration = "第9-16周";
                    break;
            }
            this.sectionNom = this.cModel.Section;
            switch (this.sectionNom % 6)
            {
                case 1:
                    this.section = "第1-2节";
                    break;
                case 2:
                    this.section = "第3-4节";
                    break;
                case 3:
                    this.section = "第5-6节";
                    break;
                case 4:
                    this.section = "第7-8节";
                    break;
                case 5:
                    this.section = "第9-10节";
                    break;
                case 0:
                    this.section = "第11-13节";
                    break;
            }
            this.tName = this.tModel.Tname;
            this.tGender = this.tModel.Gender == 0 ? "女" : "男";
            this.tBirthday = this.tModel.Birthday;
            this.tPhone = this.tModel.Phone;
            this.pname = this.pModel.Pname;
            this.precourseId = this.cModel.Precourse.ToString();
            this.maxstu = this.cModel.Maxstu.ToString();
        }

        public string getCourseInfo()
        {
            string info = this.cid + "_" + this.cname + "_" + this.tName + "_" + this.duration + "_" + this.section
                + "_" + this.pname;
            return info;
        }

        public string getBriefIntro()
        {
            string info = this.duration + "  " + this.section + "  " + this.pname +
                "\r\n\r\n任课老师简介： " + this.tName + " " + this.tGender + " " + this.tBirthday + " " + this.tPhone;
            return info;
        }
    }
}
