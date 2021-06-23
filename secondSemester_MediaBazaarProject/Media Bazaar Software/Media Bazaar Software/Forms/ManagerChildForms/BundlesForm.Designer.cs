
namespace Media_Bazaar_Software.UI.ManagerChildForms
{
    partial class BundlesForm
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
            this.lbBundles = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBundles
            // 
            this.lbBundles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbBundles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBundles.ForeColor = System.Drawing.Color.White;
            this.lbBundles.FormattingEnabled = true;
            this.lbBundles.ItemHeight = 31;
            this.lbBundles.Location = new System.Drawing.Point(13, 3);
            this.lbBundles.Margin = new System.Windows.Forms.Padding(4);
            this.lbBundles.Name = "lbBundles";
            this.lbBundles.Size = new System.Drawing.Size(280, 283);
            this.lbBundles.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(69, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BundlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(308, 395);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbBundles);
            this.Name = "BundlesForm";
            this.Text = "BundlesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBundles;
        private System.Windows.Forms.Button btnClose;
    }
}