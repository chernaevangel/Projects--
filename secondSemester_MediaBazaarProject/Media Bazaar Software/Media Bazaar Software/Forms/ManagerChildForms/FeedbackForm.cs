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
    public partial class FeedbackForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public FeedbackForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
        }

        private void btnGetFeedback_Click(object sender, EventArgs e)
        {
            lbFeedbackFromEmployee.Items.Clear();
            lbFeedbackFromEmployee.Items.AddRange(Shop.fm.GetFeedbacks(LoggedEmployee.Department));
        }
    }
}
