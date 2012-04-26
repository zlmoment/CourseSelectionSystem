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
            this.comboBox2.DataSource = new CollegeBusiness().getAllCollege();
            this.comboBox2.DisplayMember = "cname";
            this.comboBox2.ValueMember = "cid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tb_stunum.Text != "" && this.tb_sname.Text != "" && (this.radioButton1.Checked || this.radioButton2.Checked) && this.comboBox1.Text != "请选择年份" && this.comboBox2.Text != "请选择学院")
            {
                stunum = this.tb_stunum.Text;
                sname = this.tb_sname.Text;
                if (this.radioButton1.Checked)
                    gender = 1;
                else
                    gender = 0;
                startyear = this.comboBox1.Text;
                collegeid = int.Parse(this.comboBox2.SelectedValue.ToString());

                int sid = 0 ;
                StudentBusiness addStudentBusiness = new StudentBusiness();
                sid = addStudentBusiness.addstudent(stunum, sname, gender, startyear, collegeid);
                if (sid != 0)
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

        private void FmAddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
