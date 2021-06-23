
namespace Media_Bazaar_Software.UI
{
    partial class HRForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddEmployees = new System.Windows.Forms.Button();
            this.ucLoggedUser = new Media_Bazaar_Software.UserControls.UCLoggedUser();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTab = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1732, 37);
            this.panel1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 39);
            this.label1.TabIndex = 60;
            this.label1.Text = "HR";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1664, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 37);
            this.btnMinimize.TabIndex = 59;
            this.btnMinimize.Text = "─";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1697, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 37);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 30;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnAddEmployees);
            this.panelMenu.Controls.Add(this.ucLoggedUser);
            this.panelMenu.Controls.Add(this.btnShowMenu);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 37);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(501, 776);
            this.panelMenu.TabIndex = 61;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Media_Bazaar_Software.Properties.Resources.Windows_Settings_app_icon;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 676);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(506, 97);
            this.btnSettings.TabIndex = 73;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-27, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 10);
            this.label3.TabIndex = 72;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(149)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(127, 287);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(252, 54);
            this.btnLogOut.TabIndex = 71;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(402, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 82);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // btnAddEmployees
            // 
            this.btnAddEmployees.FlatAppearance.BorderSize = 0;
            this.btnAddEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnAddEmployees.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployees.Image = global::Media_Bazaar_Software.Properties.Resources.images1;
            this.btnAddEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployees.Location = new System.Drawing.Point(3, 354);
            this.btnAddEmployees.Name = "btnAddEmployees";
            this.btnAddEmployees.Size = new System.Drawing.Size(514, 97);
            this.btnAddEmployees.TabIndex = 68;
            this.btnAddEmployees.Text = "    Employee Managment";
            this.btnAddEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEmployees.UseVisualStyleBackColor = true;
            this.btnAddEmployees.Click += new System.EventHandler(this.btnAddEmployees_Click);
            // 
            // ucLoggedUser
            // 
            this.ucLoggedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ucLoggedUser.Location = new System.Drawing.Point(0, 92);
            this.ucLoggedUser.Margin = new System.Windows.Forms.Padding(5);
            this.ucLoggedUser.Name = "ucLoggedUser";
            this.ucLoggedUser.Size = new System.Drawing.Size(501, 186);
            this.ucLoggedUser.TabIndex = 19;
            this.ucLoggedUser.txtEmail = "Employee Email";
            this.ucLoggedUser.txtName = "Employee Name";
            this.ucLoggedUser.UserIcon = ((System.Drawing.Image)(resources.GetObject("ucLoggedUser.UserIcon")));
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.BackgroundImage = global::Media_Bazaar_Software.Properties.Resources.Hamburger_icon1;
            this.btnShowMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowMenu.FlatAppearance.BorderSize = 0;
            this.btnShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMenu.ForeColor = System.Drawing.Color.White;
            this.btnShowMenu.Location = new System.Drawing.Point(3, 9);
            this.btnShowMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(87, 79);
            this.btnShowMenu.TabIndex = 16;
            this.btnShowMenu.TabStop = false;
            this.btnShowMenu.UseVisualStyleBackColor = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click_1);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-27, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 10);
            this.label2.TabIndex = 2;
            // 
            // panelTab
            // 
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab.Location = new System.Drawing.Point(501, 37);
            this.panelTab.Margin = new System.Windows.Forms.Padding(4);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(1231, 776);
            this.panelTab.TabIndex = 63;
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1732, 813);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddEmployees;
        private UserControls.UCLoggedUser ucLoggedUser;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTab;
    }
}