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
    public partial class InventoryForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public InventoryForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
        }

        private void btnShowItemsInDepartment_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            lbItems.Items.AddRange(Shop.im.GetItemsDepartment(LoggedEmployee.Department));
        }

        private void btnRequestItem_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex > -1)
            {
                RestockForm restockForm = new RestockForm(Shop, (Item)lbItems.SelectedItem);
                restockForm.Show();
            }
        }

        private void btnCreateBundle_Click(object sender, EventArgs e)
        {
            CreateBundleForm createBundleForm = new CreateBundleForm(Shop);
            createBundleForm.Show();
        }

        private void btnBundles_Click(object sender, EventArgs e)
        {
            BundlesForm bundlesForm = new BundlesForm(Shop, LoggedEmployee);
            bundlesForm.Show();
        }
    }
}
