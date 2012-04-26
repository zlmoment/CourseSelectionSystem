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
    public partial class FmTeacherMain : Form
    {
        FmLogin fmLogin;
        UserModel userModel;
        NewsModel[] newsModelList = null;

        public FmTeacherMain(FmLogin fmLogin, UserModel userModel)
        {

            InitializeComponent();
            this.fmLogin = fmLogin;
            this.userModel = userModel;
            fmLogin.Hide();
        }

        private void FmTeacherMain_FormClosed(object sender, FormClosedEventArgs e)
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
                        }
                        else
                        {
                            MessageBox.Show("修改失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次输入的密码不一致");
                    }

                }
                else
                {
                    MessageBox.Show("原密码不正确。");
                }
            }

        }
        //新增课程
        private void button2_Click(object sender, EventArgs e)
        {
            int tid = new TeacherBusiness().getTidByUid(this.userModel.Uid);
            FmAddCourse fmAddCourse = new FmAddCourse(tid);
            fmAddCourse.ShowDialog();
        }
        //刷新教师的课程
        private void button5_Click(object sender, EventArgs e)
        {
            CourseBusiness couBusiness = new CourseBusiness();
            DataTable dt = couBusiness.getAllCourseByTid(new TeacherBusiness().getTidByUid(this.userModel.Uid));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = dt;
            DataGridViewComboBoxColumn cob1 = new DataGridViewComboBoxColumn();
            cob1 = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["pid"];
            cob1.DataSource = new PlaceBusiness().getAllPlace();
            cob1.DisplayMember = "pname";
            cob1.ValueMember = "pid";
        }
        //删除选中课程
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool isDeleteOk = true;
                CourseBusiness couBusiness = new CourseBusiness();
                DataGridViewSelectedRowCollection toBeDeletedRowsCollection = this.dataGridView1.SelectedRows;

                DataGridViewRow[] tobedeletedrows = new DataGridViewRow[toBeDeletedRowsCollection.Count];
                toBeDeletedRowsCollection.CopyTo(tobedeletedrows, 0);
                foreach (DataGridViewRow temp in tobedeletedrows)
                {
                    if (couBusiness.deleteCourse(int.Parse(temp.Cells["cid"].Value.ToString())) == 0)
                        isDeleteOk = false;
                }
                if (isDeleteOk)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除出现错误，请刷新列表后重试！");
                }
            }
        }

        //修改选中
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请直接双击单元格进行修改，修改完后回车即可！");
        }
        //修改
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            CourseModel couModelToBeUpdated = new CourseModel();
            CourseBusiness couBusiness = new CourseBusiness();

            couModelToBeUpdated.Cid = int.Parse(this.dataGridView1.CurrentRow.Cells["cid"].Value.ToString());
            couModelToBeUpdated.Cname = this.dataGridView1.CurrentRow.Cells["cname"].Value.ToString();
            couModelToBeUpdated.Credit = int.Parse(this.dataGridView1.CurrentRow.Cells["credit"].Value.ToString());
            if (this.dataGridView1.CurrentCell.ColumnIndex == this.dataGridView1.Columns["pid"].Index)
            {
                couModelToBeUpdated.Pid = int.Parse(this.dataGridView1.CurrentRow.Cells["pid"].Value.ToString());
            }
            else
            {
                couModelToBeUpdated.Pid = int.Parse(this.dataGridView1.CurrentRow.Cells["placeid"].Value.ToString());
            }
            couModelToBeUpdated.Tid = new TeacherBusiness().getTidByUid(this.userModel.Uid);
            switch (this.dataGridView1.CurrentRow.Cells["section"].Value.ToString())
            {
                case "周一（1）": couModelToBeUpdated.Section = 1; break;
                case "周一（2）": couModelToBeUpdated.Section = 2; break;
                case "周一（3）": couModelToBeUpdated.Section = 3; break;
                case "周一（4）": couModelToBeUpdated.Section = 4; break;
                case "周一（5）": couModelToBeUpdated.Section = 5; break;
                case "周一（6）": couModelToBeUpdated.Section = 6; break;
                case "周二（1）": couModelToBeUpdated.Section = 7; break;
                case "周二（2）": couModelToBeUpdated.Section = 8; break;
                case "周二（3）": couModelToBeUpdated.Section = 9; break;
                case "周二（4）": couModelToBeUpdated.Section = 10; break;
                case "周二（5）": couModelToBeUpdated.Section = 11; break;
                case "周二（6）": couModelToBeUpdated.Section = 12; break;
                case "周三（1）": couModelToBeUpdated.Section = 13; break;
                case "周三（2）": couModelToBeUpdated.Section = 14; break;
                case "周三（3）": couModelToBeUpdated.Section = 15; break;
                case "周三（4）": couModelToBeUpdated.Section = 16; break;
                case "周三（5）": couModelToBeUpdated.Section = 17; break;
                case "周三（6）": couModelToBeUpdated.Section = 18; break;
                case "周四（1）": couModelToBeUpdated.Section = 19; break;
                case "周四（2）": couModelToBeUpdated.Section = 20; break;
                case "周四（3）": couModelToBeUpdated.Section = 21; break;
                case "周四（4）": couModelToBeUpdated.Section = 22; break;
                case "周四（5）": couModelToBeUpdated.Section = 23; break;
                case "周四（6）": couModelToBeUpdated.Section = 24; break;
                case "周五（1）": couModelToBeUpdated.Section = 25; break;
                case "周五（2）": couModelToBeUpdated.Section = 26; break;
                case "周五（3）": couModelToBeUpdated.Section = 27; break;
                case "周五（4）": couModelToBeUpdated.Section = 28; break;
                case "周五（5）": couModelToBeUpdated.Section = 29; break;
                case "周五（6）": couModelToBeUpdated.Section = 30; break;
                case "周六（1）": couModelToBeUpdated.Section = 31; break;
                case "周六（2）": couModelToBeUpdated.Section = 32; break;
                case "周六（3）": couModelToBeUpdated.Section = 33; break;
                case "周六（4）": couModelToBeUpdated.Section = 34; break;
                case "周六（5）": couModelToBeUpdated.Section = 35; break;
                case "周六（6）": couModelToBeUpdated.Section = 36; break;
                case "周日（1）": couModelToBeUpdated.Section = 37; break;
                case "周日（2）": couModelToBeUpdated.Section = 38; break;
                case "周日（3）": couModelToBeUpdated.Section = 39; break;
                case "周日（4）": couModelToBeUpdated.Section = 40; break;
                case "周日（5）": couModelToBeUpdated.Section = 41; break;
                case "周日（6）": couModelToBeUpdated.Section = 42; break;
            }
            //couModelToBeUpdated.Section = int.Parse(this.dataGridView3.CurrentRow.Cells["section"].Value.ToString());
            if (this.dataGridView1.CurrentRow.Cells["week"].Value.ToString() == "1-16")
            {
                couModelToBeUpdated.Week = 1;
            }
            else if (this.dataGridView1.CurrentRow.Cells["week"].Value.ToString() == "1-8")
            {
                couModelToBeUpdated.Week = 2;
            }
            else
            {
                couModelToBeUpdated.Week = 3;
            }

            couModelToBeUpdated.Precourse = int.Parse(this.dataGridView1.CurrentRow.Cells["precourse"].Value.ToString());
            couModelToBeUpdated.Maxstu = int.Parse(this.dataGridView1.CurrentRow.Cells["maxstu"].Value.ToString());
            int result = couBusiness.updatecourse(couModelToBeUpdated);
            if (result != 0)
            {
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失败");
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = this.tabControl1.SelectedIndex;
            switch (tabIndex)
            {
                case 0: break;
                //刷新我教授的课程
                case 1: this.button5_Click(null, null); break;
            }
        }

        private void FmTeacherMain_Load(object sender, EventArgs e)
        {
            //公告列表
            GetAllNewsListBusiness getAllNewsListBusiness = new GetAllNewsListBusiness();
            newsModelList = getAllNewsListBusiness.getAllNewsList();
            if (newsModelList == null)
            {
                MessageBox.Show("读取失败，请重试。");
            }
            else
            {
                int listLength = newsModelList.Length;
                for (int i = 0; i < listLength; i++)
                {
                    this.listBox1.Items.Add(newsModelList[i].Title);
                }
            }
        }
        //双击公告
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FmNewsDetail fmNewsDetail = new FmNewsDetail("公告内容", newsModelList[this.listBox1.SelectedIndex]);
            fmNewsDetail.ShowDialog();
        }
    }
}

