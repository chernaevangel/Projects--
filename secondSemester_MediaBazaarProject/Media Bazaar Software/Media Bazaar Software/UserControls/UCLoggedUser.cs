using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Bazaar_Software.UserControls
{
    public partial class UCLoggedUser : UserControl
    {
        public UCLoggedUser()
        {
            InitializeComponent();
        }
        public Image UserIcon 
        {
            get { return pbUserPicture.Image; }
            set { pbUserPicture.Image = value; }
        }
        public string txtName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string txtEmail
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }

    }
}
