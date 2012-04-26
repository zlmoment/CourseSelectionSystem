using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Business;

namespace CourseSelectionSystem
{
    public partial class FmAdminMain : Form
    {
        FmLogin fmLogin;
        UserModel userModel;
        NewsModel[] newsModelList = null;
        

        public FmAdminMain(FmLogin fmLogin, UserModel userModel)
        {
            this.fmLogin = fmLogin;
            InitializeComponent();
            this.fmLogin.Hide();
            this.userModel = userModel;
        }
        private void FmAdminMain_Load(object sender, EventArgs e)
        {
            this.checkedListBox1.Hide();
            this.button3.Enabled = false;
        }
        private void FmAdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmLogin.Show();
        }
        //添加学生
        private void button1_Click(object sender, EventArgs e)
        {
            FmAddStudent fmAddStudent = new FmAddStudent();
            fmAddStudent.ShowDialog();
        }
        //刷新公告列表
        private void button5_Click(object sender, EventArgs e)
        {
            this.checkedListBox1.Hide();
            this.label3.Show();
            this.label3.Text = "正在给力的拉取数据，请稍等...";
            this.label3.Refresh(); 
            GetAllNewsListBusiness getAllNewsListBusiness = new GetAllNewsListBusiness();
            newsModelList = getAllNewsListBusiness.getAllNewsList();
            if (newsModelList == null)
            {
                MessageBox.Show("读取失败，请重试。");
                this.label3.Text = "请点击右侧“刷新列表”读取公告列表";
                this.label3.Refresh(); 
            }
            else
            {
                this.label3.Hide();
                this.checkedListBox1.Show();
                this.checkedListBox1.Items.Clear();
                int listLength = newsModelList.Length;
                for (int i = 0; i < listLength; i++)
                {
                    this.checkedListBox1.Items.Add(newsModelList[i].Title);
                }
                this.button3.Enabled = true;
            }
        }
        //双击公告列表
        private void checkedListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            FmNewsDetail fmNewsDetail = new FmNewsDetail("公告内容", newsModelList[this.checkedListBox1.SelectedIndex]);
            fmNewsDetail.ShowDialog();
        }
        //新增公告
        private void button2_Click(object sender, EventArgs e)
        {
            FmAddNews fmAddNews = new FmAddNews();
            fmAddNews.ShowDialog();
        }
        //删除公告
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗？", "删除确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.checkedListBox1.CheckedItems.Count != 0)
                {
                    int totalCount = newsModelList.Length;
                    int[] toBeDeleted = new int[totalCount];

                    for (int i = 0; i < totalCount; i++)
                    {
                        if (this.checkedListBox1.GetItemChecked(i))
                        {
                            toBeDeleted[i] = newsModelList[i].Nid;
                        }
                        else
                        {
                            toBeDeleted[i] = 0;
                        }
                    }
                    DeleteNewsBusiness deleteNewsBusiness = new DeleteNewsBusiness();
                    if (deleteNewsBusiness.delete(toBeDeleted))
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                else
                {
                    MessageBox.Show("请先选择项");
                }
            }
        }
        //修改公告
        private void button4_Click(object sender, EventArgs e)
        {
            //bug:未选中之前点击会空指针
            FmNewsDetail fmNewsDetail = new FmNewsDetail("修改内容", newsModelList[this.checkedListBox1.SelectedIndex],true);
            fmNewsDetail.ShowDialog();
        }
        //刷新学生列表
        private void button6_Click(object sender, EventArgs e)
        {
            StudentBusiness stuBusiness = new StudentBusiness();
            DataTable dt = stuBusiness.getAllStudent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = dt;
            DataGridViewComboBoxColumn cob = new DataGridViewComboBoxColumn();
            cob = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["collegeid"];
            cob.DataSource = new CollegeBusiness().getAllCollege();
            cob.DisplayMember = "cname";
            cob.ValueMember = "cid";
        }
        //修改密码
        private void button9_Click(object sender, EventArgs e)
        {
            if (this.tb_originPasswd.Text == "" || this.tb_newpasswd.Text == "" || this.tb_renewpasswd.Text == "")
            {
                MessageBox.Show("请输入所有内容。");
            } 
            else
            {
                if (this.tb_originPasswd.Text == this.userModel.Password)
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
        //刷新教师列表
        private void button13_Click(object sender, EventArgs e)
        {
            
            TeacherBusiness teaBusiness = new TeacherBusiness();
            DataTable dt = teaBusiness.getAllTeacher();
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = dt;
        }
        //新增教师
        private void button10_Click(object sender, EventArgs e)
        {
            FmAddTeacher fmAddTeacher = new FmAddTeacher();
            fmAddTeacher.ShowDialog();
        }
        //修改选中学生
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请直接双击单元格进行修改，修改完后回车即可！");
        }
        //修改教师
        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请直接双击单元格进行修改，修改完后回车即可！");
        }
        //学生列表编辑后保存 
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            StudentModel stuModelToBeUpdated = new StudentModel();
            StudentBusiness stuBusiness = new StudentBusiness();
            //int sid = int.Parse(this.dataGridView1.CurrentRow.Cells["sid"].Value.ToString());
            stuModelToBeUpdated.Sid = int.Parse(this.dataGridView1.CurrentRow.Cells["sid"].Value.ToString());
            stuModelToBeUpdated.Stunum = this.dataGridView1.CurrentRow.Cells["stunum"].Value.ToString();
            stuModelToBeUpdated.Sname = this.dataGridView1.CurrentRow.Cells["sname"].Value.ToString();
            stuModelToBeUpdated.Startyear = this.dataGridView1.CurrentRow.Cells["startyear"].Value.ToString();
            stuModelToBeUpdated.Gender = this.dataGridView1.CurrentRow.Cells["gender"].Value.ToString() == "男" ? 1 : 0;
            if (this.dataGridView1.CurrentCell.ColumnIndex == this.dataGridView1.Columns["collegeid"].Index)
            {
                stuModelToBeUpdated.Collegeid = int.Parse(this.dataGridView1.CurrentRow.Cells["collegeid"].Value.ToString());
            }
            else
            {
                stuModelToBeUpdated.Collegeid = int.Parse(this.dataGridView1.CurrentRow.Cells["college_id"].Value.ToString());
            }
            //stuModelToBeUpdated = stuBusiness.getStuBySid(sid);
            int result = stuBusiness.updatestudent(stuModelToBeUpdated);
            if (result != 0)
            {
                MessageBox.Show("更新成功");
            } 
            else
            {
                MessageBox.Show("更新失败");
            }
            
        }
        //学生datagridview数据绑定完毕后
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
        //删除学生按钮
        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool isDeleteOk = true;
                StudentBusiness stuBusiness = new StudentBusiness();
                DataGridViewSelectedRowCollection toBeDeletedRowsCollection = this.dataGridView1.SelectedRows;

                DataGridViewRow[] tobedeletedrows = new DataGridViewRow[toBeDeletedRowsCollection.Count];
                toBeDeletedRowsCollection.CopyTo(tobedeletedrows, 0);
                foreach (DataGridViewRow temp in tobedeletedrows)
                {
                    if (stuBusiness.deleteStudent(int.Parse(temp.Cells["sid"].Value.ToString())) == 0)
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
        //删除教师
        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                bool isDeleteOk = true;
                TeacherBusiness teaBusiness = new TeacherBusiness();
                DataGridViewSelectedRowCollection toBeDeletedRowsCollection = this.dataGridView2.SelectedRows;
                DataGridViewRow[] tobedeletedrows = new DataGridViewRow[toBeDeletedRowsCollection.Count];
                toBeDeletedRowsCollection.CopyTo(tobedeletedrows, 0);
                foreach (DataGridViewRow temp in tobedeletedrows)
                {
                    if (teaBusiness.deleteTeacher(int.Parse(temp.Cells["tid"].Value.ToString())) == 0)
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
        //教师列表编辑后保存
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TeacherModel teaModelToBeUpdated = new TeacherModel();
            TeacherBusiness teaBusiness = new TeacherBusiness();

            teaModelToBeUpdated.Tid = int.Parse(this.dataGridView2.CurrentRow.Cells["tid"].Value.ToString());

            teaModelToBeUpdated.Tname = this.dataGridView2.CurrentRow.Cells["tname"].Value.ToString();
            teaModelToBeUpdated.Birthday = this.dataGridView2.CurrentRow.Cells["birthday"].Value.ToString();
            teaModelToBeUpdated.Gender = this.dataGridView2.CurrentRow.Cells["tgender"].Value.ToString()=="男"?1:0;
            teaModelToBeUpdated.Phone = this.dataGridView2.CurrentRow.Cells["phone"].Value.ToString();
            
            int result = teaBusiness.updateteacher(teaModelToBeUpdated);
            if (result != 0)
            {
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失败");
            }
        }
        //刷新课程列表
        private void button17_Click(object sender, EventArgs e)
        {
            CourseBusiness couBusiness = new CourseBusiness();
            DataTable dt = couBusiness.getAllCourse();
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.DataSource = dt;
            DataGridViewComboBoxColumn cob1 = new DataGridViewComboBoxColumn();
            cob1 = (DataGridViewComboBoxColumn)this.dataGridView3.Columns["pid"];
            cob1.DataSource = new PlaceBusiness().getAllPlace();
            cob1.DisplayMember = "pname";
            cob1.ValueMember = "pid";
            DataGridViewComboBoxColumn cob2 = new DataGridViewComboBoxColumn();
            cob2 = (DataGridViewComboBoxColumn)this.dataGridView3.Columns["ctid"];
            cob2.DataSource = new TeacherBusiness().getAllTeacher();
            cob2.DisplayMember = "tname";
            cob2.ValueMember = "tid";
        }
        //新增课程
        private void button14_Click(object sender, EventArgs e)
        {
            FmAddCourse fmAddCourse = new FmAddCourse();
            fmAddCourse.ShowDialog();
        }
        //修改选中课程
        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请直接双击单元格进行修改，修改完后回车即可！");
        }
        //删除选中课程
        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool isDeleteOk = true;
                CourseBusiness couBusiness = new CourseBusiness();
                DataGridViewSelectedRowCollection toBeDeletedRowsCollection = this.dataGridView3.SelectedRows;

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
        //课程列表更新 编辑后保存
        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            CourseModel couModelToBeUpdated = new CourseModel();
            CourseBusiness couBusiness = new CourseBusiness();
            
            couModelToBeUpdated.Cid = int.Parse(this.dataGridView3.CurrentRow.Cells["cid"].Value.ToString());
            couModelToBeUpdated.Cname = this.dataGridView3.CurrentRow.Cells["cname"].Value.ToString();
            couModelToBeUpdated.Credit = int.Parse(this.dataGridView3.CurrentRow.Cells["credit"].Value.ToString());
            if (this.dataGridView3.CurrentCell.ColumnIndex == this.dataGridView3.Columns["pid"].Index)
            {
                couModelToBeUpdated.Pid = int.Parse(this.dataGridView3.CurrentRow.Cells["pid"].Value.ToString());
            }
            else
            {
                couModelToBeUpdated.Pid = int.Parse(this.dataGridView3.CurrentRow.Cells["placeid"].Value.ToString());
            }
            if (this.dataGridView3.CurrentCell.ColumnIndex == this.dataGridView3.Columns["ctid"].Index)
            {
                couModelToBeUpdated.Tid = int.Parse(this.dataGridView3.CurrentRow.Cells["ctid"].Value.ToString());
            }
            else
            {
                couModelToBeUpdated.Tid = int.Parse(this.dataGridView3.CurrentRow.Cells["teacherid"].Value.ToString());
            }
            switch (this.dataGridView3.CurrentRow.Cells["section"].Value.ToString())
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
            if (this.dataGridView3.CurrentRow.Cells["week"].Value.ToString() == "1-16")
            {
                couModelToBeUpdated.Week = 1;
            }
            else if (this.dataGridView3.CurrentRow.Cells["week"].Value.ToString() == "1-8")
            {
                couModelToBeUpdated.Week = 2;
            }
            else
            {
                couModelToBeUpdated.Week = 3;
            }
            
            couModelToBeUpdated.Precourse = int.Parse(this.dataGridView3.CurrentRow.Cells["precourse"].Value.ToString());
            couModelToBeUpdated.Maxstu = int.Parse(this.dataGridView3.CurrentRow.Cells["maxstu"].Value.ToString());
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

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }
        //选项卡切换时触发刷新操作
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedIndex)
            {
                case 0: break;
                //刷新课程列表
                case 1: this.button17_Click(null, null); break;
                //刷新教师列表
                case 2: this.button13_Click(null, null); break;
                //刷新公告列表
                case 3: this.button5_Click(null, null); break;
                //刷新学生列表
                case 4: this.button6_Click(null, null); break;
                case 5: break;
            }
        }


    }
}
