﻿namespace CourseSelectionSystem
{
    partial class FmTeacherMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_renewpasswd = new System.Windows.Forms.TextBox();
            this.tb_newpasswd = new System.Windows.Forms.TextBox();
            this.tb_originpasswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "选课情况查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(687, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "其它";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_renewpasswd);
            this.groupBox1.Controls.Add(this.tb_newpasswd);
            this.groupBox1.Controls.Add(this.tb_originpasswd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_renewpasswd
            // 
            this.tb_renewpasswd.Location = new System.Drawing.Point(92, 118);
            this.tb_renewpasswd.Name = "tb_renewpasswd";
            this.tb_renewpasswd.Size = new System.Drawing.Size(156, 21);
            this.tb_renewpasswd.TabIndex = 5;
            // 
            // tb_newpasswd
            // 
            this.tb_newpasswd.Location = new System.Drawing.Point(92, 83);
            this.tb_newpasswd.Name = "tb_newpasswd";
            this.tb_newpasswd.Size = new System.Drawing.Size(156, 21);
            this.tb_newpasswd.TabIndex = 4;
            // 
            // tb_originpasswd
            // 
            this.tb_originpasswd.Location = new System.Drawing.Point(92, 48);
            this.tb_originpasswd.Name = "tb_originpasswd";
            this.tb_originpasswd.Size = new System.Drawing.Size(156, 21);
            this.tb_originpasswd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次输入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(687, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "我的课程";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.cname,
            this.credit,
            this.week,
            this.section,
            this.pid,
            this.precourse});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "新增课程";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除选中";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "修改选中";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cid
            // 
            this.cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cid.DataPropertyName = "cid";
            this.cid.HeaderText = "课序号";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cname.DataPropertyName = "cname";
            this.cname.HeaderText = "课程名";
            this.cname.Name = "cname";
            // 
            // credit
            // 
            this.credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.credit.DataPropertyName = "credit";
            this.credit.HeaderText = "学分";
            this.credit.Name = "credit";
            // 
            // week
            // 
            this.week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.week.DataPropertyName = "week";
            this.week.HeaderText = "周次";
            this.week.Name = "week";
            // 
            // section
            // 
            this.section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.section.DataPropertyName = "section";
            this.section.HeaderText = "时间";
            this.section.Name = "section";
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "地点";
            this.pid.Name = "pid";
            // 
            // precourse
            // 
            this.precourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precourse.DataPropertyName = "precourse";
            this.precourse.HeaderText = "先修";
            this.precourse.Name = "precourse";
            // 
            // FmTeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 455);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FmTeacherMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用选课系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmTeacherMain_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_renewpasswd;
        private System.Windows.Forms.TextBox tb_newpasswd;
        private System.Windows.Forms.TextBox tb_originpasswd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn week;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn precourse;
    }
}