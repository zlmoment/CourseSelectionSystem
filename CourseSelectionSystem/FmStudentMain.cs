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
        //窗体关闭
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
        //显示最新的课表
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.tabControl1.SelectedIndex.ToString());
            switch (this.tabControl1.SelectedIndex)
            {
                case 0: break;
                //刷新选课列表
                case 1: this.btn_refreshCL_Click(null, null); break;
                //刷新已选课
                case 2: this.button3_Click(null, null); break;
                //刷新我的课表
                case 3: 
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
                    this.tabPage3.Refresh();
                    break;
                case 4: break;
            }
            
        }

        //获取全部课程
        private void btn_refreshCL_Click(object sender, EventArgs e)
        {
            CourseBusiness couBusiness = new CourseBusiness(this.studentModel.Sid);
            DataTable dt = couBusiness.getAllCourse();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = dt;
        }

        //获取课程详细信息
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = this.dataGridView1.SelectedRows;

            foreach (DataGridViewRow row in selectedRow)
            {
                CourseInfo courseInfo = new CourseBusiness().getCourseInfobyCid(int.Parse(row.Cells["cid"].Value.ToString()));
                this.textBox1.Text = "课程简介： " + courseInfo.getBriefIntro();
            }
        }
        //选课
        private void btn_select_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow != null)
            {
                foreach (DataGridViewRow row in selectedRow)
                {
                    CourseBusiness courseBusiness = new CourseBusiness();
                    int isSelected = courseBusiness.selectCourse(this.studentModel.Sid, int.Parse(row.Cells["cid"].Value.ToString()));
                    if (isSelected == 2)
                    {
                        MessageBox.Show("您还没有修此课的先修课程，不能选此课。");
                    }
                    else if (isSelected == 3)
                    {
                        MessageBox.Show("时间冲突，请重新选择！");
                    }
                    else if (isSelected == 1)
                    {
                        MessageBox.Show("选课成功!");
                    }
                    else if (isSelected == 0)
                    {
                        MessageBox.Show("您已选中此课");
                    }
                    else if (isSelected == -1)
                    {
                        MessageBox.Show("选课失败，请再试一次");
                    }
                }
            }
            
        }
        //退课
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退课吗？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRow = this.dataGridView2.SelectedRows;
                if (selectedRow != null)
                {
                    foreach (DataGridViewRow row in selectedRow)
                    {
                        int cid = int.Parse(row.Cells["s_cid"].Value.ToString());
                        if (new CourseBusiness(this.studentModel.Sid).deleteSelectedCourse(this.studentModel.Sid, cid))
                        {
                            MessageBox.Show("退课成功！");
                        }
                        else
                        {
                            MessageBox.Show("退课失败，请重试！");
                        }
                    }
                }
            }
        }
        //获得已选课
        private void button3_Click(object sender, EventArgs e)
        {
            CourseBusiness couBusiness = new CourseBusiness();
            DataTable dt = couBusiness.getSelectedCourse(this.studentModel.Sid);
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = dt;
        }
        
    }
}
