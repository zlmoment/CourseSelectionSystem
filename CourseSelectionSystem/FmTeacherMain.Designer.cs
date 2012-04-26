namespace CourseSelectionSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTeacherMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxstu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenstunum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_renewpasswd = new System.Windows.Forms.TextBox();
            this.tb_newpasswd = new System.Windows.Forms.TextBox();
            this.tb_originpasswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 431);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(54, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 168);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.ForeColor = System.Drawing.Color.Blue;
            this.label28.Location = new System.Drawing.Point(50, 172);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(170, 21);
            this.label28.TabIndex = 6;
            this.label28.Text = "最新公告（双击查看）";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(225, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(234, 21);
            this.label27.TabIndex = 5;
            this.label27.Text = "请点击各选项卡查看所有功能。";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.Purple;
            this.label26.Location = new System.Drawing.Point(144, 44);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(411, 28);
            this.label26.TabIndex = 4;
            this.label26.Text = "欢迎登陆选课系统，您现在的身份是教师。";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(687, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "我授课的课程";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(572, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "刷新列表";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "修改选中";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除选中";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "新增课程";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.placeid,
            this.precourse,
            this.maxstu,
            this.takenstunum});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // cid
            // 
            this.cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cid.DataPropertyName = "cid";
            this.cid.FillWeight = 66.81473F;
            this.cid.HeaderText = "课序号";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cname.DataPropertyName = "cname";
            this.cname.FillWeight = 66.81473F;
            this.cname.HeaderText = "课程名";
            this.cname.Name = "cname";
            // 
            // credit
            // 
            this.credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.credit.DataPropertyName = "credit";
            this.credit.FillWeight = 66.81473F;
            this.credit.HeaderText = "学分";
            this.credit.Name = "credit";
            // 
            // week
            // 
            this.week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.week.DataPropertyName = "trans_week";
            this.week.FillWeight = 66.81473F;
            this.week.HeaderText = "周次";
            this.week.Items.AddRange(new object[] {
            "1-16",
            "1-8",
            "9-16"});
            this.week.Name = "week";
            this.week.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.week.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // section
            // 
            this.section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.section.DataPropertyName = "trans_section";
            this.section.FillWeight = 365.4822F;
            this.section.HeaderText = "时间";
            this.section.Items.AddRange(new object[] {
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
            this.section.MinimumWidth = 80;
            this.section.Name = "section";
            this.section.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.section.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.section.Width = 80;
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.DataPropertyName = "trans_pid";
            this.pid.FillWeight = 66.81473F;
            this.pid.HeaderText = "地点";
            this.pid.Name = "pid";
            this.pid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // placeid
            // 
            this.placeid.DataPropertyName = "pid";
            this.placeid.HeaderText = "地点id";
            this.placeid.Name = "placeid";
            this.placeid.ReadOnly = true;
            this.placeid.Visible = false;
            // 
            // precourse
            // 
            this.precourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precourse.DataPropertyName = "precourse";
            this.precourse.FillWeight = 66.81473F;
            this.precourse.HeaderText = "先修";
            this.precourse.Name = "precourse";
            // 
            // maxstu
            // 
            this.maxstu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxstu.DataPropertyName = "maxstu";
            this.maxstu.FillWeight = 66.81473F;
            this.maxstu.HeaderText = "人数";
            this.maxstu.Name = "maxstu";
            // 
            // takenstunum
            // 
            this.takenstunum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.takenstunum.DataPropertyName = "takenstunum";
            this.takenstunum.FillWeight = 66.81473F;
            this.takenstunum.HeaderText = "已选人数";
            this.takenstunum.Name = "takenstunum";
            this.takenstunum.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(687, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "其它";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 252);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.groupBox1.Location = new System.Drawing.Point(302, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_renewpasswd
            // 
            this.tb_renewpasswd.Location = new System.Drawing.Point(124, 125);
            this.tb_renewpasswd.Name = "tb_renewpasswd";
            this.tb_renewpasswd.PasswordChar = '*';
            this.tb_renewpasswd.Size = new System.Drawing.Size(156, 21);
            this.tb_renewpasswd.TabIndex = 5;
            // 
            // tb_newpasswd
            // 
            this.tb_newpasswd.Location = new System.Drawing.Point(124, 90);
            this.tb_newpasswd.Name = "tb_newpasswd";
            this.tb_newpasswd.PasswordChar = '*';
            this.tb_newpasswd.Size = new System.Drawing.Size(156, 21);
            this.tb_newpasswd.TabIndex = 4;
            // 
            // tb_originpasswd
            // 
            this.tb_originpasswd.Location = new System.Drawing.Point(124, 55);
            this.tb_originpasswd.Name = "tb_originpasswd";
            this.tb_originpasswd.PasswordChar = '*';
            this.tb_originpasswd.Size = new System.Drawing.Size(156, 21);
            this.tb_originpasswd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次输入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(458, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 148);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
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
            this.Text = "欢迎使用选课系统 - 教师后台";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmTeacherMain_FormClosed);
            this.Load += new System.EventHandler(this.FmTeacherMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewComboBoxColumn week;
        private System.Windows.Forms.DataGridViewComboBoxColumn section;
        private System.Windows.Forms.DataGridViewComboBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn precourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxstu;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenstunum;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}