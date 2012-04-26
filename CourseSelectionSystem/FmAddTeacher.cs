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
    public partial class FmAddTeacher : Form
    {
        private string tname;
        private string phone;
        private int gender;
        string birthday;

        public FmAddTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tb_phone.Text != "" && this.tb_tname.Text != "" && (this.radioButton1.Checked || this.radioButton2.Checked))
            {
                tname = this.tb_tname.Text;
                phone = this.tb_phone.Text;
                if (this.radioButton1.Checked)
                    gender = 1;
                else
                    gender = 0;
                birthday = this.dateTimePicker1.Text;
                
                TeacherModel teacherModel = new TeacherModel(0, 0, tname, gender, birthday, phone);

                int tid = 0 ;
                TeacherBusiness teacherBusiness = new TeacherBusiness();
                tid = teacherBusiness.addteacher(teacherModel);
                if (tid != 0)
                {
                    MessageBox.Show("成功!");
                }
                else
                {
                    MessageBox.Show("失败，请重试!");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("请填写所有信息！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
