using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Project_FinalVers
{
    public class Event
    {
        private string description;
        private DateTime date;
        private Student creator;

        public string Description { get { return this.description; } }
        public string DateString { get { return this.date.ToShortDateString(); } }
        public DateTime Date { get { return this.date; } }
        public Event(string d, DateTime date, Student c)
        {
            this.description = d;
            this.date = date;
            this.creator = c;
        }
        public Event(string d, DateTime date)
        {
            this.description = d;
            this.date = date;
        }
        public string GetInfo()
        { return $"{this.creator} - {this.description} on {this.date}"; }
    }
}
