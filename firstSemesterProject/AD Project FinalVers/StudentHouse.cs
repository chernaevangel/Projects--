using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Project_FinalVers
{
    public class StudentHouse
    {

        #region Variables
        private string name;

        public string[] task;

        private List<string> houseRules = new List<string>();
        private List<string> studentFeedback = new List<string>();
        private List<string> agreements = new List<string>();
        private List<string> shoppingList = new List<string>();
        private List<string> doer = new List<string>() { "Student A", "Student B", "Student C" };

        private List<Account> accounts;
        private List<Student> students;
        private List<Event> events;
        private List<string> getTasks = new List<string>();
        private List<Task> tasks;
        public Task taskA;
        public Task taskB;
        public Task taskC; 
        public List<Expense> expensesA = new List<Expense>();
        public List<Expense> expensesB = new List<Expense>();
        public List<Expense> expensesC = new List<Expense>();
        #endregion

        public StudentHouse(string name)
        {
            this.name = name;
            this.accounts = new List<Account>();
            this.students = new List<Student>();
            this.events = new List<Event>();
            taskA = new Task(TaskTypes.LIVINGAREA);
            taskB = new Task(TaskTypes.BATHROOM);
            taskC = new Task(TaskTypes.TRASH);
            this.tasks = new List<Task>() {taskA, taskB, taskC };
            Student admin = new Student("SHBW");
            Student house = new Student("House");
            this.students.Add(admin);
            this.students.Add(house);
            this.accounts.Add(new Account("student", "student", house));
            this.accounts.Add(new Account("admin", "admin", admin));
        }

        #region Tenants
        public bool AddTenant(Student s, Account a)
        {
            students.Add(s);
            accounts.Add(a);
            return true;
        }
        public bool RemoveTenant(Student s, Account a)
        {
            if (this.students.Contains(s))
            { this.students.Remove(s); }
            if (this.accounts.Contains(a))
            { this.accounts.Remove(a); }
            return true;
        }
        #endregion

        #region Info
        public string GetStudentInfo(Student student)
        {
            string sInf = "";
            foreach (Student s in this.students)
            {
                if (this.students.Contains(student))
                {
                    sInf = $"{s.Room} \r\n (Names: {s.FirstName} {s.LastName}) \r\n (Nationality: {s.Nationality})\r\n (Date of birth:{s.DateOfBirth}) \r\n";
                }
            }
            return sInf;
        }
        public string GetAccountInfo(Account a)
        {
            string aInf = "";
            foreach (Account acc in this.accounts)
            {
                if (this.accounts.Contains(a))
                {
                    aInf = $" (Username: {acc.GetUsername()}) \r\n (Password: {acc.GetPassword()})";
                }
            }
            return aInf;
        }
        public string LogIn(string username, string password)
        {
            string log = $"{username}{password}";
            string output = "";
            foreach (Account acc in this.accounts)
            {
                if (acc.GetLogInInfo() == log)
                {
                    if (username == "admin" && password == "admin")
                    { output = "admin"; return output; }
                    else { output = "student"; return output; }
                }
            }
            return output;
        }
        #endregion

        #region Rules
        public bool AddRule(string rule)
        {
            this.houseRules.Add(rule);
            return true;
        }
        public bool RemoveRule(int i)
        {
            this.houseRules.RemoveAt(i);
            return true;
        }
        public string[] ShowRules()
        { return this.houseRules.ToArray(); }
        #endregion

        #region Agreements
        public bool AddAgreement(string agreement)
        {
            this.agreements.Add(agreement);
            return true;
        }
        public bool RemoveAgreement(int i)
        {
            this.agreements.RemoveAt(i);
            return true;
        }
        public string[] ShowAgreements()
        { return this.agreements.ToArray(); }
        #endregion

        #region Feedback
        public bool AddFeedback(string name, string feedback)
        {
            this.studentFeedback.Add($"{name} - {feedback}");
            return true;
        }
        public bool ClearFeedback()
        {
            this.studentFeedback.Clear();
            return true;
        }
        public string[] GetFeedback()
        { return this.studentFeedback.ToArray(); }
        #endregion

        #region ShoppingList
        public bool AddToShoppingList(string item)
        {
            this.shoppingList.Add(item);
            return true;
        }
        public bool RemoveFromShoppingList(int i)
        {
                this.shoppingList.RemoveAt(i);
                return true;
        }
        public string[] GetShoppingList()
        { return this.shoppingList.ToArray(); }
        #endregion

        #region Events
        public bool AddEvent(Event e)
        {
            this.events.Add(e);
            return true;
        }
        public bool RemoveEvent(DateTime date)
        {
            string s = date.ToShortDateString();
            foreach (Event e in this.events)
            {
                if (e.DateString == s)
                { this.events.Remove(e); }
            }
            return true;
        }
        public Event[] GetEvents()
        { return this.events.ToArray(); }
        public string GetEventInfo(string dt)
        {
            string str = "";
            foreach (Event e in this.events)
            {
                if (e.DateString == dt)
                {
                    str = $"{e.DateString} - {e.Description}";
                }
            }
            return str;
        }
        #endregion

        #region Expenses
        public bool AddExpense(List<Expense> exp, Expense ex)
        {
            exp.Add(ex);
            return true;
        }
        public double SumExpenses(List<Expense> exp)
        {
            double total = 0;
            for (int i = 0; i < exp.Count; i++)
            {
                total += exp[i].Amount;
            }
            return total;
        }
        #endregion

        #region Tasks
        public bool CompleteTask(TaskTypes t)
        {
            foreach (Task task in this.tasks)
            {
                if (task.Type == t)
                {
                    return  task.CompleteTheTask;
                }
            }
            return true;
        }
        public bool CheckTask(Task t)
        {
            foreach (Task task in this.tasks)
            {
                if (task == t)
                {
                    return task.Status;
                }
            }
            return false;
        }
        public string[] TaskRotateF()
        {
            string a = this.doer[0];
            string b = this.doer[1];
            string c = this.doer[2];
            string[] temp;
            this.doer.Insert(0, c);
            this.doer.RemoveAt(1);
            this.doer.Insert(1, a);
            this.doer.RemoveAt(2);
            this.doer.Insert(2, b);
            this.doer.RemoveAt(3);
            temp = this.doer.ToArray();
            this.task = temp;
            foreach (Task t in this.tasks)
            {
                t.CompleteTheTask = false;
            }
            return this.task.ToArray();
            
        }
        public string[] JoinTaskDoer()
        {
            for (int i = 0; i < 3; i++)
            {
                this.getTasks.Add($" - {this.doer[i]}");
            }
            return this.getTasks.ToArray();
        }

        #endregion
    }
}
