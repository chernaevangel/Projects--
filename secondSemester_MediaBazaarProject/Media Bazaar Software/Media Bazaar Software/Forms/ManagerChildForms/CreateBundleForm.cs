using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Bazaar_Software.UI.ManagerChildForms
{
    public partial class CreateBundleForm : Form
    {
        Shop Shop;
        public CreateBundleForm(Shop shop)
        {
            InitializeComponent();
            Shop = shop;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Shop.bm.CreateBundle(tbItem1.Text, tbItem2.Text, tbPrice.Text) == true)
            {
                DialogResult dialog = MessageBox.Show("Bundle successfully created", "Success!", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
