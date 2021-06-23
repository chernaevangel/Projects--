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
    public partial class BundlesForm : Form
    {
        Shop Shop;
        Employee Employee;
        public BundlesForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            Employee = employee;
            lbBundles.Items.AddRange(Shop.bm.GetBundles(Employee.Department));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
