
namespace Media_Bazaar_Software.Forms.ManagerChildForms
{
    partial class PreferenceForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbAvailability = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAvailable = new System.Windows.Forms.RadioButton();
            this.rbUnavailable = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(125, 73);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // lbAvailability
            // 
            this.lbAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbAvailability.ForeColor = System.Drawing.Color.White;
            this.lbAvailability.FormattingEnabled = true;
            this.lbAvailability.ItemHeight = 36;
            this.lbAvailability.Location = new System.Drawing.Point(535, 6);
            this.lbAvailability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAvailability.Name = "lbAvailability";
            this.lbAvailability.Size = new System.Drawing.Size(515, 508);
            this.lbAvailability.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pick a date:";
            // 
            // rbAvailable
            // 
            this.rbAvailable.AutoSize = true;
            this.rbAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAvailable.ForeColor = System.Drawing.Color.White;
            this.rbAvailable.Location = new System.Drawing.Point(125, 354);
            this.rbAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAvailable.Name = "rbAvailable";
            this.rbAvailable.Size = new System.Drawing.Size(163, 36);
            this.rbAvailable.TabIndex = 9;
            this.rbAvailable.TabStop = true;
            this.rbAvailable.Text = "Available";
            this.rbAvailable.UseVisualStyleBackColor = true;
            // 
            // rbUnavailable
            // 
            this.rbUnavailable.AutoSize = true;
            this.rbUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnavailable.ForeColor = System.Drawing.Color.White;
            this.rbUnavailable.Location = new System.Drawing.Point(125, 398);
            this.rbUnavailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUnavailable.Name = "rbUnavailable";
            this.rbUnavailable.Size = new System.Drawing.Size(188, 35);
            this.rbUnavailable.TabIndex = 10;
            this.rbUnavailable.TabStop = true;
            this.rbUnavailable.Text = "Unavailable";
            this.rbUnavailable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pick availability:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(164, 458);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(191, 62);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PreferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbUnavailable);
            this.Controls.Add(this.rbAvailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAvailability);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PreferenceForm";
            this.Text = "PreferenceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox lbAvailability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAvailable;
        private System.Windows.Forms.RadioButton rbUnavailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
    }
}