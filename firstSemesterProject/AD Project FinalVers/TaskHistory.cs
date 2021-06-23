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
    public partial class TaskHistory : Form
    {
        public TaskHistory()
        {
            InitializeComponent();
        }

        private void TaskHistory_Load(object sender, EventArgs e)
        {
            foreach (string item in StudentLogIn.taskFeedback)
            {
                lBTaskHistory.Items.Add(item);
            }
        }

        private void TaskHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
