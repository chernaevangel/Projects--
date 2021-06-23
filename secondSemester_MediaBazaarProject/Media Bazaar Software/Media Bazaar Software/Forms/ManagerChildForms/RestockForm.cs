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

namespace Media_Bazaar_Software.UI.ManagerChildForms
{
    public partial class RestockForm : Form
    {
        Shop Shop;
        Item Item;
        public RestockForm(Shop shop, Item item)
        {
            InitializeComponent();
            Shop = shop;
            Item = item;
            lblItemName.Text += Item.Name;
            lblInStock.Text += Item.InStock.ToString();
            lblMin.Text += Item.MinimumAmount.ToString();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Shop.rm.CreateRequest(Item, nUDAmount.Value);
            DialogResult dialogResult = MessageBox.Show("Request successful","Succes!", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
