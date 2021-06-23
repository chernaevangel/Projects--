
namespace Media_Bazaar_Software.UI.EmployeeDepotChildForms
{
    partial class SellItemsForm
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
            this.gbOverviewItemsShopW = new System.Windows.Forms.GroupBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnShowItems = new System.Windows.Forms.Button();
            this.lbItemsOverview = new System.Windows.Forms.ListBox();
            this.lblSpecifficator = new System.Windows.Forms.Label();
            this.numSpecificator = new System.Windows.Forms.NumericUpDown();
            this.gbOverviewItemsShopW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpecificator)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOverviewItemsShopW
            // 
            this.gbOverviewItemsShopW.Controls.Add(this.numSpecificator);
            this.gbOverviewItemsShopW.Controls.Add(this.lblSpecifficator);
            this.gbOverviewItemsShopW.Controls.Add(this.btnSell);
            this.gbOverviewItemsShopW.Controls.Add(this.btnShowItems);
            this.gbOverviewItemsShopW.Controls.Add(this.lbItemsOverview);
            this.gbOverviewItemsShopW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOverviewItemsShopW.ForeColor = System.Drawing.Color.White;
            this.gbOverviewItemsShopW.Location = new System.Drawing.Point(23, 54);
            this.gbOverviewItemsShopW.Margin = new System.Windows.Forms.Padding(4);
            this.gbOverviewItemsShopW.Name = "gbOverviewItemsShopW";
            this.gbOverviewItemsShopW.Padding = new System.Windows.Forms.Padding(4);
            this.gbOverviewItemsShopW.Size = new System.Drawing.Size(1068, 684);
            this.gbOverviewItemsShopW.TabIndex = 1;
            this.gbOverviewItemsShopW.TabStop = false;
            this.gbOverviewItemsShopW.Text = "Overview of items";
            // 
            // btnSell
            // 
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(729, 500);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(272, 81);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Sell selected item";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnShowItems
            // 
            this.btnShowItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowItems.ForeColor = System.Drawing.Color.White;
            this.btnShowItems.Location = new System.Drawing.Point(48, 500);
            this.btnShowItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowItems.Name = "btnShowItems";
            this.btnShowItems.Size = new System.Drawing.Size(272, 81);
            this.btnShowItems.TabIndex = 6;
            this.btnShowItems.Text = "Show Items in Department";
            this.btnShowItems.UseVisualStyleBackColor = true;
            this.btnShowItems.Click += new System.EventHandler(this.btnShowItems_Click);
            // 
            // lbItemsOverview
            // 
            this.lbItemsOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbItemsOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbItemsOverview.ForeColor = System.Drawing.Color.White;
            this.lbItemsOverview.FormattingEnabled = true;
            this.lbItemsOverview.ItemHeight = 25;
            this.lbItemsOverview.Location = new System.Drawing.Point(8, 55);
            this.lbItemsOverview.Margin = new System.Windows.Forms.Padding(4);
            this.lbItemsOverview.Name = "lbItemsOverview";
            this.lbItemsOverview.Size = new System.Drawing.Size(1051, 404);
            this.lbItemsOverview.TabIndex = 0;
            // 
            // lblSpecifficator
            // 
            this.lblSpecifficator.AutoSize = true;
            this.lblSpecifficator.Location = new System.Drawing.Point(387, 499);
            this.lblSpecifficator.Name = "lblSpecifficator";
            this.lblSpecifficator.Size = new System.Drawing.Size(285, 29);
            this.lblSpecifficator.TabIndex = 10;
            this.lblSpecifficator.Text = "Select a speciffic amount \r\n";
            // 
            // numSpecificator
            // 
            this.numSpecificator.Location = new System.Drawing.Point(441, 547);
            this.numSpecificator.Name = "numSpecificator";
            this.numSpecificator.Size = new System.Drawing.Size(171, 34);
            this.numSpecificator.TabIndex = 11;
            // 
            // SellItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.gbOverviewItemsShopW);
            this.Name = "SellItemsForm";
            this.Text = "SellItems";
            this.gbOverviewItemsShopW.ResumeLayout(false);
            this.gbOverviewItemsShopW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpecificator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOverviewItemsShopW;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnShowItems;
        private System.Windows.Forms.ListBox lbItemsOverview;
        private System.Windows.Forms.Label lblSpecifficator;
        private System.Windows.Forms.NumericUpDown numSpecificator;
    }
}