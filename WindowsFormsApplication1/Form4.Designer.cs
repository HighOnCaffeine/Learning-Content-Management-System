namespace WindowsFormsApplication1
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
            this.btnInbox = new System.Windows.Forms.Button();
            this.lbleSU = new System.Windows.Forms.Label();
            this.lblelcms = new System.Windows.Forms.Label();
            this.btnTimeTable = new System.Windows.Forms.Button();
            this.btnSetAssign = new System.Windows.Forms.Button();
            this.btnAddLecture = new System.Windows.Forms.Button();
            this.btneditprofile = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(13, 267);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(150, 50);
            this.btnInbox.TabIndex = 26;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            // 
            // lbleSU
            // 
            this.lbleSU.AutoSize = true;
            this.lbleSU.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleSU.Location = new System.Drawing.Point(22, 59);
            this.lbleSU.Name = "lbleSU";
            this.lbleSU.Size = new System.Drawing.Size(124, 12);
            this.lbleSU.TabIndex = 24;
            this.lbleSU.Text = "Sample university";
            // 
            // lblelcms
            // 
            this.lblelcms.AutoSize = true;
            this.lblelcms.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelcms.Location = new System.Drawing.Point(39, 19);
            this.lblelcms.Name = "lblelcms";
            this.lblelcms.Size = new System.Drawing.Size(85, 26);
            this.lblelcms.TabIndex = 23;
            this.lblelcms.Text = "LCMS";
            // 
            // btnTimeTable
            // 
            this.btnTimeTable.Location = new System.Drawing.Point(13, 211);
            this.btnTimeTable.Name = "btnTimeTable";
            this.btnTimeTable.Size = new System.Drawing.Size(150, 50);
            this.btnTimeTable.TabIndex = 20;
            this.btnTimeTable.Text = "View Time Table";
            this.btnTimeTable.UseVisualStyleBackColor = true;
            // 
            // btnSetAssign
            // 
            this.btnSetAssign.Location = new System.Drawing.Point(13, 155);
            this.btnSetAssign.Name = "btnSetAssign";
            this.btnSetAssign.Size = new System.Drawing.Size(150, 50);
            this.btnSetAssign.TabIndex = 19;
            this.btnSetAssign.Text = "Set assignment";
            this.btnSetAssign.UseVisualStyleBackColor = true;
            // 
            // btnAddLecture
            // 
            this.btnAddLecture.Location = new System.Drawing.Point(13, 99);
            this.btnAddLecture.Name = "btnAddLecture";
            this.btnAddLecture.Size = new System.Drawing.Size(150, 50);
            this.btnAddLecture.TabIndex = 18;
            this.btnAddLecture.Text = "Add Lecture";
            this.btnAddLecture.UseVisualStyleBackColor = true;
            // 
            // btneditprofile
            // 
            this.btneditprofile.Location = new System.Drawing.Point(470, 51);
            this.btneditprofile.Name = "btneditprofile";
            this.btneditprofile.Size = new System.Drawing.Size(93, 26);
            this.btneditprofile.TabIndex = 28;
            this.btneditprofile.Text = "Edit Profile";
            this.btneditprofile.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(470, 19);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(93, 26);
            this.btnlogout.TabIndex = 27;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.Controls.Add(this.btneditprofile);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.lbleSU);
            this.Controls.Add(this.lblelcms);
            this.Controls.Add(this.btnTimeTable);
            this.Controls.Add(this.btnSetAssign);
            this.Controls.Add(this.btnAddLecture);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Label lbleSU;
        private System.Windows.Forms.Label lblelcms;
        private System.Windows.Forms.Button btnTimeTable;
        private System.Windows.Forms.Button btnSetAssign;
        private System.Windows.Forms.Button btnAddLecture;
        private System.Windows.Forms.Button btneditprofile;
        private System.Windows.Forms.Button btnlogout;
    }
}