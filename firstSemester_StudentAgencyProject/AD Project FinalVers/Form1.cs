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
    public partial class Form1 : Form
    {
        public static StudentHouse SH = new StudentHouse("SHBV");
        public static Student A;
        public static Student B;
        public static Student C;
        StudentLogIn sLog = new StudentLogIn(SH, A, B, C);
        DeveloperLogIn dLog = new DeveloperLogIn(SH, A, B, C);
        public static string loggedStudent = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string output = SH.LogIn(tBUserName.Text, tBPassword.Text);
            if (output == "admin")
            {
                dLog.Show();
                tBPassword.Text = "";
                tBUserName.Text = "";
            }
            else if (output == "student")
            {
                tBPassword.Text = "";
                tBUserName.Text = "";
                loggedStudent = "SHBV";
                sLog.Show();
            }
            else if (tBUserName.Text != "" && tBPassword.Text != "")
            {
                if (File.ReadAllLines("RoomA.txt").Contains($" (Username: {tBUserName.Text }) ") && (File.ReadAllLines("RoomA.txt").Contains($" (Password: {tBPassword.Text})")))
                {
                    tBUserName.Text = "";
                    tBPassword.Text = "";
                    loggedStudent = " - Student A";
                    sLog.Show();
                }
                if (File.ReadAllLines("RoomB.txt").Contains($" (Username: {tBUserName.Text }) ") && (File.ReadAllLines("RoomB.txt").Contains($" (Password: {tBPassword.Text})")))
                {
                    tBUserName.Text = "";
                    tBPassword.Text = "";
                    loggedStudent = " - Student B";
                    sLog.Show();
                }
                if (File.ReadAllLines("RoomC.txt").Contains($" (Username: {tBUserName.Text }) ") && (File.ReadAllLines("RoomC.txt").Contains($" (Password: {tBPassword.Text})")))
                {
                    tBUserName.Text = "";
                    tBPassword.Text = "";
                    loggedStudent = " - Student C";
                    sLog.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBUserName.Text = "";
                tBPassword.Text = "";
            }
        }
    }
}
