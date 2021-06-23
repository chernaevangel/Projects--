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

namespace Media_Bazaar_Software.Forms.ManagerChildForms
{
    public partial class PreferenceForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public PreferenceForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
            RefreshLb();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionStart.ToShortDateString() != null && rbAvailable.Checked || rbUnavailable.Checked)
            {
                if (rbAvailable.Checked)
                {
                    if (Shop.pm.AddPreference(LoggedEmployee.Id, monthCalendar1.SelectionStart.ToShortDateString(), rbAvailable.Text))
                    { MessageBox.Show("Preference set successfully!"); }
                    else { MessageBox.Show("Please input all the required data and try again!"); }
                }
                else
                {
                    if (Shop.pm.AddPreference(LoggedEmployee.Id, monthCalendar1.SelectionStart.ToShortDateString(), rbUnavailable.Text))
                    { MessageBox.Show("Preference set successfully!"); }
                    else { MessageBox.Show("Please input all the required data and try again!"); }
                }
            }
            RefreshLb();
        }
        private void RefreshLb()
        {
            lbAvailability.Items.Clear();
            lbAvailability.Items.AddRange(Shop.pm.GetEmployeePreferences(LoggedEmployee.Id));
        }
    }
}
