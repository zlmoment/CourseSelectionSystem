using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;
using Model;

namespace CourseSelectionSystem
{
    public partial class FmStudentMain : Form
    {
        FmLogin fmLogin;
        UserModel userModel;
        StudentModel studentModel;
        public FmStudentMain(FmLogin fmLogin, UserModel userModel)
        {
            InitializeComponent();
            this.fmLogin = fmLogin;
            this.userModel = userModel;
            StudentBusiness sBusiness = new StudentBusiness();
            this.studentModel = sBusiness.getStuBySid(sBusiness.getSidByUid(userModel.Uid));
            fmLogin.Hide();
        }

        private void FmStudentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmLogin.Show();            
        }
        //修改密码
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tb_originpasswd.Text == "" || this.tb_newpasswd.Text == "" || this.tb_renewpasswd.Text == "")
            {
                MessageBox.Show("请输入所有内容。");
            }
            else
            {
                if (this.tb_originpasswd.Text == this.userModel.Password)
                {
                    if (this.tb_newpasswd.Text == this.tb_renewpasswd.Text)
                    {
                        UserBusiness userBusiness = new UserBusiness();
                        if (userBusiness.changePasswd(userModel.Username, this.tb_newpasswd.Text))
                        {
                            MessageBox.Show("修改成功");
                            this.tb_originpasswd.Text = "";
                            this.tb_newpasswd.Text = "";
                            this.tb_renewpasswd.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("修改失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次输入的密码不一致");
                        this.tb_newpasswd.Text = "";
                        this.tb_renewpasswd.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("原密码不正确");
                    this.tb_originpasswd.Text = "";
                    this.tb_newpasswd.Text = "";
                    this.tb_renewpasswd.Text = "";
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 2)
            {
                int sid = new StudentBusiness().getSidByUid(userModel.Uid);
                List<CourseInfo> courseInfoList = new GetTimetableBusiness().getTimetable(this.studentModel.Sid);
                int section = 0;
                if (courseInfoList != null)
                {
                    foreach (CourseInfo courseInfo in courseInfoList)
                    {
                        section = courseInfo.sectionNom;
                        ((System.Windows.Forms.Label)(this.Controls.Find("lb_" + section.ToString(), true)[0])).Text = courseInfo.getCourseInfo();
                    }
                }            
            }
        }


        private void btn_refreshCL_Click(object sender, EventArgs e)
        {
            CourseBusiness couBusiness = new CourseBusiness();
            DataTable dt = couBusiness.getAllCourse();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = dt;
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = this.dataGridView1.SelectedRows;

            foreach (DataGridViewRow row in selectedRow)
            {
                CourseInfo courseInfo = new CourseBusiness().getCourseInfobyCid(int.Parse(row.Cells["cid"].Value.ToString()));
                this.textBox1.Text = "课程简介： " + courseInfo.getBriefIntro();
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow != null)
            {
                foreach (DataGridViewRow row in selectedRow)
                {
                    CourseBusiness courseBusiness = new CourseBusiness();
                    int isSelected = courseBusiness.selectCourse(this.studentModel.Sid, int.Parse(row.Cells["cid"].Value.ToString()));
                    if (isSelected == 1)
                        MessageBox.Show("选课成功!");
                    else if (isSelected == 0)
                        MessageBox.Show("您已选中此课");
                    else
                        MessageBox.Show("选课失败，请再试一次");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseBusiness couBusiness = new CourseBusiness();
            DataTable dt = couBusiness.getAllCoursebySid(this.studentModel.Sid);
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = dt;
        }
    }
}
