
namespace Media_Bazaar_Software.UI.ManagerChildForms
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetFeedback = new System.Windows.Forms.Button();
            this.lbFeedbackFromEmployee = new System.Windows.Forms.ListBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetFeedback);
            this.groupBox4.Controls.Add(this.lbFeedbackFromEmployee);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(13, 28);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1151, 710);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Feedback from employees";
            // 
            // btnGetFeedback
            // 
            this.btnGetFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFeedback.ForeColor = System.Drawing.Color.White;
            this.btnGetFeedback.Location = new System.Drawing.Point(415, 584);
            this.btnGetFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFeedback.Name = "btnGetFeedback";
            this.btnGetFeedback.Size = new System.Drawing.Size(244, 76);
            this.btnGetFeedback.TabIndex = 3;
            this.btnGetFeedback.Text = "Show";
            this.btnGetFeedback.UseVisualStyleBackColor = true;
            this.btnGetFeedback.Click += new System.EventHandler(this.btnGetFeedback_Click);
            // 
            // lbFeedbackFromEmployee
            // 
            this.lbFeedbackFromEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbFeedbackFromEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFeedbackFromEmployee.ForeColor = System.Drawing.Color.White;
            this.lbFeedbackFromEmployee.FormattingEnabled = true;
            this.lbFeedbackFromEmployee.ItemHeight = 25;
            this.lbFeedbackFromEmployee.Location = new System.Drawing.Point(25, 58);
            this.lbFeedbackFromEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.lbFeedbackFromEmployee.Name = "lbFeedbackFromEmployee";
            this.lbFeedbackFromEmployee.Size = new System.Drawing.Size(1007, 454);
            this.lbFeedbackFromEmployee.TabIndex = 0;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.groupBox4);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGetFeedback;
        private System.Windows.Forms.ListBox lbFeedbackFromEmployee;
    }
}