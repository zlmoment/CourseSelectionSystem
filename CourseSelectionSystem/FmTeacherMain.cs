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
            fmLogin.Dispose();
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
    }
}
