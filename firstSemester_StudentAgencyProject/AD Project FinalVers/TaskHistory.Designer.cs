namespace AD_Project_FinalVers
{
    partial class TaskHistory
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
            this.lBTaskHistory = new System.Windows.Forms.ListBox();
            this.lblTaskHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBTaskHistory
            // 
            this.lBTaskHistory.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lBTaskHistory.FormattingEnabled = true;
            this.lBTaskHistory.ItemHeight = 16;
            this.lBTaskHistory.Location = new System.Drawing.Point(56, 50);
            this.lBTaskHistory.Name = "lBTaskHistory";
            this.lBTaskHistory.Size = new System.Drawing.Size(297, 388);
            this.lBTaskHistory.TabIndex = 0;
            // 
            // lblTaskHistory
            // 
            this.lblTaskHistory.AutoSize = true;
            this.lblTaskHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskHistory.Location = new System.Drawing.Point(52, 23);
            this.lblTaskHistory.Name = "lblTaskHistory";
            this.lblTaskHistory.Size = new System.Drawing.Size(130, 24);
            this.lblTaskHistory.TabIndex = 1;
            this.lblTaskHistory.Text = "Task History:";
            // 
            // TaskHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.lblTaskHistory);
            this.Controls.Add(this.lBTaskHistory);
            this.Name = "TaskHistory";
            this.Text = "TaskHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskHistory_FormClosed);
            this.Load += new System.EventHandler(this.TaskHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBTaskHistory;
        private System.Windows.Forms.Label lblTaskHistory;
    }
}