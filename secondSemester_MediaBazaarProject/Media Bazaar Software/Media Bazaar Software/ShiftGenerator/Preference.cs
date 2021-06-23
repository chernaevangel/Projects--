using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Bazaar_Software.ShiftGenerator
{
    public class Preference
    {
        public int EmployeeId { get; private set; }
        public DateTime Date { get; private set; }
        public DayOfWeek Day { get; private set; }
        public string Availability { get; private set; }

        public Preference(int employeeId, DateTime date, string availability)
        {
            EmployeeId = employeeId;
            Date = date;
            Day = Date.DayOfWeek;
            Availability = availability;
        }

        public override string ToString()
        {
            return $"{EmployeeId} : {Date.ToShortDateString()} - {Day} - {Availability}";
        }
    }
}
