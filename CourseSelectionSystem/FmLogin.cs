using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SkinSharp;
using Business;
using Model;


namespace CourseSelectionSystem
{
    public partial class FmLogin : Form
    {
        public SkinH_Net skinh;
        public FmLogin()
        {
            skinh = new SkinH_Net();
            skinh.Attach();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            int type = 0 ;
            if (username == "" || password == "")
            {
                MessageBox.Show("请输入用户名或密码");
                this.textBox1.Focus();
            }
            else
            {
                this.button1.Text = "正在登陆...";
                this.button1.Enabled = false;
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;

                UserLoginBusiness userLoginBusiness = new UserLoginBusiness();
                type = userLoginBusiness.CheckPasswd(username, password);
                UserModel userModel = new UserModel();
                userModel.Username = username;
                userModel.Password = password;

                //1:学生
                if (type == 1)
                {
                    //增加一个userModel.Uid =userLoginBusiness.getUid(username);
                    FmStudentMain fmStudentMain = new FmStudentMain(this);
                    fmStudentMain.Show();
                }
                //2:老师
                else if (type == 2)
                {
                    FmTeacherMain fmTeacherMain = new FmTeacherMain(this);
                    fmTeacherMain.Show();
                }
                //3:管理员
                else if (type == 3)
                {
                    FmAdminMain fmAdminMain = new FmAdminMain(this);
                    fmAdminMain.Show();
                }
                //0:登陆失败
                else if (type == 0)
                {
                    MessageBox.Show("登陆失败，请重试。");
                    this.button1.Text = "登陆";
                    this.button1.Enabled = true;
                    this.textBox1.Enabled = true;
                    this.textBox2.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
