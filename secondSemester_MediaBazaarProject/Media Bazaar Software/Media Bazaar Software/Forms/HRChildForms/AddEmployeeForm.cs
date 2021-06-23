using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media_Bazaar_Software.Exceptions;
using Media_Bazaar_Software.Classes;

namespace Media_Bazaar_Software.UI.HRChildForms
{
    public partial class AddEmployeeForm : Form
    {
        Shop Shop;
        public AddEmployeeForm(Shop shop)
        {
            InitializeComponent();
            Shop = shop;
            cbEmployeeType.Items.AddRange(Shop.etm.employeeTypes.ToArray());
            cbDepartment.Items.AddRange(Shop.dm.Departments.ToArray());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cbEmployeeType.SelectedIndex > -1 || cbDepartment.SelectedIndex > -1)
            {
                string type = cbEmployeeType.SelectedItem.ToString().Split('-').First().Trim();
                try
                {
                    if (Shop.em.AddEmployee(tbFName.Text, tbSName.Text, dtEmployeeBirthdate.Value, tbPhoneNumber.Text, type, cbDepartment.Text, tbEmail.Text))
                    { MessageBox.Show("Employee Added Successfully!"); }
                }
                catch (EmailFormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (PhoneFormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                lbOverview.Items.Clear();
                if (Shop.em.GetEmployee(tbSearchId.Text) != null)
                {
                    lbOverview.Items.Add(Shop.em.GetEmployee(tbSearchId.Text));
                }
                else { MessageBox.Show("Employee not found"); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Id. Please try again!", "Error");
                
            }
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            Shop.em.RemoveEmployee(tbSearchId.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbOverview.Items.Clear();
            lbOverview.Items.AddRange(Shop.em.employees.ToArray());
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Shop.em.GetEmployeeInformation((Employee)lbOverview.SelectedItem));
        }

        private void cbEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmployeeType.SelectedIndex == 1 || cbEmployeeType.SelectedIndex == 2 || cbEmployeeType.SelectedIndex == 4)
            {
                cbDepartment.Enabled = true;
            }
            else { cbDepartment.Enabled = false; cbDepartment.Text = ""; }
        }
    }
}
