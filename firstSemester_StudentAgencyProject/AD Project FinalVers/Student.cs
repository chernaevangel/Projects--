using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Project_FinalVers
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string nationality;
        private string room;
        private DateTime dateOfBirth;
        public string DateOfBirth
        { get { return this.dateOfBirth.ToShortDateString(); } }
        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public string Nationality { get { return this.nationality; } }
        public string Room { get { return this.room; } }
        public string GetStudentInfo()
        { return this.firstName + this.lastName; }
        public Student(string fn, string ln, string nat, string room, DateTime dob)
        {
            this.firstName = fn;
            this.lastName = ln;
            this.nationality = nat;
            this.room = room;
            this.dateOfBirth = dob;
        }
        public Student(string fn)
        {
            this.firstName = fn;
        }
    }
}
