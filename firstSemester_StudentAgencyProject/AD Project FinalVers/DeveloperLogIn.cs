using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AD_Project_FinalVers
{
    public partial class DeveloperLogIn : Form
    {

        #region Variables
        private StudentHouse SH;

        private Student newStudentA;
        private Student newStudentB;
        private Student newStudentC;

        private Account newAccountA;
        private Account newAccountB;
        private Account newAccountC;

        private TextWriter txt;
        private string[] rules;
        private string[] feedback;
        #endregion

        public DeveloperLogIn(StudentHouse SH, Student A, Student B, Student C)
        {
            this.SH = SH;
            this.newStudentA = A;
            this.newStudentB = B;
            this.newStudentC = C;

            InitializeComponent();
            LoadPage();
        }

        #region PageSettings
        private void LoadPage()
        {
            rules = SH.ShowRules();
            feedback = SH.GetFeedback();

            tbRoomA.Text = File.ReadAllText("RoomA.txt");
            tbRoomB.Text = File.ReadAllText("RoomB.txt");
            tbRoomC.Text = File.ReadAllText("RoomC.txt");

            for (int i = 0; i < rules.Length; i++)
            {
                lbRules.Items.Add(rules[i].ToString());
            }
            for (int i = 0; i < feedback.Length; i++)
            {
                lbFeedback.Items.Add(feedback[i]);
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Students
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "" || tbLastName.Text == "" || tbNationality.Text == "" || dTPDateOfBirth.Value == null)
            {
                MessageBox.Show("Please input all the required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (cbRoom.SelectedIndex)
                {
                    case 0:
                        DateTime dtA = dTPDateOfBirth.Value.Date;
                        Account tempA = new Account();
                        newStudentA = new Student(tbFirstName.Text, tbLastName.Text, tbNationality.Text, cbRoom.SelectedItem.ToString(), dtA);
                        tempA.SetUserName();
                        tempA.SetPassword();
                        newAccountA = new Account(tempA.GetUsername(), tempA.GetPassword(), newStudentA);
                        SH.AddTenant(newStudentA, newAccountA);
                        tbRoomA.Text = SH.GetStudentInfo(newStudentA) + SH.GetAccountInfo(newAccountA);
                        txt = new StreamWriter("RoomA.txt");
                        txt.Flush();
                        txt.Write(SH.GetStudentInfo(newStudentA) + SH.GetAccountInfo(newAccountA));
                        txt.Close();
                        tbFirstName.Text = "";
                        tbLastName.Text = "";
                        tbNationality.Text = "";
                        cbRoom.Text = "";
                        break;
                    case 1:
                        DateTime dtB = dTPDateOfBirth.Value.Date;
                        Account tempB = new Account();
                        tempB.SetUserName();
                        tempB.SetPassword();
                        newStudentB = new Student(tbFirstName.Text, tbLastName.Text, tbNationality.Text, cbRoom.SelectedItem.ToString(), dtB);
                        newAccountB = new Account(tempB.GetUsername(), tempB.GetPassword(), newStudentB);
                        SH.AddTenant(newStudentB, newAccountB);
                        tbRoomB.Text = SH.GetStudentInfo(newStudentB) + SH.GetAccountInfo(newAccountB);
                        txt = new StreamWriter("RoomB.txt");
                        txt.Flush();
                        txt.Write(SH.GetStudentInfo(newStudentB) + SH.GetAccountInfo(newAccountB));
                        txt.Close();
                        tbFirstName.Text = "";
                        tbLastName.Text = "";
                        tbNationality.Text = "";
                        cbRoom.Text = "";
                        break;
                    case 2:
                        DateTime dtC = dTPDateOfBirth.Value.Date;
                        Account tempC = new Account();
                        tempC.SetUserName();
                        tempC.SetPassword();
                        newStudentC = new Student(tbFirstName.Text, tbLastName.Text, tbNationality.Text, cbRoom.SelectedItem.ToString(), dtC);
                        newAccountC = new Account(tempC.GetUsername(), tempC.GetPassword(), newStudentC);
                        SH.AddTenant(newStudentC, newAccountC);
                        tbRoomC.Text = SH.GetStudentInfo(newStudentC) + SH.GetAccountInfo(newAccountC);
                        txt = new StreamWriter("RoomC.txt");
                        txt.Flush();
                        txt.Write(SH.GetStudentInfo(newStudentC) + SH.GetAccountInfo(newAccountC));
                        txt.Close();
                        tbFirstName.Text = "";
                        tbLastName.Text = "";
                        tbNationality.Text = "";
                        cbRoom.Text = "";
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnRemoveStudentA_Click(object sender, EventArgs e)
        {
            tbRoomA.Text = "ROOM-A";
            txt = new StreamWriter("RoomA.txt");
            txt.Flush();
            txt.Close();
            SH.RemoveTenant(newStudentA, newAccountA);
        }

        private void btnRemoveStudentB_Click(object sender, EventArgs e)
        {
            tbRoomB.Text = "ROOM-B";
            txt = new StreamWriter("RoomB.txt");
            txt.Flush();
            txt.Close();
            SH.RemoveTenant(newStudentB, newAccountB);
        }

        private void btnRemoveStudentC_Click(object sender, EventArgs e)
        {
            tbRoomC.Text = "ROOM-C";
            txt = new StreamWriter("RoomB.txt");
            txt.Flush();
            txt.Close();
            SH.RemoveTenant(newStudentB, newAccountB);
        }
        #endregion

        #region Rules
        private void btnAddRule_Click(object sender, EventArgs e)
        {
            if (tbAddingRules.Text != "")
            {
                lbRules.Items.Clear();
                SH.AddRule(tbAddingRules.Text);
                rules = SH.ShowRules();
                for (int i = 0; i < rules.Length; i++)
                {
                    lbRules.Items.Add(rules[i].ToString());
                }
                tbAddingRules.Text = "";
            }
        }
        private void btnAdminRemoveRules_Click(object sender, EventArgs e)
        {
            if (lbRules.SelectedIndex >= 0)
            {
                SH.RemoveRule(lbRules.SelectedIndex);
                rules = SH.ShowRules();
                lbRules.Items.Clear();
                for (int i = 0; i < rules.Length; i++)
                {
                    lbRules.Items.Add(rules[i].ToString());
                }
            }
        }
        #endregion

        #region Feedback
        private void btnAEachStudentFeedback_Click(object sender, EventArgs e)
        {
            string[] temp = SH.GetFeedback();
            if (rbAStudentA.Checked)
            {
                lbFeedback.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].StartsWith(rbAStudentA.Text))
                    { lbFeedback.Items.Add(temp[i]); }
                }
            }
            else if (rbAStudentB.Checked)
            {
                lbFeedback.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].StartsWith(rbAStudentB.Text))
                    { lbFeedback.Items.Add(temp[i]); }

                }
            }
            else if (rbAStudentC.Checked)
            {
                lbFeedback.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].StartsWith(rbAStudentC.Text))
                    { lbFeedback.Items.Add(temp[i]); }
                }
            }
            }
        #endregion

        private void btnTaskHistory_Click(object sender, EventArgs e)
        {
            TaskHistory tHistory = new TaskHistory();
            tHistory.Show();
        }
    }
}

