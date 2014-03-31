namespace University_Chooser
{
    partial class CourseFinder
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
            this.lvCourses = new System.Windows.Forms.ListView();
            this.chCourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPersonal = new System.Windows.Forms.CheckBox();
            this.cbResources = new System.Windows.Forms.CheckBox();
            this.cbManagement = new System.Windows.Forms.CheckBox();
            this.cbSupport = new System.Windows.Forms.CheckBox();
            this.cbFeedback = new System.Windows.Forms.CheckBox();
            this.cbTeacher = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoUni = new System.Windows.Forms.Button();
            this.lvAlternatives = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOverallSat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMoreInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUcas = new System.Windows.Forms.Label();
            this.lblUniversityName = new System.Windows.Forms.Label();
            this.lblOverall = new System.Windows.Forms.Label();
            this.tbPersonalSat = new System.Windows.Forms.TextBox();
            this.tbResourcesSat = new System.Windows.Forms.TextBox();
            this.tbManagementSat = new System.Windows.Forms.TextBox();
            this.tbSupportSat = new System.Windows.Forms.TextBox();
            this.tbFeedbackSat = new System.Windows.Forms.TextBox();
            this.tbTeachingSat = new System.Windows.Forms.TextBox();
            this.cbLimiter = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCourses
            // 
            this.lvCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCourseName});
            this.lvCourses.FullRowSelect = true;
            this.lvCourses.GridLines = true;
            this.lvCourses.Location = new System.Drawing.Point(12, 39);
            this.lvCourses.Name = "lvCourses";
            this.lvCourses.Size = new System.Drawing.Size(245, 397);
            this.lvCourses.TabIndex = 0;
            this.lvCourses.UseCompatibleStateImageBehavior = false;
            this.lvCourses.View = System.Windows.Forms.View.Details;
            this.lvCourses.SelectedIndexChanged += new System.EventHandler(this.lvCourses_SelectedIndexChanged);
            // 
            // chCourseName
            // 
            this.chCourseName.Text = "Name";
            this.chCourseName.Width = 219;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPersonal);
            this.groupBox1.Controls.Add(this.cbResources);
            this.groupBox1.Controls.Add(this.cbManagement);
            this.groupBox1.Controls.Add(this.cbSupport);
            this.groupBox1.Controls.Add(this.cbFeedback);
            this.groupBox1.Controls.Add(this.cbTeacher);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGoUni);
            this.groupBox1.Controls.Add(this.lvAlternatives);
            this.groupBox1.Controls.Add(this.lblUcas);
            this.groupBox1.Controls.Add(this.lblUniversityName);
            this.groupBox1.Controls.Add(this.lblOverall);
            this.groupBox1.Controls.Add(this.tbPersonalSat);
            this.groupBox1.Controls.Add(this.tbResourcesSat);
            this.groupBox1.Controls.Add(this.tbManagementSat);
            this.groupBox1.Controls.Add(this.tbSupportSat);
            this.groupBox1.Controls.Add(this.tbFeedbackSat);
            this.groupBox1.Controls.Add(this.tbTeachingSat);
            this.groupBox1.Location = new System.Drawing.Point(265, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 424);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suggested University";
            // 
            // cbPersonal
            // 
            this.cbPersonal.AutoSize = true;
            this.cbPersonal.Checked = true;
            this.cbPersonal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPersonal.Location = new System.Drawing.Point(6, 252);
            this.cbPersonal.Name = "cbPersonal";
            this.cbPersonal.Size = new System.Drawing.Size(15, 14);
            this.cbPersonal.TabIndex = 26;
            this.cbPersonal.UseVisualStyleBackColor = true;
            // 
            // cbResources
            // 
            this.cbResources.AutoSize = true;
            this.cbResources.Checked = true;
            this.cbResources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbResources.Location = new System.Drawing.Point(6, 223);
            this.cbResources.Name = "cbResources";
            this.cbResources.Size = new System.Drawing.Size(15, 14);
            this.cbResources.TabIndex = 25;
            this.cbResources.UseVisualStyleBackColor = true;
            // 
            // cbManagement
            // 
            this.cbManagement.AutoSize = true;
            this.cbManagement.Checked = true;
            this.cbManagement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbManagement.Location = new System.Drawing.Point(6, 194);
            this.cbManagement.Name = "cbManagement";
            this.cbManagement.Size = new System.Drawing.Size(15, 14);
            this.cbManagement.TabIndex = 24;
            this.cbManagement.UseVisualStyleBackColor = true;
            // 
            // cbSupport
            // 
            this.cbSupport.AutoSize = true;
            this.cbSupport.Checked = true;
            this.cbSupport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSupport.Location = new System.Drawing.Point(6, 165);
            this.cbSupport.Name = "cbSupport";
            this.cbSupport.Size = new System.Drawing.Size(15, 14);
            this.cbSupport.TabIndex = 23;
            this.cbSupport.UseVisualStyleBackColor = true;
            // 
            // cbFeedback
            // 
            this.cbFeedback.AutoSize = true;
            this.cbFeedback.Checked = true;
            this.cbFeedback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFeedback.Location = new System.Drawing.Point(6, 136);
            this.cbFeedback.Name = "cbFeedback";
            this.cbFeedback.Size = new System.Drawing.Size(15, 14);
            this.cbFeedback.TabIndex = 22;
            this.cbFeedback.UseVisualStyleBackColor = true;
            // 
            // cbTeacher
            // 
            this.cbTeacher.AutoSize = true;
            this.cbTeacher.Checked = true;
            this.cbTeacher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTeacher.Location = new System.Drawing.Point(6, 107);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(15, 14);
            this.cbTeacher.TabIndex = 21;
            this.cbTeacher.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Alternatives:";
            // 
            // btnGoUni
            // 
            this.btnGoUni.Location = new System.Drawing.Point(325, 75);
            this.btnGoUni.Name = "btnGoUni";
            this.btnGoUni.Size = new System.Drawing.Size(37, 23);
            this.btnGoUni.TabIndex = 19;
            this.btnGoUni.Text = "Go";
            this.btnGoUni.UseVisualStyleBackColor = true;
            this.btnGoUni.Click += new System.EventHandler(this.btnGoUni_Click);
            // 
            // lvAlternatives
            // 
            this.lvAlternatives.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chOverallSat,
            this.chMoreInfo});
            this.lvAlternatives.FullRowSelect = true;
            this.lvAlternatives.GridLines = true;
            this.lvAlternatives.Location = new System.Drawing.Point(6, 294);
            this.lvAlternatives.Name = "lvAlternatives";
            this.lvAlternatives.Size = new System.Drawing.Size(356, 124);
            this.lvAlternatives.TabIndex = 18;
            this.lvAlternatives.UseCompatibleStateImageBehavior = false;
            this.lvAlternatives.View = System.Windows.Forms.View.Details;
            this.lvAlternatives.DoubleClick += new System.EventHandler(this.lvAlternatives_DoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 142;
            // 
            // chOverallSat
            // 
            this.chOverallSat.Text = "Overall Satisfaction";
            this.chOverallSat.Width = 109;
            // 
            // chMoreInfo
            // 
            this.chMoreInfo.Text = "Website";
            this.chMoreInfo.Width = 93;
            // 
            // lblUcas
            // 
            this.lblUcas.AutoSize = true;
            this.lblUcas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcas.Location = new System.Drawing.Point(6, 75);
            this.lblUcas.Name = "lblUcas";
            this.lblUcas.Size = new System.Drawing.Size(106, 18);
            this.lblUcas.TabIndex = 17;
            this.lblUcas.Text = "UCAS Code:";
            // 
            // lblUniversityName
            // 
            this.lblUniversityName.AutoSize = true;
            this.lblUniversityName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversityName.Location = new System.Drawing.Point(6, 16);
            this.lblUniversityName.Name = "lblUniversityName";
            this.lblUniversityName.Size = new System.Drawing.Size(95, 18);
            this.lblUniversityName.TabIndex = 16;
            this.lblUniversityName.Text = "University";
            // 
            // lblOverall
            // 
            this.lblOverall.AutoSize = true;
            this.lblOverall.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverall.Location = new System.Drawing.Point(6, 47);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(176, 18);
            this.lblOverall.TabIndex = 15;
            this.lblOverall.Text = "Overall Satisfaction:";
            // 
            // tbPersonalSat
            // 
            this.tbPersonalSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonalSat.Location = new System.Drawing.Point(27, 247);
            this.tbPersonalSat.Name = "tbPersonalSat";
            this.tbPersonalSat.ReadOnly = true;
            this.tbPersonalSat.Size = new System.Drawing.Size(335, 23);
            this.tbPersonalSat.TabIndex = 14;
            this.tbPersonalSat.Text = "Personal Devleopment Satisfaction:";
            // 
            // tbResourcesSat
            // 
            this.tbResourcesSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResourcesSat.Location = new System.Drawing.Point(27, 218);
            this.tbResourcesSat.Name = "tbResourcesSat";
            this.tbResourcesSat.ReadOnly = true;
            this.tbResourcesSat.Size = new System.Drawing.Size(335, 23);
            this.tbResourcesSat.TabIndex = 13;
            this.tbResourcesSat.Text = "Resources Satisfaction:";
            // 
            // tbManagementSat
            // 
            this.tbManagementSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagementSat.Location = new System.Drawing.Point(27, 189);
            this.tbManagementSat.Name = "tbManagementSat";
            this.tbManagementSat.ReadOnly = true;
            this.tbManagementSat.Size = new System.Drawing.Size(335, 23);
            this.tbManagementSat.TabIndex = 12;
            this.tbManagementSat.Text = "Management Satisfaction:";
            // 
            // tbSupportSat
            // 
            this.tbSupportSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupportSat.Location = new System.Drawing.Point(27, 160);
            this.tbSupportSat.Name = "tbSupportSat";
            this.tbSupportSat.ReadOnly = true;
            this.tbSupportSat.Size = new System.Drawing.Size(335, 23);
            this.tbSupportSat.TabIndex = 11;
            this.tbSupportSat.Text = "Support Satisfaction:";
            // 
            // tbFeedbackSat
            // 
            this.tbFeedbackSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFeedbackSat.Location = new System.Drawing.Point(27, 131);
            this.tbFeedbackSat.Name = "tbFeedbackSat";
            this.tbFeedbackSat.ReadOnly = true;
            this.tbFeedbackSat.Size = new System.Drawing.Size(335, 23);
            this.tbFeedbackSat.TabIndex = 10;
            this.tbFeedbackSat.Text = "Feedback Satisfaction:";
            // 
            // tbTeachingSat
            // 
            this.tbTeachingSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeachingSat.Location = new System.Drawing.Point(27, 102);
            this.tbTeachingSat.Name = "tbTeachingSat";
            this.tbTeachingSat.ReadOnly = true;
            this.tbTeachingSat.Size = new System.Drawing.Size(335, 23);
            this.tbTeachingSat.TabIndex = 9;
            this.tbTeachingSat.Text = "Teaching Satisfaction:";
            // 
            // cbLimiter
            // 
            this.cbLimiter.FormattingEnabled = true;
            this.cbLimiter.Items.AddRange(new object[] {
            "Science",
            "Computer",
            "Biology",
            "Chemistry",
            "Mathematics",
            "Statistics",
            "English",
            "Agriculture",
            "Maritime"});
            this.cbLimiter.Location = new System.Drawing.Point(12, 12);
            this.cbLimiter.Name = "cbLimiter";
            this.cbLimiter.Size = new System.Drawing.Size(148, 21);
            this.cbLimiter.TabIndex = 3;
            this.cbLimiter.Text = "Select a field..";
            this.cbLimiter.SelectedIndexChanged += new System.EventHandler(this.cbLimiter_SelectedIndexChanged);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(167, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(90, 21);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // CourseFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 448);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.cbLimiter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CourseFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseFinder";
            this.Load += new System.EventHandler(this.CourseFinder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCourses;
        private System.Windows.Forms.ColumnHeader chCourseName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUniversityName;
        private System.Windows.Forms.Label lblOverall;
        private System.Windows.Forms.TextBox tbPersonalSat;
        private System.Windows.Forms.TextBox tbResourcesSat;
        private System.Windows.Forms.TextBox tbManagementSat;
        private System.Windows.Forms.TextBox tbSupportSat;
        private System.Windows.Forms.TextBox tbFeedbackSat;
        private System.Windows.Forms.TextBox tbTeachingSat;
        private System.Windows.Forms.Label lblUcas;
        private System.Windows.Forms.ListView lvAlternatives;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chOverallSat;
        private System.Windows.Forms.Button btnGoUni;
        private System.Windows.Forms.ColumnHeader chMoreInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLimiter;
        private System.Windows.Forms.CheckBox cbPersonal;
        private System.Windows.Forms.CheckBox cbResources;
        private System.Windows.Forms.CheckBox cbManagement;
        private System.Windows.Forms.CheckBox cbSupport;
        private System.Windows.Forms.CheckBox cbFeedback;
        private System.Windows.Forms.CheckBox cbTeacher;
        private System.Windows.Forms.Button btnAll;
    }
}