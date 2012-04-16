namespace CourseSelectionSystem
{
    partial class FmAdminMain
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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.tb_renewpasswd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_newpasswd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_originPasswd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            this.tabPage1.Text = "系统管理主页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "课程管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button13);
            this.tabPage6.Controls.Add(this.button12);
            this.tabPage6.Controls.Add(this.button11);
            this.tabPage6.Controls.Add(this.button10);
            this.tabPage6.Controls.Add(this.dataGridView2);
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(687, 393);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "教师管理";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(572, 356);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 29);
            this.button13.TabIndex = 4;
            this.button13.Text = "刷新列表";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(223, 356);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 29);
            this.button12.TabIndex = 3;
            this.button12.Text = "修改所选";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(117, 356);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 29);
            this.button11.TabIndex = 2;
            this.button11.Text = "删除所选";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(11, 356);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 29);
            this.button10.TabIndex = 1;
            this.button10.Text = "新增教师";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(660, 333);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.checkedListBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(687, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "公告管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(135, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "请点击右侧“刷新列表”读取公告列表";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(570, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "刷新列表";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(570, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "修改选中";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "删除选中";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(568, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "公告管理";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "已发布的公告列表（双击打开公告内容）";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "发布公告";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(18, 37);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(534, 338);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(687, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "学生管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(223, 356);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 29);
            this.button8.TabIndex = 4;
            this.button8.Text = "修改选中";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(117, 356);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 29);
            this.button7.TabIndex = 3;
            this.button7.Text = "删除所选";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(574, 356);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = "刷新列表";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.stunum,
            this.sname,
            this.gender,
            this.startyear,
            this.collegeid});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 333);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加学生";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(687, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "其它";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.tb_renewpasswd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_newpasswd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_originPasswd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(49, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(89, 177);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 31);
            this.button9.TabIndex = 6;
            this.button9.Text = "确认修改";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tb_renewpasswd
            // 
            this.tb_renewpasswd.Location = new System.Drawing.Point(84, 115);
            this.tb_renewpasswd.Name = "tb_renewpasswd";
            this.tb_renewpasswd.Size = new System.Drawing.Size(143, 21);
            this.tb_renewpasswd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "再次输入";
            // 
            // tb_newpasswd
            // 
            this.tb_newpasswd.Location = new System.Drawing.Point(84, 77);
            this.tb_newpasswd.Name = "tb_newpasswd";
            this.tb_newpasswd.Size = new System.Drawing.Size(143, 21);
            this.tb_newpasswd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "新密码";
            // 
            // tb_originPasswd
            // 
            this.tb_originPasswd.Location = new System.Drawing.Point(84, 39);
            this.tb_originPasswd.Name = "tb_originPasswd";
            this.tb_originPasswd.Size = new System.Drawing.Size(143, 21);
            this.tb_originPasswd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "原密码";
            // 
            // sid
            // 
            this.sid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sid.DataPropertyName = "sid";
            this.sid.HeaderText = "序号";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stunum
            // 
            this.stunum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stunum.DataPropertyName = "stunum";
            this.stunum.HeaderText = "学号";
            this.stunum.Name = "stunum";
            // 
            // sname
            // 
            this.sname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sname.DataPropertyName = "sname";
            this.sname.HeaderText = "姓名";
            this.sname.Name = "sname";
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // startyear
            // 
            this.startyear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startyear.DataPropertyName = "startyear";
            this.startyear.HeaderText = "入学年份";
            this.startyear.Name = "startyear";
            // 
            // collegeid
            // 
            this.collegeid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collegeid.DataPropertyName = "collegeid";
            this.collegeid.HeaderText = "学院";
            this.collegeid.Name = "collegeid";
            // 
            // FmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 455);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用选课系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmAdminMain_FormClosed);
            this.Load += new System.EventHandler(this.FmAdminMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_renewpasswd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_newpasswd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_originPasswd;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunum;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn startyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeid;
    }
}