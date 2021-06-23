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
    public partial class DepartmentManagment : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public DepartmentManagment(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
        }

        private void btnShowDepartment_Click(object sender, EventArgs e)
        {
            RefreshDepartmentListbox();
        }
        private void RefreshDepartmentListbox()
        {
            lbDepartments.Items.Clear();
            foreach (Department d in Shop.dm.Departments)
            { lbDepartments.Items.Add(d.ToString()); }
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
                Department department = Shop.dm.GetDepartment(lbDepartments.SelectedItem.ToString());
                Shop.dm.RemoveDepartment(department);

                RefreshDepartmentListbox();
        
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                string departmentName = tbDepartmentName.Text;
                int managerId = Convert.ToInt32(tbManagerId.Text);
                Shop.dm.AddDepartment(departmentName, managerId);

                RefreshDepartmentListbox();
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect wage format. Please try again");
            }
        }
    }
}
