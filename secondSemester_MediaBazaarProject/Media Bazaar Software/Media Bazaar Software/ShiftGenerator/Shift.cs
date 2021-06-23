using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Classes;

namespace Media_Bazaar_Software.ShiftGenerator
{
    public class Shift
    {
        public string Day { get; private set; }
        public string TimeSlot { get; private set; }
        public Employee Employee { get; private set; }

        public Shift(string day, string timeSlot, Employee employee)
        {
            Day = day;
            TimeSlot = timeSlot;
            Employee = employee;
        }

        public override string ToString()
        {
            return $"{Employee.Id} : {Day} - {TimeSlot}";
        }
    }
}
