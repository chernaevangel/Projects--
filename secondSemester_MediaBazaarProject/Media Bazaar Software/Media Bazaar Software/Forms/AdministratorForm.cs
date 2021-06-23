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
using Media_Bazaar_Software.UI.AdministratorChildForms;

namespace Media_Bazaar_Software.UI
{
    public partial class AdministratorForm : Form
    {
        bool Hidden;
        Employee LoggedEmployee;
        Shop Shop;
        private Form currentChildForm;
        public AdministratorForm(Shop shop, Employee loggedEmployee)
        {
            InitializeComponent();
            LoggedEmployee = loggedEmployee;
            Shop = shop;
            Hidden = false;
            ucLoggedUser.txtName = $"{LoggedEmployee.FirstName} {loggedEmployee.LastName}";
            ucLoggedUser.txtEmail = $"{loggedEmployee.Email}";
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelMenu.Width = panelMenu.Width + 10;
                if (panelMenu.Width >= 382)
                {
                    menuTimer.Stop();
                    Hidden = false;
                }
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 10;
                if (panelMenu.Width <= 80)
                {
                    menuTimer.Stop();
                    Hidden = true;
                }
            }
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            { currentChildForm.Close(); }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelTab.Controls.Add(childForm);
            panelTab.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MovePanel2(Button button)
        {
            panel2.Visible = true;
            panel2.Height = button.Height;
            panel2.Top = button.Top;
            panel2.Left = button.Left;
            btnDepartment.BackColor = Color.FromArgb(24, 30, 54);
            btnFinances.BackColor = Color.FromArgb(24, 30, 54);
            btnInventory.BackColor = Color.FromArgb(24, 30, 54);
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
            button.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            MovePanel2(btnDepartment);
            OpenChildForm(new AdministratorChildForms.DepartmentManagment(Shop, LoggedEmployee));
        }

        private void btnFinances_Click(object sender, EventArgs e)
        {
            MovePanel2(btnFinances);
            OpenChildForm(new AdministratorChildForms.FinancesForm(Shop, LoggedEmployee));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MovePanel2(btnInventory);
            OpenChildForm(new AdministratorChildForms.InventoryManagerForm(Shop, LoggedEmployee));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MovePanel2(btnSettings);
            OpenChildForm(new SettingsForm(Shop, LoggedEmployee));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
