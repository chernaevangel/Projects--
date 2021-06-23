using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_Project_FinalVers
{
    public partial class StudentLogIn : Form
    {

        #region Variables
        private int weeks = 1;

        private bool bathroom = false;
        private bool living = false;
        private bool trash = false;

        private StudentHouse SH;
        private Student newStudentA;
        private Student newStudentB;
        private Student newStudentC;
        private Event newEvent;
        private Expense newExpense;

        private string[] agreements;
        private string[] rules;
        private string[] shoppingList;
        private string[] feedback;

        public static List<string> taskFeedback = new List<string>();

        //private string[] tasks;
        Event[] allEvents;
        #endregion

        public StudentLogIn(StudentHouse SH, Student A, Student B, Student C)
        {
            this.SH = SH;
            this.newStudentA = A;
            this.newStudentB = B;
            this.newStudentC = C;
            InitializeComponent();
           // LoadPage();

        }
        
        #region PageSettings
        private void LoadPage()
        {
            rules = SH.ShowRules();
            agreements = SH.ShowAgreements();
            shoppingList = SH.GetShoppingList();
            feedback = SH.GetFeedback();
            for (int i = 0; i < rules.Length; i++)
            {
                lbRules.Items.Add(rules[i]);
            }
            for (int i = 0; i < agreements.Length; i++)
            {
                lbAgreemants.Items.Add(agreements[i]);
            }
            for (int i = 0; i < shoppingList.Length; i++)
            {
                lBShoppingList.Items.Add(shoppingList[i]);
            }
            for (int i = 0; i < SH.expensesA.Count; i++)
            {
                cBWalletA.Items.Add($"{SH.expensesA[i].Name} - {Math.Round(SH.expensesA[i].Amount / 3, 2)}€");
            }
            for (int i = 0; i < SH.expensesB.Count; i++)
            {
                cBWalletB.Items.Add($"{SH.expensesB[i].Name} - {Math.Round(SH.expensesB[i].Amount / 3, 2)}€");
            }
            for (int i = 0; i < SH.expensesC.Count; i++)
            {
                cBWalletC.Items.Add($"{SH.expensesC[i].Name} - {Math.Round(SH.expensesC[i].Amount / 3, 2)}€");
            }
            lblPay1.Text = $"{lblPay1.Text}{Math.Round(SH.SumExpenses(SH.expensesA) / 3, 2)}€";
            lblPay2.Text = $"{lblPay2.Text}{Math.Round(SH.SumExpenses(SH.expensesB) / 3, 2)}€";
            lblPay3.Text = $"{lblPay3.Text} {Math.Round(SH.SumExpenses(SH.expensesC) / 3, 2)}€";
            SH.task = SH.JoinTaskDoer();
            lblStudent1.Text = "";
            lblStudent2.Text = "";
            lblStudent3.Text = "";
            lblStudent1.Text = $"{SH.task[0]}";
            lblStudent2.Text = $"{SH.task[1]}";
            lblStudent3.Text = $"{SH.task[2]}";
            dTPEventDate.Value = DateTime.Now;
            living = SH.taskA.Status;
            bathroom = SH.taskB.Status;
            trash = SH.taskC.Status;
            if (living)
            {
                SH.CompleteTask(TaskTypes.LIVINGAREA);
                lblStudent1.BackColor = Color.LimeGreen;
                lblKandL.BackColor = Color.LimeGreen;
            }
            if (bathroom)
            {
                SH.CompleteTask(TaskTypes.BATHROOM);
                lblStudent2.BackColor = Color.LimeGreen;
                lblBandT.BackColor = Color.LimeGreen;
            }
            if (trash)
            {
                SH.CompleteTask(TaskTypes.TRASH);
                lblStudent3.BackColor = Color.LimeGreen;
                lblTrash.BackColor = Color.LimeGreen;
            }
            //CheckLabels();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CheckLabels()
        {
            if (Form1.loggedStudent == " - Student A")
            {
                if (lblStudent1.Text.EndsWith("A"))
                {
                    cBKandL.Enabled = true;
                    cBBandT.Enabled = false;
                    cBTrash.Enabled = false;
                }
                else if (lblStudent2.Text.EndsWith("A"))
                {
                    cBBandT.Enabled = true;
                    cBKandL.Enabled = false;
                    cBTrash.Enabled = false;
                }
                if (lblStudent3.Text.EndsWith("A"))
                {
                    cBTrash.Enabled = true;
                    cBBandT.Enabled = false;
                    cBKandL.Enabled = false;
                }
            }
            if (Form1.loggedStudent == " - Student B")
            {
                if (lblStudent1.Text.EndsWith("B"))
                {
                    cBKandL.Enabled = true;
                    cBBandT.Enabled = false;
                    cBTrash.Enabled = false;
                }
                else if (lblStudent2.Text.EndsWith("B"))
                {
                    cBBandT.Enabled = true;
                    cBKandL.Enabled = false;
                    cBTrash.Enabled = false;
                }
                if (lblStudent3.Text.EndsWith("B"))
                {
                    cBTrash.Enabled = true;
                    cBBandT.Enabled = false;
                    cBKandL.Enabled = false;
                }
            }
            if (Form1.loggedStudent == " - Student C")
            {
                if (lblStudent1.Text.EndsWith("C"))
                {
                    cBKandL.Enabled = true;
                    cBBandT.Enabled = false;
                    cBTrash.Enabled = false;
                }
                else if (lblStudent2.Text.EndsWith("C"))
                {
                    cBBandT.Enabled = true;
                    cBKandL.Enabled = false;
                    cBTrash.Enabled = false;
                }
                if (lblStudent3.Text.EndsWith("C"))
                {
                    cBTrash.Enabled = true;
                    cBBandT.Enabled = false;
                    cBKandL.Enabled = false;
                }
            }
        }
        #endregion

        #region Agreements
        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            lbAgreemants.Items.Clear();
            SH.AddAgreement(tBAgreements.Text);
            agreements = SH.ShowAgreements();
            for (int i = 0; i < agreements.Length; i++)
            {
                lbAgreemants.Items.Add(agreements[i]);
            }
            tBAgreements.Text = "";
        }

        private void btnRemoveAgreement_Click(object sender, EventArgs e)
        {
            if (lbAgreemants.SelectedIndex >= 0)
            {
                SH.RemoveAgreement(lbAgreemants.SelectedIndex);
                agreements = SH.ShowAgreements();
                lbAgreemants.Items.Clear();
                for (int i = 0; i < agreements.Length; i++)
                {
                    lbAgreemants.Items.Add(agreements[i]);
                }
            }
        }
        #endregion

        #region Feedback
        private void btnAddFeedback_Click(object sender, EventArgs e)
        {
            if (rbStudentA.Checked)
            { SH.AddFeedback(rbStudentA.Text, tBFeedback.Text); }
            else if (rBStudentB.Checked)
            { SH.AddFeedback(rBStudentB.Text, tBFeedback.Text); }
            else if (rBStudentC.Checked)
            { SH.AddFeedback(rBStudentC.Text, tBFeedback.Text); }
        }

        private void btnShowFeedback_Click(object sender, EventArgs e)
        {
            string[] temp = SH.GetFeedback();
            for (int i = 0; i < temp.Length; i++)
            {
                lbFeedback.Items.Add(temp[i]);
            }
        }
        #endregion

        #region Events
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            newEvent = new Event(tBCreateEvent.Text, dTPEventDate.Value.Date);
            SH.AddEvent(newEvent);
            allEvents = SH.GetEvents();
            for (int i = 0; i < allEvents.Length; i++)
            {
                mCEvents.AddBoldedDate(allEvents[i].Date);
            }
            mCEvents.UpdateBoldedDates();
        }
        private void mCEvents_DateChanged(object sender, DateRangeEventArgs e)
        {
            string s = e.Start.ToShortDateString();
            lblShowSelectedEvent.Text = SH.GetEventInfo(s);
        }
        #endregion

        #region ShoppingList
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (rBPaper.Checked)
            {
                SH.AddToShoppingList(rBPaper.Text);
                lBShoppingList.Items.Add(rBPaper.Text);
            }
            else if (rBSoap.Checked)
            {
                SH.AddToShoppingList(rBSoap.Text);
                lBShoppingList.Items.Add(rBSoap.Text);
            }
            else if (rbBar.Checked)
            {
                SH.AddToShoppingList(rbBar.Text);
                lBShoppingList.Items.Add(rbBar.Text);
            }
            else if (rBCleaning.Checked)
            {
                if (tBCleaning.Text != "")
                {
                    SH.AddToShoppingList(tBCleaning.Text);
                    lBShoppingList.Items.Add(tBCleaning.Text);
                    tBCleaning.Text = "";
                }
                else { MessageBox.Show("Please pick an item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else if (rBSpices.Checked)
            {
                if (tBSpices.Text != "")
                {
                    SH.AddToShoppingList(tBSpices.Text);
                    lBShoppingList.Items.Add(tBSpices.Text);
                    tBSpices.Text = "";
                }
                else { MessageBox.Show("Please pick an item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (rBOil.Checked)
            {
                SH.AddToShoppingList(rBOil.Text);
                lBShoppingList.Items.Add(rBOil.Text);
            }
            else if (rBOtherItem.Checked)
                if (tBOtherItem.Text != "")
                {
                    SH.AddToShoppingList(tBOtherItem.Text);
                    lBShoppingList.Items.Add(tBOtherItem.Text);
                    tBOtherItem.Text = "";
                }
                else { MessageBox.Show("Please pick an item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void rBCleaning_CheckedChanged(object sender, EventArgs e)
        {
            if (tBCleaning.Enabled)
            { tBCleaning.Enabled = false; }
            else { tBCleaning.Enabled = true; }
        }
        private void rBSpices_CheckedChanged(object sender, EventArgs e)
        {
            if (tBSpices.Enabled)
            { tBSpices.Enabled = false; }
            else { tBSpices.Enabled = true; }
        }
        private void rBOtherItem_CheckedChanged(object sender, EventArgs e)
        {
            if (tBOtherItem.Enabled)
            { tBOtherItem.Enabled = false; }
            else { tBOtherItem.Enabled = true; }
        }

        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            if (lBShoppingList.SelectedIndex >= 0)
            {
                SH.RemoveFromShoppingList(lBShoppingList.SelectedIndex);
                lBShoppingList.Items.RemoveAt(lBShoppingList.SelectedIndex);
            }
        }
        #endregion

        #region Expenses
        private void button5_Click(object sender, EventArgs e)
        {
            newExpense = new Expense(tBPurchasedItem.Text, Math.Round(Convert.ToDouble(nUDPrice.Value), 2, 0));

            SH.AddExpense(SH.expensesA, newExpense);
            SH.AddExpense(SH.expensesB, newExpense);
            SH.AddExpense(SH.expensesC, newExpense);

            cBWalletA.Items.Add($"{newExpense.Name} - {Math.Round(newExpense.Amount / 3, 2)}€");
            cBWalletB.Items.Add($"{newExpense.Name} - {Math.Round(newExpense.Amount / 3, 2)}€");
            cBWalletC.Items.Add($"{newExpense.Name} - {Math.Round(newExpense.Amount / 3, 2)}€");

            lblPay1.Text = "";
            lblPay1.Text = $"{lblPay1.Text}{Math.Round(SH.SumExpenses(SH.expensesA) / 3, 2)}€";
            lblPay2.Text = "";
            lblPay2.Text = $"{lblPay2.Text}{Math.Round(SH.SumExpenses(SH.expensesB) / 3, 2)}€";
            lblPay3.Text = "";
            lblPay3.Text = $"{lblPay3.Text} {Math.Round(SH.SumExpenses(SH.expensesC) / 3, 2)}€";
        }
        private string Payment(List<Expense> expenses, ComboBox comboBox)
        {
            if (comboBox.SelectedIndex > -1)
            {
                expenses.RemoveAt(comboBox.SelectedIndex);

                string text;
                text = $"{Math.Round(SH.SumExpenses(expenses) / 3, 2)}€";

                comboBox.Items.Remove(comboBox.SelectedItem);

                if (comboBox.Items.Count == 1)
                {
                    comboBox.Text = "";
                }

                return text;
            }
            else
            {

                return "No item selected";
            }
        }

        private void btnStudentPay1_Click(object sender, EventArgs e)
        {
            lblPay1.Text = "";
            lblPay1.Text = lblPay1.Text + Payment(SH.expensesA, cBWalletA);
            cBWalletA.Text = "";
        }


        private void btnStudentPay2_Click(object sender, EventArgs e)
        {
            lblPay2.Text = "";
            lblPay2.Text = lblPay2.Text + Payment(SH.expensesB, cBWalletB);
            cBWalletB.Text = "";
        }

        private void btnStudentPay3_Click(object sender, EventArgs e)
        {
            lblPay3.Text = "";
            lblPay3.Text = lblPay3.Text + Payment(SH.expensesC, cBWalletC);
            cBWalletC.Text = "";
        }
        #endregion

        #region Tasks
        private void btnViewNextWeek_Click(object sender, EventArgs e)
        {
            if (!cBKandL.Checked)
            {
                taskFeedback.Add($"Week:{weeks}{lblStudent1.Text} did not finish his task!");
            }
            if (!cBBandT.Checked)
            {
                taskFeedback.Add($"Week:{weeks}{lblStudent2.Text} did not finish his task!");
            }
            if (!cBTrash.Checked)
            {
                taskFeedback.Add($"Week:{weeks}{lblStudent3.Text} did not finish his task!");
            }
            cBBandT.Checked = false;
            lblStudent1.BackColor = Color.Bisque;
            lblKandL.BackColor = Color.Bisque;
            cBKandL.Checked = false;
            lblStudent2.BackColor = Color.Bisque;
            lblBandT.BackColor = Color.Bisque;
            cBTrash.Checked = false;
            lblStudent3.BackColor = Color.Bisque;
            lblTrash.BackColor = Color.Bisque;
            SH.task = SH.JoinTaskDoer();
            SH.task = SH.TaskRotateF();
            lblStudent1.Text = "";
            lblStudent2.Text = "";
            lblStudent3.Text = "";
            lblStudent1.Text = $" - {SH.task[0]}";
            lblStudent2.Text = $" - {SH.task[1]}";
            lblStudent3.Text = $" - {SH.task[2]}";
            CheckLabels();
            weeks++;
        }

        private void cBKandL_CheckedChanged(object sender, EventArgs e)
        {
            if (cBKandL.Checked)
            {
                if (Form1.loggedStudent == lblStudent1.Text)
                {
                    SH.CompleteTask(TaskTypes.LIVINGAREA);
                    lblStudent1.BackColor = Color.LimeGreen;
                    lblKandL.BackColor = Color.LimeGreen;
                }
            }
        }

        private void cBBandT_CheckedChanged(object sender, EventArgs e)
        {
            if (cBBandT.Checked)
            {
                if (Form1.loggedStudent == lblStudent2.Text)
                {
                    SH.CompleteTask(TaskTypes.BATHROOM);
                    lblStudent2.BackColor = Color.LimeGreen;
                    lblBandT.BackColor = Color.LimeGreen;
                }
            }
        }

        private void cBTrash_CheckedChanged(object sender, EventArgs e)
        {
            if (cBTrash.Checked)
            {
                if (Form1.loggedStudent == lblStudent3.Text)
                {
                    SH.CompleteTask(TaskTypes.TRASH);
                    lblStudent3.BackColor = Color.LimeGreen;
                    lblTrash.BackColor = Color.LimeGreen;
                }
            }
        }
        #endregion

        private void StudentLogIn_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage5"])
            {
                CheckLabels();
            }
        }
    }
}
