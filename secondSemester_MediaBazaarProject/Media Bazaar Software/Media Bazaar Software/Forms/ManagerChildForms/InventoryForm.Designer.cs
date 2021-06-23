
namespace Media_Bazaar_Software.UI.ManagerChildForms
{
    partial class InventoryForm
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
            this.btnBundles = new System.Windows.Forms.Button();
            this.btnShowItemsInDepartment = new System.Windows.Forms.Button();
            this.btnCreateBundle = new System.Windows.Forms.Button();
            this.btnRequestItem = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBundles
            // 
            this.btnBundles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBundles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBundles.ForeColor = System.Drawing.Color.White;
            this.btnBundles.Location = new System.Drawing.Point(843, 564);
            this.btnBundles.Margin = new System.Windows.Forms.Padding(4);
            this.btnBundles.Name = "btnBundles";
            this.btnBundles.Size = new System.Drawing.Size(290, 103);
            this.btnBundles.TabIndex = 11;
            this.btnBundles.Text = "View bundles";
            this.btnBundles.UseVisualStyleBackColor = true;
            this.btnBundles.Click += new System.EventHandler(this.btnBundles_Click);
            // 
            // btnShowItemsInDepartment
            // 
            this.btnShowItemsInDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowItemsInDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowItemsInDepartment.ForeColor = System.Drawing.Color.White;
            this.btnShowItemsInDepartment.Location = new System.Drawing.Point(843, 64);
            this.btnShowItemsInDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowItemsInDepartment.Name = "btnShowItemsInDepartment";
            this.btnShowItemsInDepartment.Size = new System.Drawing.Size(290, 103);
            this.btnShowItemsInDepartment.TabIndex = 10;
            this.btnShowItemsInDepartment.Text = "Show all items in the Department";
            this.btnShowItemsInDepartment.UseVisualStyleBackColor = true;
            this.btnShowItemsInDepartment.Click += new System.EventHandler(this.btnShowItemsInDepartment_Click);
            // 
            // btnCreateBundle
            // 
            this.btnCreateBundle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBundle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateBundle.ForeColor = System.Drawing.Color.White;
            this.btnCreateBundle.Location = new System.Drawing.Point(843, 449);
            this.btnCreateBundle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateBundle.Name = "btnCreateBundle";
            this.btnCreateBundle.Size = new System.Drawing.Size(290, 103);
            this.btnCreateBundle.TabIndex = 9;
            this.btnCreateBundle.Text = "Create a bundle";
            this.btnCreateBundle.UseVisualStyleBackColor = true;
            this.btnCreateBundle.Click += new System.EventHandler(this.btnCreateBundle_Click);
            // 
            // btnRequestItem
            // 
            this.btnRequestItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequestItem.ForeColor = System.Drawing.Color.White;
            this.btnRequestItem.Location = new System.Drawing.Point(843, 195);
            this.btnRequestItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequestItem.Name = "btnRequestItem";
            this.btnRequestItem.Size = new System.Drawing.Size(290, 103);
            this.btnRequestItem.TabIndex = 8;
            this.btnRequestItem.Text = "Request Restock on Selected Item";
            this.btnRequestItem.UseVisualStyleBackColor = true;
            this.btnRequestItem.Click += new System.EventHandler(this.btnRequestItem_Click);
            // 
            // lbItems
            // 
            this.lbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbItems.ForeColor = System.Drawing.Color.White;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 25;
            this.lbItems.Location = new System.Drawing.Point(31, 49);
            this.lbItems.Margin = new System.Windows.Forms.Padding(4);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(779, 629);
            this.lbItems.TabIndex = 7;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.btnBundles);
            this.Controls.Add(this.btnShowItemsInDepartment);
            this.Controls.Add(this.btnCreateBundle);
            this.Controls.Add(this.btnRequestItem);
            this.Controls.Add(this.lbItems);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBundles;
        private System.Windows.Forms.Button btnShowItemsInDepartment;
        private System.Windows.Forms.Button btnCreateBundle;
        private System.Windows.Forms.Button btnRequestItem;
        private System.Windows.Forms.ListBox lbItems;
    }
}