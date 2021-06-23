
namespace Media_Bazaar_Software.UI.EmployeeDepotChildForms
{
    partial class FeedbackForm
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
            this.gbEmployeesGiveFeedback = new System.Windows.Forms.GroupBox();
            this.btnSWsendFeedback = new System.Windows.Forms.Button();
            this.tbFeedback = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.gbEmployeesGiveFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmployeesGiveFeedback
            // 
            this.gbEmployeesGiveFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbEmployeesGiveFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.gbEmployeesGiveFeedback.Controls.Add(this.btnSWsendFeedback);
            this.gbEmployeesGiveFeedback.Controls.Add(this.tbFeedback);
            this.gbEmployeesGiveFeedback.Controls.Add(this.lblFeedback);
            this.gbEmployeesGiveFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEmployeesGiveFeedback.ForeColor = System.Drawing.SystemColors.Window;
            this.gbEmployeesGiveFeedback.Location = new System.Drawing.Point(244, 225);
            this.gbEmployeesGiveFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.gbEmployeesGiveFeedback.Name = "gbEmployeesGiveFeedback";
            this.gbEmployeesGiveFeedback.Padding = new System.Windows.Forms.Padding(4);
            this.gbEmployeesGiveFeedback.Size = new System.Drawing.Size(685, 316);
            this.gbEmployeesGiveFeedback.TabIndex = 1;
            this.gbEmployeesGiveFeedback.TabStop = false;
            this.gbEmployeesGiveFeedback.Text = "Give feedback";
            // 
            // btnSWsendFeedback
            // 
            this.btnSWsendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSWsendFeedback.ForeColor = System.Drawing.Color.White;
            this.btnSWsendFeedback.Location = new System.Drawing.Point(256, 186);
            this.btnSWsendFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnSWsendFeedback.Name = "btnSWsendFeedback";
            this.btnSWsendFeedback.Size = new System.Drawing.Size(169, 70);
            this.btnSWsendFeedback.TabIndex = 3;
            this.btnSWsendFeedback.Text = "Send:";
            this.btnSWsendFeedback.UseVisualStyleBackColor = true;
            this.btnSWsendFeedback.Click += new System.EventHandler(this.btnSWsendFeedback_Click);
            // 
            // tbFeedback
            // 
            this.tbFeedback.Location = new System.Drawing.Point(149, 121);
            this.tbFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.tbFeedback.Name = "tbFeedback";
            this.tbFeedback.Size = new System.Drawing.Size(365, 34);
            this.tbFeedback.TabIndex = 2;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.ForeColor = System.Drawing.Color.White;
            this.lblFeedback.Location = new System.Drawing.Point(228, 69);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(232, 29);
            this.lblFeedback.TabIndex = 1;
            this.lblFeedback.Text = "Write your feedback:";
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.gbEmployeesGiveFeedback);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.gbEmployeesGiveFeedback.ResumeLayout(false);
            this.gbEmployeesGiveFeedback.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployeesGiveFeedback;
        private System.Windows.Forms.Button btnSWsendFeedback;
        private System.Windows.Forms.TextBox tbFeedback;
        private System.Windows.Forms.Label lblFeedback;
    }
}