namespace AD_Project_FinalVers
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBUserName = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(38, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 10);
            this.panel2.TabIndex = 22;
            // 
            // tBPassword
            // 
            this.tBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tBPassword.Location = new System.Drawing.Point(83, 224);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '•';
            this.tBPassword.Size = new System.Drawing.Size(281, 21);
            this.tBPassword.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(38, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 10);
            this.panel1.TabIndex = 20;
            // 
            // tBUserName
            // 
            this.tBUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUserName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tBUserName.Location = new System.Drawing.Point(83, 161);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.Size = new System.Drawing.Size(281, 21);
            this.tBUserName.TabIndex = 19;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(38, 316);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(326, 50);
            this.btnLogIn.TabIndex = 18;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(28, 84);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(346, 26);
            this.lblWelcome.TabIndex = 17;
            this.lblWelcome.Text = "Welcome to Student Housing BV";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AD_Project_FinalVers.Properties.Resources._61457;
            this.pictureBox2.Location = new System.Drawing.Point(38, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AD_Project_FinalVers.Properties.Resources.usericon;
            this.pictureBox1.Location = new System.Drawing.Point(38, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tBUserName);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBUserName;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

