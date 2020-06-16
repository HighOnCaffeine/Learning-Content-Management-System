namespace WindowsFormsApplication1
{
    partial class generateReport
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbleSU = new System.Windows.Forms.Label();
            this.lblelcms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Student Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Teacher Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbleSU
            // 
            this.lbleSU.AutoSize = true;
            this.lbleSU.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleSU.Location = new System.Drawing.Point(172, 63);
            this.lbleSU.Name = "lbleSU";
            this.lbleSU.Size = new System.Drawing.Size(124, 12);
            this.lbleSU.TabIndex = 35;
            this.lbleSU.Text = "Sample university";
            // 
            // lblelcms
            // 
            this.lblelcms.AutoSize = true;
            this.lblelcms.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelcms.Location = new System.Drawing.Point(189, 23);
            this.lblelcms.Name = "lblelcms";
            this.lblelcms.Size = new System.Drawing.Size(85, 26);
            this.lblelcms.TabIndex = 34;
            this.lblelcms.Text = "LCMS";
            // 
            // generateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 368);
            this.Controls.Add(this.lbleSU);
            this.Controls.Add(this.lblelcms);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "generateReport";
            this.Text = "generateReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbleSU;
        private System.Windows.Forms.Label lblelcms;
    }
}