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
    public partial class AddItemForm : Form
    {
        Shop Shop;
        public AddItemForm(Shop shop)
        {
            InitializeComponent();
            Shop = shop;
            cbNewItemSector.Items.AddRange(Shop.dm.Departments.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Shop.im.AddItem(tbNewItemName.Text, tbNewItemPrice.Text, tbNewItemMinAmount.Text, cbNewItemSector.Text))
                { this.Close(); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid information. Please try again!", "Error");
            }
        }
    }
}
