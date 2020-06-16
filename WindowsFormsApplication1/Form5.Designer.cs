namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.btnSetFine = new System.Windows.Forms.Button();
            this.btnAppRequest = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbleSU
            // 
            this.lbleSU.AutoSize = true;
            this.lbleSU.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleSU.Location = new System.Drawing.Point(25, 59);
            this.lbleSU.Name = "lbleSU";
            this.lbleSU.Size = new System.Drawing.Size(124, 12);
            this.lbleSU.TabIndex = 19;
            this.lbleSU.Text = "Sample university";
            // 
            // lblelcms
            // 
            this.lblelcms.AutoSize = true;
            this.lblelcms.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelcms.Location = new System.Drawing.Point(42, 19);
            this.lblelcms.Name = "lblelcms";
            this.lblelcms.Size = new System.Drawing.Size(85, 26);
            this.lblelcms.TabIndex = 18;
            this.lblelcms.Text = "LCMS";
            // 
            // btnSetFine
            // 
            this.btnSetFine.Location = new System.Drawing.Point(16, 211);
            this.btnSetFine.Name = "btnSetFine";
            this.btnSetFine.Size = new System.Drawing.Size(150, 50);
            this.btnSetFine.TabIndex = 17;
            this.btnSetFine.Text = "Set Fines";
            this.btnSetFine.UseVisualStyleBackColor = true;
            // 
            // btnAppRequest
            // 
            this.btnAppRequest.Location = new System.Drawing.Point(16, 155);
            this.btnAppRequest.Name = "btnAppRequest";
            this.btnAppRequest.Size = new System.Drawing.Size(150, 50);
            this.btnAppRequest.TabIndex = 16;
            this.btnAppRequest.Text = "Application Request";
            this.btnAppRequest.UseVisualStyleBackColor = true;
            this.btnAppRequest.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(16, 99);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(150, 50);
            this.btnAddStudent.TabIndex = 15;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(531, 51);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(93, 26);
            this.btnEditProfile.TabIndex = 30;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(531, 19);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 26);
            this.btnLogOut.TabIndex = 29;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 421);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lbleSU);
            this.Controls.Add(this.lblelcms);
            this.Controls.Add(this.btnSetFine);
            this.Controls.Add(this.btnAppRequest);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbleSU;
        private System.Windows.Forms.Label lblelcms;
        private System.Windows.Forms.Button btnSetFine;
        private System.Windows.Forms.Button btnAppRequest;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnLogOut;
    }
}