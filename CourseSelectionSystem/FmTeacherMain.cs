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
            couModelToBeUpdated.Pid = int.Parse(this.dataGridView1.CurrentRow.Cells["pid"].Value.ToString());
            couModelToBeUpdated.Tid = new TeacherBusiness().getTidByUid(this.userModel.Uid);
            couModelToBeUpdated.Section = int.Parse(this.dataGridView1.CurrentRow.Cells["section"].Value.ToString());
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
    }
}

