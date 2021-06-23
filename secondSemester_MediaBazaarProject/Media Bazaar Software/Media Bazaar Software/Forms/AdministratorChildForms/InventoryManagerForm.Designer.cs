
namespace Media_Bazaar_Software.UI.AdministratorChildForms
{
    partial class InventoryManagerForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.gbOverviewItemsShopW = new System.Windows.Forms.GroupBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.tbSearchItem = new System.Windows.Forms.TextBox();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnShowItems = new System.Windows.Forms.Button();
            this.lbItemsOverview = new System.Windows.Forms.ListBox();
            this.gbOverviewItemsShopW.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 38);
            this.label3.TabIndex = 25;
            this.label3.Text = "Inventory Managment";
            // 
            // gbOverviewItemsShopW
            // 
            this.gbOverviewItemsShopW.Controls.Add(this.btnAddNewItem);
            this.gbOverviewItemsShopW.Controls.Add(this.btnSearchItem);
            this.gbOverviewItemsShopW.Controls.Add(this.tbSearchItem);
            this.gbOverviewItemsShopW.Controls.Add(this.lblSearchItem);
            this.gbOverviewItemsShopW.Controls.Add(this.btnRemoveItem);
            this.gbOverviewItemsShopW.Controls.Add(this.btnShowItems);
            this.gbOverviewItemsShopW.Controls.Add(this.lbItemsOverview);
            this.gbOverviewItemsShopW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOverviewItemsShopW.ForeColor = System.Drawing.Color.White;
            this.gbOverviewItemsShopW.Location = new System.Drawing.Point(4, 84);
            this.gbOverviewItemsShopW.Margin = new System.Windows.Forms.Padding(4);
            this.gbOverviewItemsShopW.Name = "gbOverviewItemsShopW";
            this.gbOverviewItemsShopW.Padding = new System.Windows.Forms.Padding(4);
            this.gbOverviewItemsShopW.Size = new System.Drawing.Size(1000, 642);
            this.gbOverviewItemsShopW.TabIndex = 26;
            this.gbOverviewItemsShopW.TabStop = false;
            this.gbOverviewItemsShopW.Text = "Overview of items";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItem.Location = new System.Drawing.Point(758, 447);
            this.btnAddNewItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(213, 110);
            this.btnAddNewItem.TabIndex = 11;
            this.btnAddNewItem.Text = "Add item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchItem.ForeColor = System.Drawing.Color.White;
            this.btnSearchItem.Location = new System.Drawing.Point(519, 538);
            this.btnSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(183, 72);
            this.btnSearchItem.TabIndex = 10;
            this.btnSearchItem.Text = "Search item:";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // tbSearchItem
            // 
            this.tbSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchItem.Location = new System.Drawing.Point(496, 490);
            this.tbSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchItem.Name = "tbSearchItem";
            this.tbSearchItem.Size = new System.Drawing.Size(218, 30);
            this.tbSearchItem.TabIndex = 9;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchItem.ForeColor = System.Drawing.Color.White;
            this.lblSearchItem.Location = new System.Drawing.Point(528, 437);
            this.lblSearchItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(174, 32);
            this.lblSearchItem.TabIndex = 8;
            this.lblSearchItem.Text = "Search item:";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(256, 448);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(210, 109);
            this.btnRemoveItem.TabIndex = 7;
            this.btnRemoveItem.Text = "Remove selected item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnShowItems
            // 
            this.btnShowItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowItems.ForeColor = System.Drawing.Color.White;
            this.btnShowItems.Location = new System.Drawing.Point(24, 448);
            this.btnShowItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowItems.Name = "btnShowItems";
            this.btnShowItems.Size = new System.Drawing.Size(207, 109);
            this.btnShowItems.TabIndex = 6;
            this.btnShowItems.Text = "Show";
            this.btnShowItems.UseVisualStyleBackColor = true;
            this.btnShowItems.Click += new System.EventHandler(this.btnShowItems_Click);
            // 
            // lbItemsOverview
            // 
            this.lbItemsOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbItemsOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemsOverview.ForeColor = System.Drawing.Color.White;
            this.lbItemsOverview.FormattingEnabled = true;
            this.lbItemsOverview.ItemHeight = 25;
            this.lbItemsOverview.Location = new System.Drawing.Point(8, 39);
            this.lbItemsOverview.Margin = new System.Windows.Forms.Padding(4);
            this.lbItemsOverview.Name = "lbItemsOverview";
            this.lbItemsOverview.Size = new System.Drawing.Size(963, 354);
            this.lbItemsOverview.TabIndex = 0;
            // 
            // InventoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.gbOverviewItemsShopW);
            this.Controls.Add(this.label3);
            this.Name = "InventoryManagerForm";
            this.Text = "InventoryManagerForm";
            this.gbOverviewItemsShopW.ResumeLayout(false);
            this.gbOverviewItemsShopW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbOverviewItemsShopW;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.TextBox tbSearchItem;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnShowItems;
        private System.Windows.Forms.ListBox lbItemsOverview;
        private System.Windows.Forms.Button btnAddNewItem;
    }
}