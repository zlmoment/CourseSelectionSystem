using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseSelectionSystem
{
    public partial class FmTeacherMain : Form
    {
        FmLogin fmLogin;
        public FmTeacherMain(FmLogin fmLogin)
        {
            this.fmLogin = fmLogin;
            InitializeComponent();
            fmLogin.Hide();
        }

        private void FmTeacherMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmLogin.Dispose();
        }
    }
}
