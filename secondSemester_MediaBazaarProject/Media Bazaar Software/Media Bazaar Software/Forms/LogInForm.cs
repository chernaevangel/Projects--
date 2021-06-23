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
using System.Security.Cryptography;

namespace Media_Bazaar_Software.UI
{
    public partial class LogInForm : Form
    {
        Shop Shop;
        public LogInForm()
        {
            InitializeComponent();
            Shop = new Shop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            tbEmail.Text = "";
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Employee employee = Shop.em.LogIn(tbEmail.Text, tbPassword.Text);
            if (employee != null)
            {
                if (employee.EmployeeType == "Manager")
                { ManagerForm manager = new ManagerForm(Shop, employee); manager.Show(); }
                else if (employee.EmployeeType == "Administrator")
                { AdministratorForm administrator = new AdministratorForm(Shop, employee); administrator.Show(); }
                else if (employee.EmployeeType == "HR")
                { HRForm hR = new HRForm(Shop, employee); hR.Show(); }
                else if (employee.EmployeeType == "Employee")
                { EmployeeForm employeeForm = new EmployeeForm(Shop, employee); employeeForm.Show(); }
                else if (employee.EmployeeType == "Depot")
                { DepotForm depotForm = new DepotForm(Shop, employee); depotForm.Show(); }
            }
            else { MessageBox.Show("Incorrect email or password. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            tbEmail.Text = "";
            tbPassword.Text = "";
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }
    }
}
