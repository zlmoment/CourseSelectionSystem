namespace CourseSelectionSystem
{
    partial class FmAddCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cname = new System.Windows.Forms.TextBox();
            this.tb_credit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_week = new System.Windows.Forms.ComboBox();
            this.cb_section = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_tid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_pid = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_precourse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请填写下列课程信息（课序号将自动生成）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程名";
            // 
            // tb_cname
            // 
            this.tb_cname.Location = new System.Drawing.Point(102, 62);
            this.tb_cname.Name = "tb_cname";
            this.tb_cname.Size = new System.Drawing.Size(139, 21);
            this.tb_cname.TabIndex = 2;
            // 
            // tb_credit
            // 
            this.tb_credit.Location = new System.Drawing.Point(102, 103);
            this.tb_credit.Name = "tb_credit";
            this.tb_credit.Size = new System.Drawing.Size(139, 21);
            this.tb_credit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "学分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "周次";
            // 
            // cb_week
            // 
            this.cb_week.FormattingEnabled = true;
            this.cb_week.Items.AddRange(new object[] {
            "1-16",
            "1-8",
            "9-16"});
            this.cb_week.Location = new System.Drawing.Point(102, 141);
            this.cb_week.Name = "cb_week";
            this.cb_week.Size = new System.Drawing.Size(139, 20);
            this.cb_week.TabIndex = 6;
            this.cb_week.Text = "请选择周次";
            // 
            // cb_section
            // 
            this.cb_section.FormattingEnabled = true;
            this.cb_section.Items.AddRange(new object[] {
            "周一（1）",
            "周一（2）",
            "周一（3）",
            "周一（4）",
            "周一（5）",
            "周一（6）",
            "周二（1）",
            "周二（2）",
            "周二（3）",
            "周二（4）",
            "周二（5）",
            "周二（6）",
            "周三（1）",
            "周三（2）",
            "周三（3）",
            "周三（4）",
            "周三（5）",
            "周三（6）",
            "周四（1）",
            "周四（2）",
            "周四（3）",
            "周四（4）",
            "周四（5）",
            "周四（6）",
            "周五（1）",
            "周五（2）",
            "周五（3）",
            "周五（4）",
            "周五（5）",
            "周五（6）",
            "周六（1）",
            "周六（2）",
            "周六（3）",
            "周六（4）",
            "周六（5）",
            "周六（6）",
            "周日（1）",
            "周日（2）",
            "周日（3）",
            "周日（4）",
            "周日（5）",
            "周日（6）"});
            this.cb_section.Location = new System.Drawing.Point(102, 178);
            this.cb_section.Name = "cb_section";
            this.cb_section.Size = new System.Drawing.Size(139, 20);
            this.cb_section.TabIndex = 7;
            this.cb_section.Text = "请选择时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "授课教师";
            // 
            // cb_tid
            // 
            this.cb_tid.FormattingEnabled = true;
            this.cb_tid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_tid.Location = new System.Drawing.Point(377, 62);
            this.cb_tid.Name = "cb_tid";
            this.cb_tid.Size = new System.Drawing.Size(139, 20);
            this.cb_tid.TabIndex = 9;
            this.cb_tid.Text = "请选择教师";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "上课地点";
            // 
            // cb_pid
            // 
            this.cb_pid.FormattingEnabled = true;
            this.cb_pid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_pid.Location = new System.Drawing.Point(377, 103);
            this.cb_pid.Name = "cb_pid";
            this.cb_pid.Size = new System.Drawing.Size(139, 20);
            this.cb_pid.TabIndex = 11;
            this.cb_pid.Text = "请选择地点";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "先修课程";
            // 
            // tb_precourse
            // 
            this.tb_precourse.Location = new System.Drawing.Point(377, 140);
            this.tb_precourse.Name = "tb_precourse";
            this.tb_precourse.Size = new System.Drawing.Size(139, 21);
            this.tb_precourse.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_precourse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_pid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_tid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_section);
            this.Controls.Add(this.cb_week);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_credit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FmAddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增课程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cname;
        private System.Windows.Forms.TextBox tb_credit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_week;
        private System.Windows.Forms.ComboBox cb_section;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_tid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_pid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_precourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}