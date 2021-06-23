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

namespace Media_Bazaar_Software.UI.AdministratorChildForms
{
    public partial class FinancesForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public FinancesForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
        }
        private void RefreshEmployeeTypesListbox()
        {
            lbEmployeeTypes.Items.Clear();
            foreach (EmployeeType e in Shop.etm.employeeTypes)
            { lbEmployeeTypes.Items.Add(e.ToString()); }
        }
        private void btnShowEmployeeTypes_Click(object sender, EventArgs e)
        {
            RefreshEmployeeTypesListbox();
        }

        private void btnRemoveSelectedEmployeeType_Click(object sender, EventArgs e)
        {
            string[] splitString = lbEmployeeTypes.SelectedItem.ToString().Split(' ');
            EmployeeType empType = Shop.etm.GetEmployeeType(splitString[0]);
            Shop.etm.RemoveEmployeeType(empType);

            RefreshEmployeeTypesListbox();
        }

        private void btnCreateEmployeeType_Click(object sender, EventArgs e)
        {
            try
            {
                string type = tbEmployeeType.Text;
                decimal wage = Convert.ToDecimal(tbWagePerHour.Text);
                EmployeeType employeeType = new EmployeeType(type, wage);
                Shop.etm.Add(employeeType);

                RefreshEmployeeTypesListbox();
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect wage format. Please try again");
            }
        }

        private void btnEditEmpTypeWage_Click(object sender, EventArgs e)
        {
            try
            {
                string[] splitString = lbEmployeeTypes.SelectedItem.ToString().Split(' ');
                EmployeeType empType = Shop.etm.GetEmployeeType(splitString[0]);
                Shop.etm.EditEmployeeTypeWage(empType, Convert.ToDecimal(tbNewWage.Text));

                RefreshEmployeeTypesListbox();
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect wage format. Please try again");
            }
        }

        private void lbEmployeeTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEmployeeType.Text = lbEmployeeTypes.SelectedItem.ToString();
        }
    }
}
