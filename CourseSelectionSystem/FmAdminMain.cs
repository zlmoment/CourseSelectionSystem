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
        NewsModel[] newsModelList = null;
        public FmAdminMain(FmLogin fmLogin)
        {
            this.fmLogin = fmLogin;
            InitializeComponent();
            this.fmLogin.Hide();
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
            FmNewsDetail fmNewsDetail = new FmNewsDetail("修改内容", newsModelList[this.checkedListBox1.SelectedIndex],true);
            fmNewsDetail.ShowDialog();
        }

    }
}
