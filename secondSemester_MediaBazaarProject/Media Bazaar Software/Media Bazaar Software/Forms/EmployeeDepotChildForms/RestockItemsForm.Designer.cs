
namespace Media_Bazaar_Software.UI.EmployeeDepotChildForms
{
    partial class RestockItemsForm
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
            this.gbRequestsDW = new System.Windows.Forms.GroupBox();
            this.btnFinishRestock = new System.Windows.Forms.Button();
            this.btnShowRequestedItems = new System.Windows.Forms.Button();
            this.lbListOfRequestedItems = new System.Windows.Forms.ListBox();
            this.gbRequestsDW.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRequestsDW
            // 
            this.gbRequestsDW.Controls.Add(this.btnFinishRestock);
            this.gbRequestsDW.Controls.Add(this.btnShowRequestedItems);
            this.gbRequestsDW.Controls.Add(this.lbListOfRequestedItems);
            this.gbRequestsDW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRequestsDW.ForeColor = System.Drawing.Color.White;
            this.gbRequestsDW.Location = new System.Drawing.Point(100, 45);
            this.gbRequestsDW.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbRequestsDW.Name = "gbRequestsDW";
            this.gbRequestsDW.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbRequestsDW.Size = new System.Drawing.Size(920, 661);
            this.gbRequestsDW.TabIndex = 1;
            this.gbRequestsDW.TabStop = false;
            this.gbRequestsDW.Text = "Requests For Items";
            // 
            // btnFinishRestock
            // 
            this.btnFinishRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishRestock.ForeColor = System.Drawing.Color.White;
            this.btnFinishRestock.Location = new System.Drawing.Point(265, 565);
            this.btnFinishRestock.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFinishRestock.Name = "btnFinishRestock";
            this.btnFinishRestock.Size = new System.Drawing.Size(367, 71);
            this.btnFinishRestock.TabIndex = 12;
            this.btnFinishRestock.Text = "Finish Restock";
            this.btnFinishRestock.UseVisualStyleBackColor = true;
            this.btnFinishRestock.Click += new System.EventHandler(this.btnFinishRestock_Click);
            // 
            // btnShowRequestedItems
            // 
            this.btnShowRequestedItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRequestedItems.ForeColor = System.Drawing.Color.White;
            this.btnShowRequestedItems.Location = new System.Drawing.Point(265, 441);
            this.btnShowRequestedItems.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnShowRequestedItems.Name = "btnShowRequestedItems";
            this.btnShowRequestedItems.Size = new System.Drawing.Size(367, 71);
            this.btnShowRequestedItems.TabIndex = 11;
            this.btnShowRequestedItems.Text = "Show Requested items";
            this.btnShowRequestedItems.UseVisualStyleBackColor = true;
            this.btnShowRequestedItems.Click += new System.EventHandler(this.btnShowRequestedItems_Click);
            // 
            // lbListOfRequestedItems
            // 
            this.lbListOfRequestedItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbListOfRequestedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbListOfRequestedItems.ForeColor = System.Drawing.Color.White;
            this.lbListOfRequestedItems.FormattingEnabled = true;
            this.lbListOfRequestedItems.ItemHeight = 25;
            this.lbListOfRequestedItems.Location = new System.Drawing.Point(33, 47);
            this.lbListOfRequestedItems.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbListOfRequestedItems.Name = "lbListOfRequestedItems";
            this.lbListOfRequestedItems.Size = new System.Drawing.Size(839, 354);
            this.lbListOfRequestedItems.TabIndex = 0;
            // 
            // RestockItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.gbRequestsDW);
            this.Name = "RestockItemsForm";
            this.Text = "RestockItemsForm";
            this.gbRequestsDW.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRequestsDW;
        private System.Windows.Forms.Button btnFinishRestock;
        private System.Windows.Forms.Button btnShowRequestedItems;
        private System.Windows.Forms.ListBox lbListOfRequestedItems;
    }
}