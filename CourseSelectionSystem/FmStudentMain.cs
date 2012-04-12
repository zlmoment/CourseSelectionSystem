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
    public partial class FmStudentMain : Form
    {
        FmLogin fmLogin;
        public FmStudentMain(FmLogin fmLogin)
        {
            this.fmLogin = fmLogin;
            InitializeComponent();
            fmLogin.Hide();
        }

        private void FmStudentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmLogin.Dispose();
        }
    }
}
