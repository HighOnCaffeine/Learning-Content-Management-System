namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.lbleSU = new System.Windows.Forms.Label();
            this.lblelcms = new System.Windows.Forms.Label();
            this.btnGenerateRep = new System.Windows.Forms.Button();
            this.btnGenerateChallan = new System.Windows.Forms.Button();
            this.btnSetFine = new System.Windows.Forms.Button();
            this.btnSetTimeTbale = new System.Windows.Forms.Button();
            this.btnStudentAtt = new System.Windows.Forms.Button();
            this.btnDateSheet = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnCreateCourse = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbleSU
            // 
            this.lbleSU.AutoSize = true;
            this.lbleSU.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleSU.Location = new System.Drawing.Point(19, 68);
            this.lbleSU.Name = "lbleSU";
            this.lbleSU.Size = new System.Drawing.Size(124, 12);
            this.lbleSU.TabIndex = 14;
            this.lbleSU.Text = "Sample university";
            // 
            // lblelcms
            // 
            this.lblelcms.AutoSize = true;
            this.lblelcms.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelcms.Location = new System.Drawing.Point(36, 28);
            this.lblelcms.Name = "lblelcms";
            this.lblelcms.Size = new System.Drawing.Size(85, 26);
            this.lblelcms.TabIndex = 13;
            this.lblelcms.Text = "LCMS";
            this.lblelcms.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerateRep
            // 
            this.btnGenerateRep.Location = new System.Drawing.Point(10, 444);
            this.btnGenerateRep.Name = "btnGenerateRep";
            this.btnGenerateRep.Size = new System.Drawing.Size(150, 50);
            this.btnGenerateRep.TabIndex = 12;
            this.btnGenerateRep.Text = "Generate Report";
            this.btnGenerateRep.UseVisualStyleBackColor = true;
            this.btnGenerateRep.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnGenerateChallan
            // 
            this.btnGenerateChallan.Location = new System.Drawing.Point(10, 388);
            this.btnGenerateChallan.Name = "btnGenerateChallan";
            this.btnGenerateChallan.Size = new System.Drawing.Size(150, 50);
            this.btnGenerateChallan.TabIndex = 11;
            this.btnGenerateChallan.Text = "Generate Challan";
            this.btnGenerateChallan.UseVisualStyleBackColor = true;
            this.btnGenerateChallan.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSetFine
            // 
            this.btnSetFine.Location = new System.Drawing.Point(10, 220);
            this.btnSetFine.Name = "btnSetFine";
            this.btnSetFine.Size = new System.Drawing.Size(150, 50);
            this.btnSetFine.TabIndex = 10;
            this.btnSetFine.Text = "Set Fines";
            this.btnSetFine.UseVisualStyleBackColor = true;
            // 
            // btnSetTimeTbale
            // 
            this.btnSetTimeTbale.Location = new System.Drawing.Point(10, 164);
            this.btnSetTimeTbale.Name = "btnSetTimeTbale";
            this.btnSetTimeTbale.Size = new System.Drawing.Size(150, 50);
            this.btnSetTimeTbale.TabIndex = 9;
            this.btnSetTimeTbale.Text = "Set Time Table";
            this.btnSetTimeTbale.UseVisualStyleBackColor = true;
            // 
            // btnStudentAtt
            // 
            this.btnStudentAtt.Location = new System.Drawing.Point(10, 108);
            this.btnStudentAtt.Name = "btnStudentAtt";
            this.btnStudentAtt.Size = new System.Drawing.Size(150, 50);
            this.btnStudentAtt.TabIndex = 8;
            this.btnStudentAtt.Text = "Student Attendance";
            this.btnStudentAtt.UseVisualStyleBackColor = true;
            // 
            // btnDateSheet
            // 
            this.btnDateSheet.Location = new System.Drawing.Point(10, 332);
            this.btnDateSheet.Name = "btnDateSheet";
            this.btnDateSheet.Size = new System.Drawing.Size(150, 50);
            this.btnDateSheet.TabIndex = 15;
            this.btnDateSheet.Text = "Set Date Sheet";
            this.btnDateSheet.UseVisualStyleBackColor = true;
            this.btnDateSheet.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(10, 500);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(150, 50);
            this.btnInbox.TabIndex = 16;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Location = new System.Drawing.Point(10, 276);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(150, 50);
            this.btnCreateCourse.TabIndex = 17;
            this.btnCreateCourse.Text = "Create Courses";
            this.btnCreateCourse.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(540, 60);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(93, 26);
            this.btnEditProfile.TabIndex = 19;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(540, 28);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 26);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 553);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCreateCourse);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnDateSheet);
            this.Controls.Add(this.lbleSU);
            this.Controls.Add(this.lblelcms);
            this.Controls.Add(this.btnGenerateRep);
            this.Controls.Add(this.btnGenerateChallan);
            this.Controls.Add(this.btnSetFine);
            this.Controls.Add(this.btnSetTimeTbale);
            this.Controls.Add(this.btnStudentAtt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbleSU;
        private System.Windows.Forms.Label lblelcms;
        private System.Windows.Forms.Button btnGenerateRep;
        private System.Windows.Forms.Button btnGenerateChallan;
        private System.Windows.Forms.Button btnSetFine;
        private System.Windows.Forms.Button btnSetTimeTbale;
        private System.Windows.Forms.Button btnStudentAtt;
        private System.Windows.Forms.Button btnDateSheet;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnCreateCourse;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnLogOut;
    }
}