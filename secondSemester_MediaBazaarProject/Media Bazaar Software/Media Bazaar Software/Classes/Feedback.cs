using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Bazaar_Software.Classes
{
    public class Feedback
    {
        //Instance Variables
        public int SenderId { get; private set; }
        public string Message { get; private set; }
        public string DateSent { get; private set; }
        public string Department { get; private set; }

        //Class Constructor
        public Feedback(int sender, string message, string dateSent)
        {
            SenderId = sender;
            Message = message;
            DateSent = dateSent;
        }
        public Feedback(int sender, string message, string dateSent, string department)
        {
            SenderId = sender;
            Message = message;
            DateSent = dateSent;
            Department = department;
        }

        //Class Methods
        public override string ToString()
        {
            return $"{DateSent} - {SenderId} : {Message}";
        }
    }
}
