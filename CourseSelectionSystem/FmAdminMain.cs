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
            fmLogin.Dispose();
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
            //这里还需要对列的显示进行自定义
            StudentBusiness stuBusiness = new StudentBusiness();
            DataTable dt = stuBusiness.getAllStudent();
            this.dataGridView1.DataSource = dt;
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
            //这里还需要对列的显示进行自定义
            TeacherBusiness teaBusiness = new TeacherBusiness();
            DataTable dt = teaBusiness.getAllTeacher();
            this.dataGridView2.DataSource = dt;
        }
        //新增教师
        private void button10_Click(object sender, EventArgs e)
        {
            FmAddTeacher fmAddTeacher = new FmAddTeacher();
            fmAddTeacher.ShowDialog();
        }

    }
}
