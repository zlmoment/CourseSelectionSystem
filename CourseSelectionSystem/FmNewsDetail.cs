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
    public partial class FmNewsDetail : Form
    {
        NewsModel newsModel;
        bool isEdit;
        public FmNewsDetail(string formTitle,NewsModel newsModel,bool isEdit = false)
        {
            InitializeComponent();
            this.Text = formTitle;
            this.newsModel = newsModel;
            this.isEdit = isEdit;
            if (isEdit == true)
            {
                this.button1.Text = "保存";
                this.textBox1.ReadOnly = false;
                this.textBox2.ReadOnly = false;
            }

        }

        private void FmNewsDetail_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = newsModel.Title;
            this.textBox2.Text = newsModel.Content;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //返回
            if (isEdit == false)
            {
                this.Dispose();
            }
            else
            {
                newsModel.Title = this.textBox1.Text;
                newsModel.Content = this.textBox2.Text;
                if (new UpdateNewsBusiness().updateNewsBusiness(newsModel) == true)
                {
                    MessageBox.Show("保存成功");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
        }
    }
}
