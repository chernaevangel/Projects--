using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Interfaces;
using Media_Bazaar_Software.DatabaseLoad;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.Exceptions;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Media_Bazaar_Software.ManagerClasses
{
    public class EmployeeManager : IManager
    {
        private EmployeeDatabaseLoad employeeDatabaseLoad;
        public EmployeeDatabaseLoad EmployeeDatabaseLoad { get { return employeeDatabaseLoad; } set { employeeDatabaseLoad = value; } }
        public List<Employee> employees { get; private set; }
        public EmployeeManager()
        {
            EmployeeDatabaseLoad = new EmployeeDatabaseLoad();
            LoadDataFromDatabase();

        }
        private void LoadDataFromDatabase()
        {
            employees = new List<Employee>();
            foreach (Employee employee in (List<Employee>)EmployeeDatabaseLoad.ReadAll())
            {
                employees.Add(employee);
            }
        }
        public void Add(object obj)
        {
            try
            {
                EmployeeDatabaseLoad.Insert(obj);
                LoadDataFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Object GetAllObjects()
        {
            return employees;
        }
        public Employee LogIn(string email, string password)
        {
            byte[] source;
            byte[] hash;
            source = ASCIIEncoding.ASCII.GetBytes(password);
            hash = new MD5CryptoServiceProvider().ComputeHash(source);
            string input = BitConverter.ToString(hash).ToLower().Replace("-", "");
            foreach (Employee employee in employees)
            {
                if (employee.Email == email && employee.Password == input)
                {
                    return employee;
                }
            }
            return null;
        }
        public bool AddEmployee(string firstName, string lastName, DateTime birthday, string phoneNumber, string employeetype, string department, string email)
        {
                string Birthday = birthday.ToString("yyyy-MM-dd");
                if (phoneNumber.Length == 11 && phoneNumber.StartsWith("+"))
                {
                    if (email.Contains("@"))
                    {
                        Add(new Employee(firstName, lastName, Birthday, phoneNumber, employeetype, department, email));
                        employees = (List<Employee>)GetAllObjects();
                        return true;
                    }
                    else
                    {
                        throw new EmailFormatException();
                    }
                }
                else
                {
                    throw new PhoneFormatException();
                }
        }
        public Employee GetEmployee(string id)
        {
            try
            {
                int Id = Convert.ToInt32(id);
                foreach (Employee employee in employees)
                {
                    if (employee.Id == Id)
                    {
                        return employee;
                    }
                }
                return null;
            }
            catch (FormatException)
            {
                throw new FormatException();
            }
        }
        public Employee[] GetEmployeeDepartment(string department)
        {
            List<Employee> temp = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Department == department)
                {
                    temp.Add(employee);
                }
            }
            return temp.ToArray();
        }
        public string GetEmployeeInformation(Employee currEmployee)
        {
            foreach (Employee employee in employees)
            {
                if (employee == currEmployee)
                {
                    return employee.GetFullInformation();
                }
            }
            return null;
        }
        public void RemoveEmployee(string id)
        {
            try
            {
                int Id = Convert.ToInt32(id);
                EmployeeDatabaseLoad.Delete(Id);
                employees = (List<Employee>)GetAllObjects();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Id. Please try again!", "Error");
            }
        }
        public void EmployeeChangePassword(string email, string oldPassword, string newPassword)
        {
            try
            {
                byte[] source;
                byte[] hash;
                source = ASCIIEncoding.ASCII.GetBytes(oldPassword);
                hash = new MD5CryptoServiceProvider().ComputeHash(source);
                string input = BitConverter.ToString(hash).ToLower().Replace("-", "");
                foreach (Employee employee in employees)
                {
                    if (employee.Email == email && employee.Password == input)
                    {
                        employee.ChangePassword(input, newPassword);
                        EmployeeDatabaseLoad.Update(employee);
                        MessageBox.Show("The password has been changed!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect password. Please try again");
            }
        }
        public void LogOut(int id, string amount)
        {
            EmployeeDatabaseLoad.LogOut(id, amount);
        }
    }
}
