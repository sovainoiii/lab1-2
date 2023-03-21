namespace lab1
{
    partial class Form4
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
            this.lsbClasses = new System.Windows.Forms.ListBox();
            this.lsvStudents = new System.Windows.Forms.ListView();
            this.lblClasses = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsbClasses
            // 
            this.lsbClasses.FormattingEnabled = true;
            this.lsbClasses.ItemHeight = 16;
            this.lsbClasses.Location = new System.Drawing.Point(20, 90);
            this.lsbClasses.Name = "lsbClasses";
            this.lsbClasses.Size = new System.Drawing.Size(257, 292);
            this.lsbClasses.TabIndex = 0;
            this.lsbClasses.SelectedIndexChanged += new System.EventHandler(this.lsbClasses_SelectedIndexChanged);
            // 
            // lsvStudents
            // 
            this.lsvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.name,
            this.classID});
            this.lsvStudents.HideSelection = false;
            this.lsvStudents.Location = new System.Drawing.Point(308, 90);
            this.lsvStudents.Name = "lsvStudents";
            this.lsvStudents.Size = new System.Drawing.Size(455, 291);
            this.lsvStudents.TabIndex = 1;
            this.lsvStudents.UseCompatibleStateImageBehavior = false;
            this.lsvStudents.View = System.Windows.Forms.View.Details;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasses.Location = new System.Drawing.Point(66, 51);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(154, 25);
            this.lblClasses.TabIndex = 2;
            this.lblClasses.Text = "List of Classes";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(468, 51);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(162, 25);
            this.lblStudents.TabIndex = 3;
            this.lblStudents.Text = "List of Students";
            // 
            // studentID
            // 
            this.studentID.Text = "Student ID";
            this.studentID.Width = 90;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 180;
            // 
            // classID
            // 
            this.classID.Text = "Class ID";
            this.classID.Width = 70;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.lsvStudents);
            this.Controls.Add(this.lsbClasses);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbClasses;
        private System.Windows.Forms.ListView lsvStudents;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader classID;
    }
}