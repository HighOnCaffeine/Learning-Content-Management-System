namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.LbleEmail = new System.Windows.Forms.Label();
            this.Lblepassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.LLforgetpass = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(322, 177);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(272, 29);
            this.tbemail.TabIndex = 0;
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(322, 225);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(272, 29);
            this.tbpassword.TabIndex = 1;
            // 
            // LbleEmail
            // 
            this.LbleEmail.AutoSize = true;
            this.LbleEmail.ForeColor = System.Drawing.Color.White;
            this.LbleEmail.Location = new System.Drawing.Point(319, 161);
            this.LbleEmail.Name = "LbleEmail";
            this.LbleEmail.Size = new System.Drawing.Size(32, 13);
            this.LbleEmail.TabIndex = 2;
            this.LbleEmail.Text = "Email";
            this.LbleEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblepassword
            // 
            this.Lblepassword.AutoSize = true;
            this.Lblepassword.ForeColor = System.Drawing.Color.White;
            this.Lblepassword.Location = new System.Drawing.Point(319, 209);
            this.Lblepassword.Name = "Lblepassword";
            this.Lblepassword.Size = new System.Drawing.Size(53, 13);
            this.Lblepassword.TabIndex = 3;
            this.Lblepassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlogin.FlatAppearance.BorderSize = 2;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogin.Location = new System.Drawing.Point(322, 269);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(272, 53);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // LLforgetpass
            // 
            this.LLforgetpass.AutoSize = true;
            this.LLforgetpass.LinkColor = System.Drawing.Color.White;
            this.LLforgetpass.Location = new System.Drawing.Point(502, 325);
            this.LLforgetpass.Name = "LLforgetpass";
            this.LLforgetpass.Size = new System.Drawing.Size(92, 13);
            this.LLforgetpass.TabIndex = 7;
            this.LLforgetpass.TabStop = true;
            this.LLforgetpass.Text = "Forget Password?";
            this.LLforgetpass.VisitedLinkColor = System.Drawing.Color.White;
            this.LLforgetpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 483);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.tbpassword);
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.LLforgetpass);
            this.panel2.Controls.Add(this.Lblepassword);
            this.panel2.Controls.Add(this.tbemail);
            this.panel2.Controls.Add(this.LbleEmail);
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 480);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(35, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleName = "login_form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label LbleEmail;
        private System.Windows.Forms.Label Lblepassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel LLforgetpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

