namespace University_Chooser
{
    partial class UniversitySearch
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
            this.lvUniversities = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOverallSatisfaction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbExtraInfo = new System.Windows.Forms.GroupBox();
            this.btnAccomodationShow = new System.Windows.Forms.Button();
            this.lblOverall = new System.Windows.Forms.Label();
            this.lvCourses = new System.Windows.Forms.ListView();
            this.chCourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUcasID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPersonalSat = new System.Windows.Forms.TextBox();
            this.tbResourcesSat = new System.Windows.Forms.TextBox();
            this.tbManagementSat = new System.Windows.Forms.TextBox();
            this.tbSupportSat = new System.Windows.Forms.TextBox();
            this.tbFeedbackSat = new System.Windows.Forms.TextBox();
            this.tbTeachingSat = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fsiSorting = new System.Windows.Forms.ToolStripMenuItem();
            this.msiOverallSat = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCourseFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.gbExtraInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvUniversities
            // 
            this.lvUniversities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chOverallSatisfaction});
            this.lvUniversities.FullRowSelect = true;
            this.lvUniversities.GridLines = true;
            this.lvUniversities.Location = new System.Drawing.Point(14, 27);
            this.lvUniversities.Name = "lvUniversities";
            this.lvUniversities.Size = new System.Drawing.Size(451, 333);
            this.lvUniversities.TabIndex = 0;
            this.lvUniversities.UseCompatibleStateImageBehavior = false;
            this.lvUniversities.View = System.Windows.Forms.View.Details;
            this.lvUniversities.SelectedIndexChanged += new System.EventHandler(this.lvUniversities_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 318;
            // 
            // chOverallSatisfaction
            // 
            this.chOverallSatisfaction.Text = "Overall Satisfaction";
            this.chOverallSatisfaction.Width = 107;
            // 
            // gbExtraInfo
            // 
            this.gbExtraInfo.Controls.Add(this.btnAccomodationShow);
            this.gbExtraInfo.Controls.Add(this.lblOverall);
            this.gbExtraInfo.Controls.Add(this.lvCourses);
            this.gbExtraInfo.Controls.Add(this.tbPersonalSat);
            this.gbExtraInfo.Controls.Add(this.tbResourcesSat);
            this.gbExtraInfo.Controls.Add(this.tbManagementSat);
            this.gbExtraInfo.Controls.Add(this.tbSupportSat);
            this.gbExtraInfo.Controls.Add(this.tbFeedbackSat);
            this.gbExtraInfo.Controls.Add(this.tbTeachingSat);
            this.gbExtraInfo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExtraInfo.Location = new System.Drawing.Point(471, 27);
            this.gbExtraInfo.Name = "gbExtraInfo";
            this.gbExtraInfo.Size = new System.Drawing.Size(724, 333);
            this.gbExtraInfo.TabIndex = 1;
            this.gbExtraInfo.TabStop = false;
            this.gbExtraInfo.Text = "Extra Information";
            // 
            // btnAccomodationShow
            // 
            this.btnAccomodationShow.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccomodationShow.Location = new System.Drawing.Point(171, 214);
            this.btnAccomodationShow.Name = "btnAccomodationShow";
            this.btnAccomodationShow.Size = new System.Drawing.Size(110, 23);
            this.btnAccomodationShow.TabIndex = 10;
            this.btnAccomodationShow.Text = "Accomodation";
            this.btnAccomodationShow.UseVisualStyleBackColor = true;
            this.btnAccomodationShow.Click += new System.EventHandler(this.btnAccomodationShow_Click);
            // 
            // lblOverall
            // 
            this.lblOverall.AutoSize = true;
            this.lblOverall.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverall.Location = new System.Drawing.Point(6, 27);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(176, 18);
            this.lblOverall.TabIndex = 8;
            this.lblOverall.Text = "Overall Satisfaction:";
            // 
            // lvCourses
            // 
            this.lvCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCourseName,
            this.chUcasID});
            this.lvCourses.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lvCourses.FullRowSelect = true;
            this.lvCourses.GridLines = true;
            this.lvCourses.Location = new System.Drawing.Point(287, 28);
            this.lvCourses.Name = "lvCourses";
            this.lvCourses.Size = new System.Drawing.Size(431, 299);
            this.lvCourses.TabIndex = 7;
            this.lvCourses.UseCompatibleStateImageBehavior = false;
            this.lvCourses.View = System.Windows.Forms.View.Details;
            this.lvCourses.DoubleClick += new System.EventHandler(this.lvCourses_DoubleClick);
            // 
            // chCourseName
            // 
            this.chCourseName.Text = "Name";
            this.chCourseName.Width = 294;
            // 
            // chUcasID
            // 
            this.chUcasID.Text = "UCAS Code";
            this.chUcasID.Width = 127;
            // 
            // tbPersonalSat
            // 
            this.tbPersonalSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonalSat.Location = new System.Drawing.Point(6, 185);
            this.tbPersonalSat.Name = "tbPersonalSat";
            this.tbPersonalSat.ReadOnly = true;
            this.tbPersonalSat.Size = new System.Drawing.Size(275, 23);
            this.tbPersonalSat.TabIndex = 6;
            this.tbPersonalSat.Text = "Personal Devleopment Satisfaction:";
            // 
            // tbResourcesSat
            // 
            this.tbResourcesSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResourcesSat.Location = new System.Drawing.Point(6, 159);
            this.tbResourcesSat.Name = "tbResourcesSat";
            this.tbResourcesSat.ReadOnly = true;
            this.tbResourcesSat.Size = new System.Drawing.Size(275, 23);
            this.tbResourcesSat.TabIndex = 5;
            this.tbResourcesSat.Text = "Resources Satisfaction:";
            // 
            // tbManagementSat
            // 
            this.tbManagementSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagementSat.Location = new System.Drawing.Point(6, 133);
            this.tbManagementSat.Name = "tbManagementSat";
            this.tbManagementSat.ReadOnly = true;
            this.tbManagementSat.Size = new System.Drawing.Size(275, 23);
            this.tbManagementSat.TabIndex = 4;
            this.tbManagementSat.Text = "Management Satisfaction:";
            // 
            // tbSupportSat
            // 
            this.tbSupportSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupportSat.Location = new System.Drawing.Point(6, 107);
            this.tbSupportSat.Name = "tbSupportSat";
            this.tbSupportSat.ReadOnly = true;
            this.tbSupportSat.Size = new System.Drawing.Size(275, 23);
            this.tbSupportSat.TabIndex = 3;
            this.tbSupportSat.Text = "Support Satisfaction:";
            // 
            // tbFeedbackSat
            // 
            this.tbFeedbackSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFeedbackSat.Location = new System.Drawing.Point(6, 81);
            this.tbFeedbackSat.Name = "tbFeedbackSat";
            this.tbFeedbackSat.ReadOnly = true;
            this.tbFeedbackSat.Size = new System.Drawing.Size(275, 23);
            this.tbFeedbackSat.TabIndex = 2;
            this.tbFeedbackSat.Text = "Feedback Satisfaction:";
            // 
            // tbTeachingSat
            // 
            this.tbTeachingSat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeachingSat.Location = new System.Drawing.Point(6, 55);
            this.tbTeachingSat.Name = "tbTeachingSat";
            this.tbTeachingSat.ReadOnly = true;
            this.tbTeachingSat.Size = new System.Drawing.Size(275, 23);
            this.tbTeachingSat.TabIndex = 1;
            this.tbTeachingSat.Text = "Teaching Satisfaction:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fsiSorting,
            this.msiCourseFinder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fsiSorting
            // 
            this.fsiSorting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiOverallSat});
            this.fsiSorting.Name = "fsiSorting";
            this.fsiSorting.Size = new System.Drawing.Size(57, 20);
            this.fsiSorting.Text = "Sorting";
            // 
            // msiOverallSat
            // 
            this.msiOverallSat.Name = "msiOverallSat";
            this.msiOverallSat.Size = new System.Drawing.Size(172, 22);
            this.msiOverallSat.Text = "OverallSatisfaction";
            this.msiOverallSat.Click += new System.EventHandler(this.msiOverallSat_Click);
            // 
            // msiCourseFinder
            // 
            this.msiCourseFinder.Name = "msiCourseFinder";
            this.msiCourseFinder.Size = new System.Drawing.Size(92, 20);
            this.msiCourseFinder.Text = "Course Finder";
            this.msiCourseFinder.Click += new System.EventHandler(this.msiCourseFinder_Click);
            // 
            // UniversitySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 372);
            this.Controls.Add(this.gbExtraInfo);
            this.Controls.Add(this.lvUniversities);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UniversitySearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Search";
            this.Load += new System.EventHandler(this.UniversityMain_Load);
            this.gbExtraInfo.ResumeLayout(false);
            this.gbExtraInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUniversities;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chOverallSatisfaction;
        private System.Windows.Forms.GroupBox gbExtraInfo;
        private System.Windows.Forms.TextBox tbSupportSat;
        private System.Windows.Forms.TextBox tbFeedbackSat;
        private System.Windows.Forms.TextBox tbTeachingSat;
        private System.Windows.Forms.TextBox tbManagementSat;
        private System.Windows.Forms.TextBox tbResourcesSat;
        private System.Windows.Forms.TextBox tbPersonalSat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fsiSorting;
        private System.Windows.Forms.ToolStripMenuItem msiOverallSat;
        private System.Windows.Forms.ListView lvCourses;
        private System.Windows.Forms.ColumnHeader chCourseName;
        private System.Windows.Forms.ColumnHeader chUcasID;
        private System.Windows.Forms.Label lblOverall;
        private System.Windows.Forms.ToolStripMenuItem msiCourseFinder;
        private System.Windows.Forms.Button btnAccomodationShow;
    }
}