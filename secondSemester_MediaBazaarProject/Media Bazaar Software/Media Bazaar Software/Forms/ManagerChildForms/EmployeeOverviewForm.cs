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
    public partial class ScheduleCreatorForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public ScheduleCreatorForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
        }

        private void btnOverviewEmployees_Click(object sender, EventArgs e)
        {
            lbOverviewOfEmployees.Items.Clear();
            lbOverviewOfEmployees.Items.AddRange(Shop.em.GetEmployeeDepartment(LoggedEmployee.Department));
        }

        private void btnSetShift_Click(object sender, EventArgs e)
        {
            //Shop.CreateShift(tbEmployeeId.Text, mCShiftDate.SelectionStart.Date, dtShiftStart.Value, dtShiftEnd.Value);
        }

        private void btnViewAvailability_Click(object sender, EventArgs e)
        {
            Forms.ManagerChildForms.EmployeeAvailabilityForm employeeAvailabilityForm = new Forms.ManagerChildForms.EmployeeAvailabilityForm(Shop, LoggedEmployee);
            employeeAvailabilityForm.Show();
        }
    }
}
