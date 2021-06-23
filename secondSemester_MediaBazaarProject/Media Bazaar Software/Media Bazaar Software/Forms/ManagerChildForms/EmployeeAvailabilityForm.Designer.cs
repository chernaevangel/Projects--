
namespace Media_Bazaar_Software.Forms.ManagerChildForms
{
    partial class EmployeeAvailabilityForm
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
            this.lbPreferences = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPreferences
            // 
            this.lbPreferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbPreferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbPreferences.ForeColor = System.Drawing.Color.White;
            this.lbPreferences.FormattingEnabled = true;
            this.lbPreferences.ItemHeight = 29;
            this.lbPreferences.Location = new System.Drawing.Point(13, 13);
            this.lbPreferences.Name = "lbPreferences";
            this.lbPreferences.Size = new System.Drawing.Size(489, 410);
            this.lbPreferences.TabIndex = 0;
            // 
            // EmployeeAvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.lbPreferences);
            this.Name = "EmployeeAvailabilityForm";
            this.Text = "EmployeeAvailabilityForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPreferences;
    }
}