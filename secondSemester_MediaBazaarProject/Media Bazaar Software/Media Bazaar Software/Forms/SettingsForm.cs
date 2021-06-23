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

namespace Media_Bazaar_Software.UI
{
    public partial class SettingsForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public SettingsForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
            tbPersonalEmail.Text = LoggedEmployee.Email;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Shop.em.EmployeeChangePassword(tbPersonalEmail.Text, tbOldPassword.Text, tbNewPass.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Shop.em.LogOut(LoggedEmployee.Id, tbHours.Text);
        }
    }
}
