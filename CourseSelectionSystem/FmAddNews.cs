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
    public partial class FmAddNews : Form
    {
        public FmAddNews()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //发布公告
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("请填写完整");
            }
            else
            {
                NewsModel newModel = new NewsModel();
                newModel.Title = this.textBox1.Text;
                newModel.Content = this.textBox2.Text;
                newModel.Pubtime = DateTime.Now.ToString();

                AddNewsBusiness addNewsBusiness = new AddNewsBusiness();
                bool result = false;
                result = addNewsBusiness.addnews(newModel);
                if (result == false)
                {
                    MessageBox.Show("添加失败，请重试！");
                }
                else
                {
                    MessageBox.Show("添加成功！");
                    this.Dispose();
                }
            }
        }
    }
}
