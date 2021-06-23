
namespace Media_Bazaar_Software.UI.HRChildForms
{
    partial class AddEmployeeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEmployeeType = new System.Windows.Forms.ComboBox();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDepartmentPicker = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.dtEmployeeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewInfo = new System.Windows.Forms.Button();
            this.tbSearchId = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.lbOverview = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEmployeeType);
            this.groupBox1.Controls.Add(this.lblEmployeeType);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblDepartmentPicker);
            this.groupBox1.Controls.Add(this.lblPhoneNum);
            this.groupBox1.Controls.Add(this.cbDepartment);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbPhoneNumber);
            this.groupBox1.Controls.Add(this.dtEmployeeBirthdate);
            this.groupBox1.Controls.Add(this.lblBirthdate);
            this.groupBox1.Controls.Add(this.lblSName);
            this.groupBox1.Controls.Add(this.lblFname);
            this.groupBox1.Controls.Add(this.tbSName);
            this.groupBox1.Controls.Add(this.tbFName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(544, 689);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registering employees";
            // 
            // cbEmployeeType
            // 
            this.cbEmployeeType.FormattingEnabled = true;
            this.cbEmployeeType.Location = new System.Drawing.Point(270, 294);
            this.cbEmployeeType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbEmployeeType.Name = "cbEmployeeType";
            this.cbEmployeeType.Size = new System.Drawing.Size(265, 33);
            this.cbEmployeeType.TabIndex = 16;
            this.cbEmployeeType.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeType_SelectedIndexChanged);
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployeeType.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeType.Location = new System.Drawing.Point(7, 295);
            this.lblEmployeeType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(220, 32);
            this.lblEmployeeType.TabIndex = 15;
            this.lblEmployeeType.Text = "Employee Type:";
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(167, 513);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(177, 71);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(7, 414);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 32);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // lblDepartmentPicker
            // 
            this.lblDepartmentPicker.AutoSize = true;
            this.lblDepartmentPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepartmentPicker.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentPicker.Location = new System.Drawing.Point(7, 352);
            this.lblDepartmentPicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentPicker.Name = "lblDepartmentPicker";
            this.lblDepartmentPicker.Size = new System.Drawing.Size(171, 32);
            this.lblDepartmentPicker.TabIndex = 13;
            this.lblDepartmentPicker.Text = "Department:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneNum.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNum.Location = new System.Drawing.Point(3, 239);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(209, 32);
            this.lblPhoneNum.TabIndex = 11;
            this.lblPhoneNum.Text = "Phone number:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Enabled = false;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(270, 351);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(265, 33);
            this.cbDepartment.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(270, 417);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(265, 30);
            this.tbEmail.TabIndex = 8;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(270, 239);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(265, 30);
            this.tbPhoneNumber.TabIndex = 7;
            // 
            // dtEmployeeBirthdate
            // 
            this.dtEmployeeBirthdate.CustomFormat = "yyyy-MM-dd";
            this.dtEmployeeBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEmployeeBirthdate.Location = new System.Drawing.Point(271, 182);
            this.dtEmployeeBirthdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtEmployeeBirthdate.Name = "dtEmployeeBirthdate";
            this.dtEmployeeBirthdate.Size = new System.Drawing.Size(264, 30);
            this.dtEmployeeBirthdate.TabIndex = 5;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.White;
            this.lblBirthdate.Location = new System.Drawing.Point(7, 182);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(149, 32);
            this.lblBirthdate.TabIndex = 4;
            this.lblBirthdate.Text = "Birth Date:";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSName.ForeColor = System.Drawing.Color.White;
            this.lblSName.Location = new System.Drawing.Point(7, 127);
            this.lblSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(202, 32);
            this.lblSName.TabIndex = 3;
            this.lblSName.Text = "Second Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFname.ForeColor = System.Drawing.Color.White;
            this.lblFname.Location = new System.Drawing.Point(7, 73);
            this.lblFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(160, 32);
            this.lblFname.TabIndex = 2;
            this.lblFname.Text = "First Name:";
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(271, 127);
            this.tbSName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(265, 30);
            this.tbSName.TabIndex = 1;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(271, 75);
            this.tbFName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(265, 30);
            this.tbFName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveAccount);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnViewInfo);
            this.groupBox3.Controls.Add(this.tbSearchId);
            this.groupBox3.Controls.Add(this.lblSearchName);
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.btnSearchName);
            this.groupBox3.Controls.Add(this.lbOverview);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(578, 74);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(837, 689);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overview";
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveAccount.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAccount.Location = new System.Drawing.Point(27, 300);
            this.btnRemoveAccount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(182, 84);
            this.btnRemoveAccount.TabIndex = 18;
            this.btnRemoveAccount.Text = "Remove Account";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Via ID";
            // 
            // btnViewInfo
            // 
            this.btnViewInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewInfo.ForeColor = System.Drawing.Color.White;
            this.btnViewInfo.Location = new System.Drawing.Point(371, 492);
            this.btnViewInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnViewInfo.Name = "btnViewInfo";
            this.btnViewInfo.Size = new System.Drawing.Size(287, 92);
            this.btnViewInfo.TabIndex = 8;
            this.btnViewInfo.Text = "View Information About Employee";
            this.btnViewInfo.UseVisualStyleBackColor = true;
            this.btnViewInfo.Click += new System.EventHandler(this.btnViewInfo_Click);
            // 
            // tbSearchId
            // 
            this.tbSearchId.Location = new System.Drawing.Point(13, 117);
            this.tbSearchId.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbSearchId.Name = "tbSearchId";
            this.tbSearchId.Size = new System.Drawing.Size(224, 30);
            this.tbSearchId.TabIndex = 7;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchName.ForeColor = System.Drawing.Color.White;
            this.lblSearchName.Location = new System.Drawing.Point(56, 31);
            this.lblSearchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(153, 32);
            this.lblSearchName.TabIndex = 5;
            this.lblSearchName.Text = "Search for:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(27, 490);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(182, 94);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchName.ForeColor = System.Drawing.Color.White;
            this.btnSearchName.Location = new System.Drawing.Point(27, 183);
            this.btnSearchName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(182, 88);
            this.btnSearchName.TabIndex = 3;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // lbOverview
            // 
            this.lbOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbOverview.ForeColor = System.Drawing.Color.White;
            this.lbOverview.FormattingEnabled = true;
            this.lbOverview.ItemHeight = 25;
            this.lbOverview.Location = new System.Drawing.Point(245, 31);
            this.lbOverview.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(475, 429);
            this.lbOverview.TabIndex = 0;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1428, 774);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEmployeeType;
        private System.Windows.Forms.Label lblEmployeeType;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDepartmentPicker;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtEmployeeBirthdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewInfo;
        private System.Windows.Forms.TextBox tbSearchId;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.ListBox lbOverview;
    }
}