
namespace Media_Bazaar_Software.UI.AdministratorChildForms
{
    partial class DepartmentManagment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateDepartment = new System.Windows.Forms.Button();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.tbManagerId = new System.Windows.Forms.TextBox();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnShowDepartment = new System.Windows.Forms.Button();
            this.lbDepartments = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCreateDepartment);
            this.panel1.Controls.Add(this.tbDepartmentName);
            this.panel1.Controls.Add(this.tbManagerId);
            this.panel1.Location = new System.Drawing.Point(741, 347);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 343);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Department name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Manager Id";
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateDepartment.ForeColor = System.Drawing.Color.White;
            this.btnCreateDepartment.Location = new System.Drawing.Point(78, 235);
            this.btnCreateDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(208, 83);
            this.btnCreateDepartment.TabIndex = 3;
            this.btnCreateDepartment.Text = "Create new Department";
            this.btnCreateDepartment.UseVisualStyleBackColor = true;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDepartmentName.Location = new System.Drawing.Point(70, 61);
            this.tbDepartmentName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(216, 38);
            this.tbDepartmentName.TabIndex = 5;
            // 
            // tbManagerId
            // 
            this.tbManagerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbManagerId.Location = new System.Drawing.Point(70, 161);
            this.tbManagerId.Margin = new System.Windows.Forms.Padding(4);
            this.tbManagerId.Name = "tbManagerId";
            this.tbManagerId.Size = new System.Drawing.Size(216, 38);
            this.tbManagerId.TabIndex = 6;
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveDepartment.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDepartment.Location = new System.Drawing.Point(741, 220);
            this.btnRemoveDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(371, 90);
            this.btnRemoveDepartment.TabIndex = 12;
            this.btnRemoveDepartment.Text = "Remove Selected Department";
            this.btnRemoveDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // btnShowDepartment
            // 
            this.btnShowDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowDepartment.ForeColor = System.Drawing.Color.White;
            this.btnShowDepartment.Location = new System.Drawing.Point(741, 150);
            this.btnShowDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDepartment.Name = "btnShowDepartment";
            this.btnShowDepartment.Size = new System.Drawing.Size(371, 53);
            this.btnShowDepartment.TabIndex = 11;
            this.btnShowDepartment.Text = "Show Departments";
            this.btnShowDepartment.UseVisualStyleBackColor = true;
            this.btnShowDepartment.Click += new System.EventHandler(this.btnShowDepartment_Click);
            // 
            // lbDepartments
            // 
            this.lbDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbDepartments.ForeColor = System.Drawing.Color.White;
            this.lbDepartments.FormattingEnabled = true;
            this.lbDepartments.ItemHeight = 38;
            this.lbDepartments.Location = new System.Drawing.Point(13, 116);
            this.lbDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.Size = new System.Drawing.Size(696, 574);
            this.lbDepartments.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Department Managment";
            // 
            // DepartmentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoveDepartment);
            this.Controls.Add(this.btnShowDepartment);
            this.Controls.Add(this.lbDepartments);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentManagment";
            this.Text = "DepartmentManagment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateDepartment;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.TextBox tbManagerId;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnShowDepartment;
        private System.Windows.Forms.ListBox lbDepartments;
        private System.Windows.Forms.Label label3;
    }
}