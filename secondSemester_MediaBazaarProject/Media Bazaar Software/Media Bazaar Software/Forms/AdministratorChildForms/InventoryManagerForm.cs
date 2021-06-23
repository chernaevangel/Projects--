using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media_Bazaar_Software.Classes;

namespace Media_Bazaar_Software.UI.AdministratorChildForms
{
    public partial class InventoryManagerForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public InventoryManagerForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
        }

        private void btnShowItems_Click(object sender, EventArgs e)
        {
            lbItemsOverview.Items.Clear();
            lbItemsOverview.Items.AddRange(Shop.im.Items.ToArray());
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            Shop.im.RemoveItem(tbSearchItem.Text);
            btnShowItems_Click(sender, e);
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            lbItemsOverview.Items.Clear();
            if (Shop.im.GetItem(tbSearchItem.Text) != null)
            {
                lbItemsOverview.Items.Add(Shop.im.GetItem(tbSearchItem.Text));
            }
            else { MessageBox.Show("Please pick a valid Item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm(Shop);
            addItemForm.Show();
        }
    }
}
