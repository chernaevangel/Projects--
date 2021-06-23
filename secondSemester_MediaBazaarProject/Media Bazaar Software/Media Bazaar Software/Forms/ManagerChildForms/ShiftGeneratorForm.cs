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
using Media_Bazaar_Software.ShiftGenerator;


namespace Media_Bazaar_Software.Forms.ManagerChildForms
{
    public partial class ShiftGeneratorForm : Form
    {
        Shop Shop;
        Employee LoggedEmployee;
        Generator Generator;
        public ShiftGeneratorForm(Shop shop, Employee employee)
        {
            InitializeComponent();
            Shop = shop;
            LoggedEmployee = employee;
            UpdateTreeView();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cBEmployeeType.SelectedIndex > -1)
            {
                if (GetEmployees().Count > (int)nudAmountOfPeople.Value)
                {
                    List<string> days = CheckCheckBoxes();
                    Generator = new Generator(Shop, days.ToArray(), (int)nudAmountOfPeople.Value, LoggedEmployee.Department, cBEmployeeType.Text);
                    MessageBox.Show("Shifts successfully generated!");
                }
                else { MessageBox.Show("Not enough employees available!"); }
            }
            else { MessageBox.Show("Please select employee type first!"); }
/*            if (cBEmployeeType.SelectedIndex == 1)
            {
                if (GetEmployees().Count > (int)nudAmountOfPeople.Value)
                {
                    List<string> days = CheckCheckBoxes();
                    Generator = new Generator(Shop, days.ToArray(), (int)nudAmountOfPeople.Value, LoggedEmployee.Department, cBEmployeeType.Text);
                    MessageBox.Show("Shifts successfully generated!");
                }
                else { MessageBox.Show("Not enough employees available!"); }
            }
            else { MessageBox.Show("Please select employee type first!");
        }*/
        }


        public List<string> CheckCheckBoxes()
        {
            List<string> checkedCB = new List<string>();
            CheckBox[] checkBoxes = { cbMonday, cbTuesday, cbWednesday, cbThursday, cbFriday, cbSaturday, cbSuday };
            foreach (CheckBox cb in checkBoxes)
            {
                if (cb.Checked)
                {
                    checkedCB.Add(cb.Text);
                }
            }
            return checkedCB;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ClearNodes(tVShiftDays);
            List<Shift> temp = Shop.sm.GetAllShifts().ToList();
                foreach (TreeNode node in tVShiftDays.Nodes)
                {
                    foreach (TreeNode childNode in node.Nodes)
                    {
                        foreach (Shift shift in temp)
                        {
                            if (node.ToString().Contains(shift.Day) && childNode.ToString().Contains(shift.TimeSlot))
                            {
                              childNode.Nodes.Add($"({shift.Employee.Id}){shift.Employee.FirstName}");
                            }
                        }
                    }
                }
        }
        private List<Employee> GetEmployees()
        {
            List<Employee> temp = new List<Employee>();
            foreach (Employee employee in Shop.em.GetEmployeeDepartment(LoggedEmployee.Department))
            {
                if (employee.EmployeeType == cBEmployeeType.Text)
                {
                    temp.Add(employee);
                }
            }
            return temp;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            cbMonday.Checked = true;
            cbTuesday.Checked = true;
            cbWednesday.Checked = true;
            cbThursday.Checked = true;
            cbFriday.Checked = true;
            cbSaturday.Checked = true;
            cbSuday.Checked = true;
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            cbMonday.Checked = false;
            cbTuesday.Checked = false;
            cbWednesday.Checked = false;
            cbThursday.Checked = false;
            cbFriday.Checked = false;
            cbSaturday.Checked = false;
            cbSuday.Checked = false;
        }

        private TreeNode[] GetNodes(TreeView tree)
        {
            List<TreeNode> temp = new List<TreeNode>();
            foreach (TreeNode node in tree.Nodes)
            {
                temp.Add(node);
            }
            return temp.ToArray();
        }
        private void ClearNodes(TreeView tree)
        {
            foreach (TreeNode node in tree.Nodes)
            {
                foreach (TreeNode childNodes in node.Nodes)
                {
                    childNodes.Nodes.Clear();
                }
            }
        }
        public DateTime[] CalculateWeeklyDates()
        {
            List<DateTime> days = new List<DateTime>();
            DateTime currentTime = DateTime.Now;
            DayOfWeek dayOfWeek = currentTime.DayOfWeek;
            int indexDay = (int)dayOfWeek;
            DateTime sunday = currentTime.AddDays(-indexDay);
            days.Add(sunday);

            for (int i = 1; i <= 6; i++)
            {
                days.Add(sunday.AddDays(i));
            }
            return days.ToArray();
        }
        public void UpdateTreeView()
        {
            int index = 0;
            foreach (TreeNode node in tVShiftDays.Nodes)
            {
                node.Text += $"{CalculateWeeklyDates()[index++].ToString(" dd/MMMM/yyyy")}";
            }
        }
    }
}
