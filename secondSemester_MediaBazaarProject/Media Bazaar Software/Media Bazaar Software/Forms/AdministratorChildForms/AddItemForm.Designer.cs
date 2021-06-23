
namespace Media_Bazaar_Software.UI.AdministratorChildForms
{
    partial class AddItemForm
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
            this.gbAddItem = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.cbNewItemSector = new System.Windows.Forms.ComboBox();
            this.tbNewItemName = new System.Windows.Forms.TextBox();
            this.tbNewItemMinAmount = new System.Windows.Forms.TextBox();
            this.tbNewItemPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddItem
            // 
            this.gbAddItem.Controls.Add(this.btnCancel);
            this.gbAddItem.Controls.Add(this.btnAddNewItem);
            this.gbAddItem.Controls.Add(this.cbNewItemSector);
            this.gbAddItem.Controls.Add(this.tbNewItemName);
            this.gbAddItem.Controls.Add(this.tbNewItemMinAmount);
            this.gbAddItem.Controls.Add(this.tbNewItemPrice);
            this.gbAddItem.Controls.Add(this.label7);
            this.gbAddItem.Controls.Add(this.label6);
            this.gbAddItem.Controls.Add(this.label4);
            this.gbAddItem.Controls.Add(this.label3);
            this.gbAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAddItem.ForeColor = System.Drawing.Color.White;
            this.gbAddItem.Location = new System.Drawing.Point(0, 0);
            this.gbAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.gbAddItem.Name = "gbAddItem";
            this.gbAddItem.Padding = new System.Windows.Forms.Padding(4);
            this.gbAddItem.Size = new System.Drawing.Size(664, 467);
            this.gbAddItem.TabIndex = 6;
            this.gbAddItem.TabStop = false;
            this.gbAddItem.Text = "Add new item";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(30, 366);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(252, 69);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewItem.Location = new System.Drawing.Point(331, 366);
            this.btnAddNewItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(252, 69);
            this.btnAddNewItem.TabIndex = 10;
            this.btnAddNewItem.Text = "Add item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // cbNewItemSector
            // 
            this.cbNewItemSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNewItemSector.FormattingEnabled = true;
            this.cbNewItemSector.Location = new System.Drawing.Point(331, 207);
            this.cbNewItemSector.Margin = new System.Windows.Forms.Padding(4);
            this.cbNewItemSector.Name = "cbNewItemSector";
            this.cbNewItemSector.Size = new System.Drawing.Size(312, 39);
            this.cbNewItemSector.TabIndex = 9;
            // 
            // tbNewItemName
            // 
            this.tbNewItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewItemName.Location = new System.Drawing.Point(331, 60);
            this.tbNewItemName.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewItemName.Name = "tbNewItemName";
            this.tbNewItemName.Size = new System.Drawing.Size(160, 38);
            this.tbNewItemName.TabIndex = 8;
            // 
            // tbNewItemMinAmount
            // 
            this.tbNewItemMinAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewItemMinAmount.Location = new System.Drawing.Point(331, 277);
            this.tbNewItemMinAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewItemMinAmount.Name = "tbNewItemMinAmount";
            this.tbNewItemMinAmount.Size = new System.Drawing.Size(160, 38);
            this.tbNewItemMinAmount.TabIndex = 7;
            // 
            // tbNewItemPrice
            // 
            this.tbNewItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewItemPrice.Location = new System.Drawing.Point(331, 139);
            this.tbNewItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewItemPrice.Name = "tbNewItemPrice";
            this.tbNewItemPrice.Size = new System.Drawing.Size(160, 38);
            this.tbNewItemPrice.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Minimum Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item name:";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(667, 468);
            this.Controls.Add(this.gbAddItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.gbAddItem.ResumeLayout(false);
            this.gbAddItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.ComboBox cbNewItemSector;
        private System.Windows.Forms.TextBox tbNewItemName;
        private System.Windows.Forms.TextBox tbNewItemMinAmount;
        private System.Windows.Forms.TextBox tbNewItemPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}