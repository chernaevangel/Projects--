
namespace Media_Bazaar_Software.UI
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEmployeeOverview = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.ucLoggedUser = new Media_Bazaar_Software.UserControls.UCLoggedUser();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTab = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1650, 46);
            this.panel3.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 39);
            this.label1.TabIndex = 46;
            this.label1.Text = "Manager";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1559, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 46);
            this.btnMinimize.TabIndex = 44;
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
            this.btnClose.Location = new System.Drawing.Point(1603, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 46);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnEmployeeOverview);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnFeedback);
            this.panelMenu.Controls.Add(this.btnInventory);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnSchedule);
            this.panelMenu.Controls.Add(this.ucLoggedUser);
            this.panelMenu.Controls.Add(this.btnShowMenu);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 46);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(501, 813);
            this.panelMenu.TabIndex = 3;
            // 
            // btnEmployeeOverview
            // 
            this.btnEmployeeOverview.FlatAppearance.BorderSize = 0;
            this.btnEmployeeOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeOverview.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeOverview.Image = global::Media_Bazaar_Software.Properties.Resources.download1;
            this.btnEmployeeOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeOverview.Location = new System.Drawing.Point(0, 361);
            this.btnEmployeeOverview.Name = "btnEmployeeOverview";
            this.btnEmployeeOverview.Size = new System.Drawing.Size(514, 97);
            this.btnEmployeeOverview.TabIndex = 74;
            this.btnEmployeeOverview.Text = "   Employee Overview";
            this.btnEmployeeOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeOverview.UseVisualStyleBackColor = true;
            this.btnEmployeeOverview.Click += new System.EventHandler(this.btnEmployeeOverview_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Media_Bazaar_Software.Properties.Resources.Windows_Settings_app_icon;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 728);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(506, 97);
            this.btnSettings.TabIndex = 73;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Image = global::Media_Bazaar_Software.Properties.Resources.dsadasdasdasdsa;
            this.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.Location = new System.Drawing.Point(0, 641);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(514, 97);
            this.btnFeedback.TabIndex = 68;
            this.btnFeedback.Text = "   Feedback Overview";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::Media_Bazaar_Software.Properties.Resources._347_3475012_inventory_png_photos_inventory_icon_free1;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 551);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(514, 97);
            this.btnInventory.TabIndex = 68;
            this.btnInventory.Text = "   Inventory Manager";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click_2);
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
            this.btnLogOut.Location = new System.Drawing.Point(126, 277);
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
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = global::Media_Bazaar_Software.Properties.Resources.download2;
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(0, 461);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(514, 97);
            this.btnSchedule.TabIndex = 68;
            this.btnSchedule.Text = "   Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // ucLoggedUser
            // 
            this.ucLoggedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ucLoggedUser.Location = new System.Drawing.Point(0, 82);
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
            this.btnShowMenu.Location = new System.Drawing.Point(4, 6);
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
            // menuTimer
            // 
            this.menuTimer.Interval = 30;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // panelTab
            // 
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab.Location = new System.Drawing.Point(501, 46);
            this.panelTab.Margin = new System.Windows.Forms.Padding(4);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(1149, 813);
            this.panelTab.TabIndex = 62;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1650, 859);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Button btnShowMenu;
        private UserControls.UCLoggedUser ucLoggedUser;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEmployeeOverview;
    }
}