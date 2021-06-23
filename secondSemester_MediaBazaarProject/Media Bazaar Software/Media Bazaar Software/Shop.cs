using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Properties;
using Media_Bazaar_Software.ManagerClasses;
using Media_Bazaar_Software.Interfaces;
using Media_Bazaar_Software.Forms;
using Media_Bazaar_Software.Exceptions;
using Media_Bazaar_Software.DatabaseLoad;
using Media_Bazaar_Software.Classes;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using Media_Bazaar_Software.ShiftGenerator;
using System.Security.Cryptography;

namespace Media_Bazaar_Software
{
    public class Shop
    {
        public DepartmentManager dm { get; private set; }
        public EmployeeTypeManager etm { get; private set; }
        public EmployeeManager em { get; private set; }
        public ItemManager im { get; private set; }
        public FeedbackManager fm { get; private set; }
        public ShiftManager sm { get; private set; }
        public PreferenceManager pm { get; private set; }
        public RequestManager rm { get; private set; }
        public BundleManager bm { get; private set; }

        public Shop()
        {
            dm = new DepartmentManager();
            etm = new EmployeeTypeManager();
            em = new EmployeeManager();
            im = new ItemManager();
            sm = new ShiftManager();
            fm = new FeedbackManager();
            pm = new PreferenceManager();
            rm = new RequestManager();
            bm = new BundleManager();
        }

    }
}
