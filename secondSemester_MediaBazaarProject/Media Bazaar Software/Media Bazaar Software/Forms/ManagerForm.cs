using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media_Bazaar_Software.UserControls;
using Media_Bazaar_Software.Classes;

namespace Media_Bazaar_Software.UI
{
    public partial class ManagerForm : Form
    {
        bool Hidden;
        private Form currentChildForm;
        Employee LoggedEmployee;
        Shop Shop;
        public ManagerForm(Shop shop, Employee loggedEmployee)
        {
            InitializeComponent();
            LoggedEmployee = loggedEmployee;
            Shop = shop;
            Hidden = false;
            ucLoggedUser.txtName = $"{LoggedEmployee.FirstName} {loggedEmployee.LastName}";
            ucLoggedUser.txtEmail = $"{loggedEmployee.Email}";
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            panel2.BringToFront();
            btnSchedule.BackColor = Color.FromArgb(24, 30, 54);
            btnFeedback.BackColor = Color.FromArgb(24, 30, 54);
            btnInventory.BackColor = Color.FromArgb(24, 30, 54);
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
            btnEmployeeOverview.BackColor = Color.FromArgb(24, 30, 54);
            button.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnShowMenu_Click_1(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            MovePanel2(btnSchedule);
            OpenChildForm(new Forms.ManagerChildForms.ShiftGeneratorForm(Shop, LoggedEmployee));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventory_Click_2(object sender, EventArgs e)
        {
            MovePanel2(btnInventory);
            OpenChildForm(new ManagerChildForms.InventoryForm(Shop, LoggedEmployee));
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            MovePanel2(btnFeedback);
            OpenChildForm(new ManagerChildForms.FeedbackForm(Shop, LoggedEmployee));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MovePanel2(btnSettings);
            OpenChildForm(new SettingsForm(Shop, LoggedEmployee));
        }

        private void btnEmployeeOverview_Click(object sender, EventArgs e)
        {
            MovePanel2(btnEmployeeOverview);
            OpenChildForm(new ManagerChildForms.ScheduleCreatorForm(Shop, LoggedEmployee));
        }
    }
}
