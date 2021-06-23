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

namespace Media_Bazaar_Software.UI.EmployeeChildForms
{
    public partial class Schedule : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public Schedule(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
            monthCalendar1.TrailingForeColor = Color.Beige;
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            lbShifts.Items.Clear();
            if (Shop.sm.GetShifts(LoggedEmployee.Id).Length <= 0)
            {
                lbShifts.Items.Add("You have no upcoming shifts!");
            }
            else {lbShifts.Items.AddRange(Shop.sm.GetShifts(LoggedEmployee.Id)); }
            
        }

        private void btnSetPreference_Click(object sender, EventArgs e)
        {
            Forms.ManagerChildForms.PreferenceForm preferenceForm = new Forms.ManagerChildForms.PreferenceForm(Shop, LoggedEmployee);
            preferenceForm.Show();
        }


    }
}
