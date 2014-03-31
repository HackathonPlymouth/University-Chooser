namespace University_Chooser
{
    partial class Accomodation
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
            this.lvAccomodation = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLowest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHighest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGoWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAccomodation
            // 
            this.lvAccomodation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chLowest,
            this.chHighest});
            this.lvAccomodation.FullRowSelect = true;
            this.lvAccomodation.GridLines = true;
            this.lvAccomodation.Location = new System.Drawing.Point(13, 12);
            this.lvAccomodation.Name = "lvAccomodation";
            this.lvAccomodation.Size = new System.Drawing.Size(317, 134);
            this.lvAccomodation.TabIndex = 0;
            this.lvAccomodation.UseCompatibleStateImageBehavior = false;
            this.lvAccomodation.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 104;
            // 
            // chLowest
            // 
            this.chLowest.Text = "Lower Average";
            this.chLowest.Width = 94;
            // 
            // chHighest
            // 
            this.chHighest.Text = "Highest Average";
            this.chHighest.Width = 100;
            // 
            // btnGoWeb
            // 
            this.btnGoWeb.Location = new System.Drawing.Point(231, 152);
            this.btnGoWeb.Name = "btnGoWeb";
            this.btnGoWeb.Size = new System.Drawing.Size(99, 23);
            this.btnGoWeb.TabIndex = 1;
            this.btnGoWeb.Text = "Go to website";
            this.btnGoWeb.UseVisualStyleBackColor = true;
            this.btnGoWeb.Click += new System.EventHandler(this.btnGoWeb_Click);
            // 
            // Accomodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 187);
            this.Controls.Add(this.btnGoWeb);
            this.Controls.Add(this.lvAccomodation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Accomodation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accomodation";
            this.Load += new System.EventHandler(this.Accomodation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAccomodation;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLowest;
        private System.Windows.Forms.ColumnHeader chHighest;
        private System.Windows.Forms.Button btnGoWeb;
    }
}