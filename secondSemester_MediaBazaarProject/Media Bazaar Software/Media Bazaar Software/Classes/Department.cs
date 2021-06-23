using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Exceptions;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Media_Bazaar_Software.Classes
{
    public class Department
    {
        //Instance variables
        public string Name { get; private set; }
        public int ManagerId { get; private set; }

        //Class Constructor
        public Department(string name)
        {
            Name = name;
        }
        public Department(string name, int id)
        {
            Name = name;
            ManagerId = id;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
