using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Project_FinalVers
{
    public class Account
    { 
            private string username;
            private string password;
            private Student owner;
            static List<char> chars = new List<char>();
        public string GetOwner
        { get { return this.owner.GetStudentInfo(); } }
        public string Username
        { get { return this.username; } }
        public string Password
        { get { return this.password; } }

        #region Username
        public string SetUserName()
        {
            string Username;
            Random random = new Random();
            Username = $"Usr{random.Next(10000, 99999)}";
            this.username = Username;
            return this.username;
        }
        public string GetUsername()
        {
            return this.username;
        }
        #endregion

        #region Password
        public string SetPassword()
        {
            addChars(ref chars);
            string Password;
            int length = 6;
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            int j = 0;
            while (j < length)
            {
                sb.Append(chars[rnd.Next(0, chars.Count)]);
                j++;
            }
            Password = sb.ToString();
            this.password = Password;
            return this.password;
        }
        static void addChars(ref List<char> chars)
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

        public string GetPassword()
        {
            return this.password;
        }
        #endregion

        public string GetLogInInfo()
        {
            return $"{this.username}{this.password}";
        }
        
        public Account(string usr, string pas, Student owner)
        {
            this.username = usr;
            this.password = pas;
            this.owner = owner;

        }
        public Account()
        {
            this.username = "";
            this.password = "";
            this.owner = null;
        }
    }
    }

