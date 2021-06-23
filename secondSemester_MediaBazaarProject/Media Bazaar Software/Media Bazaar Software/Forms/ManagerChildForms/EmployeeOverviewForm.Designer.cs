
namespace Media_Bazaar_Software.UI.ManagerChildForms
{
    partial class ScheduleCreatorForm
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
            this.gbOverviewEmployees = new System.Windows.Forms.GroupBox();
            this.btnOverviewEmployees = new System.Windows.Forms.Button();
            this.lbOverviewOfEmployees = new System.Windows.Forms.ListBox();
            this.btnSetShift = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtShiftEnd = new System.Windows.Forms.DateTimePicker();
            this.mCShiftDate = new System.Windows.Forms.MonthCalendar();
            this.dtShiftStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmployeeId = new System.Windows.Forms.TextBox();
            this.btnViewAvailability = new System.Windows.Forms.Button();
            this.gbOverviewEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOverviewEmployees
            // 
            this.gbOverviewEmployees.Controls.Add(this.btnOverviewEmployees);
            this.gbOverviewEmployees.Controls.Add(this.lbOverviewOfEmployees);
            this.gbOverviewEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOverviewEmployees.ForeColor = System.Drawing.Color.White;
            this.gbOverviewEmployees.Location = new System.Drawing.Point(13, 14);
            this.gbOverviewEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.gbOverviewEmployees.Name = "gbOverviewEmployees";
            this.gbOverviewEmployees.Padding = new System.Windows.Forms.Padding(4);
            this.gbOverviewEmployees.Size = new System.Drawing.Size(703, 642);
            this.gbOverviewEmployees.TabIndex = 5;
            this.gbOverviewEmployees.TabStop = false;
            this.gbOverviewEmployees.Text = "List of employees";
            // 
            // btnOverviewEmployees
            // 
            this.btnOverviewEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverviewEmployees.ForeColor = System.Drawing.Color.White;
            this.btnOverviewEmployees.Location = new System.Drawing.Point(256, 537);
            this.btnOverviewEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverviewEmployees.Name = "btnOverviewEmployees";
            this.btnOverviewEmployees.Size = new System.Drawing.Size(175, 76);
            this.btnOverviewEmployees.TabIndex = 4;
            this.btnOverviewEmployees.Text = "Show";
            this.btnOverviewEmployees.UseVisualStyleBackColor = true;
            this.btnOverviewEmployees.Click += new System.EventHandler(this.btnOverviewEmployees_Click);
            // 
            // lbOverviewOfEmployees
            // 
            this.lbOverviewOfEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbOverviewOfEmployees.ForeColor = System.Drawing.Color.White;
            this.lbOverviewOfEmployees.FormattingEnabled = true;
            this.lbOverviewOfEmployees.ItemHeight = 31;
            this.lbOverviewOfEmployees.Location = new System.Drawing.Point(8, 66);
            this.lbOverviewOfEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.lbOverviewOfEmployees.Name = "lbOverviewOfEmployees";
            this.lbOverviewOfEmployees.Size = new System.Drawing.Size(685, 438);
            this.lbOverviewOfEmployees.TabIndex = 2;
            // 
            // btnSetShift
            // 
            this.btnSetShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetShift.ForeColor = System.Drawing.Color.White;
            this.btnSetShift.Location = new System.Drawing.Point(1104, 286);
            this.btnSetShift.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetShift.Name = "btnSetShift";
            this.btnSetShift.Size = new System.Drawing.Size(175, 76);
            this.btnSetShift.TabIndex = 13;
            this.btnSetShift.Text = "Set shift";
            this.btnSetShift.UseVisualStyleBackColor = true;
            this.btnSetShift.Click += new System.EventHandler(this.btnSetShift_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(718, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pick a date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1073, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pick a starting time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1073, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pick an ending time";
            // 
            // dtShiftEnd
            // 
            this.dtShiftEnd.CustomFormat = "HH:mm";
            this.dtShiftEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtShiftEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShiftEnd.Location = new System.Drawing.Point(1079, 189);
            this.dtShiftEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtShiftEnd.Name = "dtShiftEnd";
            this.dtShiftEnd.Size = new System.Drawing.Size(164, 38);
            this.dtShiftEnd.TabIndex = 15;
            this.dtShiftEnd.Value = new System.DateTime(2021, 3, 21, 11, 40, 0, 0);
            // 
            // mCShiftDate
            // 
            this.mCShiftDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.mCShiftDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCShiftDate.ForeColor = System.Drawing.Color.White;
            this.mCShiftDate.Location = new System.Drawing.Point(722, 201);
            this.mCShiftDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mCShiftDate.Name = "mCShiftDate";
            this.mCShiftDate.TabIndex = 14;
            this.mCShiftDate.TitleBackColor = System.Drawing.Color.White;
            this.mCShiftDate.TitleForeColor = System.Drawing.Color.White;
            // 
            // dtShiftStart
            // 
            this.dtShiftStart.CustomFormat = "HH:mm";
            this.dtShiftStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShiftStart.Location = new System.Drawing.Point(1079, 74);
            this.dtShiftStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtShiftStart.Name = "dtShiftStart";
            this.dtShiftStart.Size = new System.Drawing.Size(164, 38);
            this.dtShiftStart.TabIndex = 12;
            this.dtShiftStart.Value = new System.DateTime(2021, 3, 21, 11, 40, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(716, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id of employee";
            // 
            // tbEmployeeId
            // 
            this.tbEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmployeeId.Location = new System.Drawing.Point(724, 74);
            this.tbEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmployeeId.Name = "tbEmployeeId";
            this.tbEmployeeId.Size = new System.Drawing.Size(149, 38);
            this.tbEmployeeId.TabIndex = 10;
            // 
            // btnViewAvailability
            // 
            this.btnViewAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewAvailability.ForeColor = System.Drawing.Color.White;
            this.btnViewAvailability.Location = new System.Drawing.Point(740, 513);
            this.btnViewAvailability.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAvailability.Name = "btnViewAvailability";
            this.btnViewAvailability.Size = new System.Drawing.Size(244, 87);
            this.btnViewAvailability.TabIndex = 19;
            this.btnViewAvailability.Text = "View Employee Availability";
            this.btnViewAvailability.UseVisualStyleBackColor = true;
            this.btnViewAvailability.Click += new System.EventHandler(this.btnViewAvailability_Click);
            // 
            // ScheduleCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1351, 766);
            this.Controls.Add(this.btnViewAvailability);
            this.Controls.Add(this.btnSetShift);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtShiftEnd);
            this.Controls.Add(this.mCShiftDate);
            this.Controls.Add(this.dtShiftStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmployeeId);
            this.Controls.Add(this.gbOverviewEmployees);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScheduleCreatorForm";
            this.Text = "ScheduleCreatorForm";
            this.gbOverviewEmployees.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOverviewEmployees;
        private System.Windows.Forms.Button btnOverviewEmployees;
        private System.Windows.Forms.ListBox lbOverviewOfEmployees;
        private System.Windows.Forms.Button btnSetShift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtShiftEnd;
        private System.Windows.Forms.MonthCalendar mCShiftDate;
        private System.Windows.Forms.DateTimePicker dtShiftStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmployeeId;
        private System.Windows.Forms.Button btnViewAvailability;
    }
}