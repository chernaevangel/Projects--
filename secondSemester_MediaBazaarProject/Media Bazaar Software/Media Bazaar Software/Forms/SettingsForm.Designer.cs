
namespace Media_Bazaar_Software.UI
{
    partial class SettingsForm
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
            this.btnPassword = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPersonalEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPassword
            // 
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassword.ForeColor = System.Drawing.Color.White;
            this.btnPassword.Location = new System.Drawing.Point(46, 334);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(315, 58);
            this.btnPassword.TabIndex = 32;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 32);
            this.label8.TabIndex = 31;
            this.label8.Text = "New Passport";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Location = new System.Drawing.Point(46, 186);
            this.tbOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(305, 22);
            this.tbOldPassword.TabIndex = 30;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(46, 281);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(305, 22);
            this.tbNewPass.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Old Password";
            // 
            // tbPersonalEmail
            // 
            this.tbPersonalEmail.Location = new System.Drawing.Point(46, 96);
            this.tbPersonalEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbPersonalEmail.Name = "tbPersonalEmail";
            this.tbPersonalEmail.ReadOnly = true;
            this.tbPersonalEmail.Size = new System.Drawing.Size(305, 22);
            this.tbPersonalEmail.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(40, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 32);
            this.label11.TabIndex = 26;
            this.label11.Text = "Email:";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(464, 199);
            this.tbHours.Margin = new System.Windows.Forms.Padding(4);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(217, 22);
            this.tbHours.TabIndex = 35;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(733, 186);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(208, 54);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "How many hours did you work today?";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPersonalEmail);
            this.Controls.Add(this.label11);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPersonalEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
    }
}