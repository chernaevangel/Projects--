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
    public partial class RestockItemsForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public RestockItemsForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
        }

        private void btnShowRequestedItems_Click(object sender, EventArgs e)
        {
            lbListOfRequestedItems.Items.Clear();
            lbListOfRequestedItems.Items.AddRange(Shop.rm.GetRequestsDepartment(LoggedEmployee.Department));
        }

        private void btnFinishRestock_Click(object sender, EventArgs e)
        {
            Request request = (Request)lbListOfRequestedItems.SelectedItem;
            Shop.im.GetItem(request.RequestedItem.Id.ToString()).OrderItem(request.Amount);
            Shop.rm.CompleteRequest(request.RequestedItem.Id);
            lbListOfRequestedItems.Items.Remove(request);
        }
    }
}
