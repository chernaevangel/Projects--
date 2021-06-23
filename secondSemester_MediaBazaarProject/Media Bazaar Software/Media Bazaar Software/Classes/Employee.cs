using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Media_Bazaar_Software.Classes
{
    public class Employee
    {
        //Instance Variables
        static List<char> chars = new List<char>();
        private Email MBEmail;
        private string department;
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Birthday { get; private set; }
        public string PhoneNumber { get; private set; }
        public double HoursWorked { get; private set; }
        public string EmployeeType { get; private set; }
        public string Department { get { return department; } set { department = value; } }
        public string Email { get; private set; }
        public string Password { get; private set; }


        //Class constructors
        public Employee(string firstName, string lastName, string birthday, string phoneNumber, string employeeType, string department, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            EmployeeType = employeeType;
            Department = department;
            Email = $"{firstName.ToLower()}{lastName.ToLower()}@media-bazaar.com";
            Password = GeneratePassword(MBEmail, email);
        }
        public Employee(string firstName, string lastName, string birthday, string phoneNumber, string employeeType, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            EmployeeType = employeeType;
            Email = $"{firstName.ToLower()}{lastName.ToLower()}@media-bazaar.com";
            Password = GeneratePassword(MBEmail, email);
        }
        public Employee(int id, string firstName, string lastName, string birthday, string phoneNumber, string employeeType, string department, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            EmployeeType = employeeType;
            Department = department;
            Email = email;
            Password = password;
        }
        public Employee(int id, string firstName, string lastName, string birthday, string phoneNumber, string employeeType, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            EmployeeType = employeeType;
            Email = email;
            Password = password;
        }
        //Class Methods
        #region Password
        private string GeneratePassword(Email email, string mail)
        {
            AddChars(ref chars);
            string Password;
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                sb.Append(chars[rnd.Next(0, chars.Count)]);
            }
            Password = sb.ToString();
            SendEmail(mail, Password, FirstName, email);
            byte[] source;
            byte[] hash;
            source = ASCIIEncoding.ASCII.GetBytes(Password);
            hash = new MD5CryptoServiceProvider().ComputeHash(source);
            string input = BitConverter.ToString(hash).ToLower().Replace("-", "");
            return input;
        }

        private static void AddChars(ref List<char> chars)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                chars.Add(c);
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                chars.Add(c);
            }
            for (char c = '0'; c <= '9'; c++)
            {
                chars.Add(c);
            }
        }
        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            {
                byte[] source;
                byte[] hash;
                source = ASCIIEncoding.ASCII.GetBytes(newPassword);
                hash = new MD5CryptoServiceProvider().ComputeHash(source);
                string input = BitConverter.ToString(hash).ToLower().Replace("-", "");
                Password = input;
            }
        }
        #endregion
        public override string ToString()
        {
            return $"{FirstName} {LastName}({Id}) - {EmployeeType}";
        }
        public string GetFullInformation()
        {
            if (Department == null)
            { return $"{FirstName} {LastName}({Id}) - {EmployeeType} \n Contact Information: {Email} / {PhoneNumber}"; }
            else { return $"{FirstName} {LastName}({Id}) - {EmployeeType} from {Department} \n Contact Information: {Email} / {PhoneNumber}"; }
        }
        private void SendEmail(string email, string password, string fName, Email mbemail)
        {
            mbemail = new Email(email,Email, password, fName);
        }
    }
}
