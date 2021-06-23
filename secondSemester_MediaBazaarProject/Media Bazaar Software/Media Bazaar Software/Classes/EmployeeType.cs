using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Media_Bazaar_Software.Classes
{
    public class EmployeeType
    {
        public string Type { get; private set; }
        public decimal WagePerHour { get; set; }

        public EmployeeType(string type, decimal wagePerHour)
        {
            Type = type;
            WagePerHour = wagePerHour;
        }
        public EmployeeType(string type)
        { Type = type; }

        public override string ToString()
        {
            return $"{Type} - {WagePerHour}€/h";
        }
    }
}
