using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;

namespace CourseSelectionSystem
{
    public partial class FmAddStudent : Form
    {
        private string stunum;
        private string sname;
        private int gender;
        private string startyear;
        private int collegeid;

        public FmAddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tb_sname.Text != "" && this.tb_stunum.Text != "" && (this.radioButton1.Checked || this.radioButton2.Checked) && this.comboBox1.Text != "请选择年份" && this.comboBox2.Text != "请选择学院")
            {
                stunum = this.tb_stunum.Text;
                sname = this.tb_sname.Text;
                if (this.radioButton1.Checked)
                    gender = 1;
                else
                    gender = 2;
                startyear = this.comboBox1.Text;
                collegeid = int.Parse(this.comboBox2.Text);

                int sid = 0 ;
                StudentBusiness addStudentBusiness = new StudentBusiness();
                sid = addStudentBusiness.addstudent(stunum, sname, gender, startyear, collegeid);
                MessageBox.Show(Convert.ToString(sid));
                this.Hide();
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
