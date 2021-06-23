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

        private void btnSWsendFeedback_Click(object sender, EventArgs e)
        {
            Shop.fm.GiveFeedback(LoggedEmployee, tbFeedback.Text);
            MessageBox.Show("Feedback sent!");
            tbFeedback.Text = "";
        }
    }
}
