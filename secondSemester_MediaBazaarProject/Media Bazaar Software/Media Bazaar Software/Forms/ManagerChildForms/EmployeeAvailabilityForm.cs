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
    public partial class EmployeeAvailabilityForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        public EmployeeAvailabilityForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
            lbPreferences.Items.AddRange(Shop.pm.GetAllPreferences(LoggedEmployee.Department));
        }
    }
}
