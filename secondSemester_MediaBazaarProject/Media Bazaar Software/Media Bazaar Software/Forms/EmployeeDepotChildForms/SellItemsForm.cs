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

namespace Media_Bazaar_Software.UI.EmployeeDepotChildForms
{
    public partial class SellItemsForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public SellItemsForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
        }

        private void btnShowItems_Click(object sender, EventArgs e)
        {
            lbItemsOverview.Items.Clear();
            lbItemsOverview.Items.AddRange(Shop.im.GetItemsDepartment(LoggedEmployee.Department));
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (lbItemsOverview.SelectedIndex > -1)
            {
                if (numSpecificator.Value==0)
                {
                    Item item = (Item)lbItemsOverview.SelectedItem;
                    item.SellItem(1);
                    lbItemsOverview.Items.Clear();
                    lbItemsOverview.Items.AddRange(Shop.im.GetItemsDepartment(LoggedEmployee.Department));
                }
                else
                {
                    Item item = (Item)lbItemsOverview.SelectedItem;
                    item.SellItem(Convert.ToInt32(numSpecificator.Value));
                    lbItemsOverview.Items.Clear();
                    lbItemsOverview.Items.AddRange(Shop.im.GetItemsDepartment(LoggedEmployee.Department));
                }
            }
        }
    }
}
