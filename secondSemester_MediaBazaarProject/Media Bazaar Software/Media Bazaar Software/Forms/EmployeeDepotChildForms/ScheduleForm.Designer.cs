
namespace Media_Bazaar_Software.UI.EmployeeChildForms
{
    partial class Schedule
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
            this.lbShifts = new System.Windows.Forms.ListBox();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.lblWorkingSchedule = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSetPreference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbShifts
            // 
            this.lbShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShifts.ForeColor = System.Drawing.Color.White;
            this.lbShifts.FormattingEnabled = true;
            this.lbShifts.ItemHeight = 36;
            this.lbShifts.Location = new System.Drawing.Point(432, 54);
            this.lbShifts.Margin = new System.Windows.Forms.Padding(4);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(532, 580);
            this.lbShifts.TabIndex = 8;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Location = new System.Drawing.Point(84, 387);
            this.btnViewSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(277, 75);
            this.btnViewSchedule.TabIndex = 7;
            this.btnViewSchedule.Text = "View My Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // lblWorkingSchedule
            // 
            this.lblWorkingSchedule.AutoSize = true;
            this.lblWorkingSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkingSchedule.ForeColor = System.Drawing.Color.White;
            this.lblWorkingSchedule.Location = new System.Drawing.Point(62, 74);
            this.lblWorkingSchedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkingSchedule.Name = "lblWorkingSchedule";
            this.lblWorkingSchedule.Size = new System.Drawing.Size(299, 32);
            this.lblWorkingSchedule.TabIndex = 6;
            this.lblWorkingSchedule.Text = "The working schedule:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Desktop;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.IndianRed;
            this.monthCalendar1.Location = new System.Drawing.Point(84, 117);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            // 
            // btnSetPreference
            // 
            this.btnSetPreference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetPreference.ForeColor = System.Drawing.Color.White;
            this.btnSetPreference.Location = new System.Drawing.Point(84, 487);
            this.btnSetPreference.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPreference.Name = "btnSetPreference";
            this.btnSetPreference.Size = new System.Drawing.Size(277, 75);
            this.btnSetPreference.TabIndex = 9;
            this.btnSetPreference.Text = "Set preference";
            this.btnSetPreference.UseVisualStyleBackColor = true;
            this.btnSetPreference.Click += new System.EventHandler(this.btnSetPreference_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.btnSetPreference);
            this.Controls.Add(this.lbShifts);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.lblWorkingSchedule);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbShifts;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Label lblWorkingSchedule;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSetPreference;
    }
}