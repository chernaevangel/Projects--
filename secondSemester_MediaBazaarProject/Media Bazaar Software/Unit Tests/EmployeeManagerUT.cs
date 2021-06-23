using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using Media_Bazaar_Software.ManagerClasses;
using Media_Bazaar_Software.DatabaseLoad;
using Media_Bazaar_Software.Exceptions;
using Media_Bazaar_Software.Classes;
using System.Security.Cryptography;


namespace Unit_Tests
{
    [TestClass]
    public class EmployeeManagerUT
    {
        private const string EMPLOYEE_FNAME = "Brad";
        private const string EMPLOYEE_LNAME = "Pitt";
        private const string EMPLOYEE_BIRTHDAY = "2002-02-11";
        private const string EMPLOYEE_PHONE = "+3156125479";
        private const string EMPLOYEE_TYPE = "Administrator";
        private const string EMPLOYEE_EMAIL = "pradpitt@friendly-soft.com";
        private const string EMPLOYEE_PASSWORD = "test";

        private readonly EmployeeDatabaseLoad DEFAULT_DATABASE_LOAD = new EmployeeDatabaseLoad();
        private readonly Employee DEFAULT_EMPLOYEE = new Employee(1, EMPLOYEE_FNAME, EMPLOYEE_LNAME, EMPLOYEE_BIRTHDAY, EMPLOYEE_PHONE, EMPLOYEE_TYPE, EMPLOYEE_EMAIL, EMPLOYEE_PASSWORD);

        [TestMethod]
        public void TestConstructor()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            Assert.IsNotNull(employeeManager.EmployeeDatabaseLoad);
        }
        [TestMethod]
        public void TestConstructorUnsuccessful()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            Assert.AreNotEqual(null, employeeManager.EmployeeDatabaseLoad);
        }
        [TestMethod]
        public void TestLoadDataFromDatabase()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            Assert.IsTrue(employeeManager.employees.Count > 0);
        }
        [TestMethod]
        public void TestLogIn()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.employees.Add(DEFAULT_EMPLOYEE);

            Employee joan = employeeManager.GetEmployee("1");
            Employee joan2 = employeeManager.LogIn("joankrastanov@friendly-soft.com", "manager1");

            Assert.AreEqual(joan2, joan);
        }
        [TestMethod]
        public void TestLogInUnsuccessful()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            Employee joan = employeeManager.GetEmployee("2");
            Employee joan2 = employeeManager.LogIn("bradpitt@friendly-soft.com", "manager1");

            Assert.AreNotEqual(joan, joan2);
        }
        [TestMethod]
        public void TestGetAllMethod()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            Assert.AreEqual(employeeManager.employees, (List<Employee>)employeeManager.GetAllObjects());
        }
        [TestMethod]
        public void TestAddEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime birthday = DateTime.ParseExact(EMPLOYEE_BIRTHDAY, "yyyy-MM-dd", provider);
            Assert.AreEqual(true, employeeManager.AddEmployee(EMPLOYEE_FNAME, EMPLOYEE_LNAME, birthday, EMPLOYEE_PHONE, EMPLOYEE_TYPE, "", EMPLOYEE_EMAIL));
        }
        [TestMethod]
        public void TestAddEmployeeUnsuccessful()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime birthday = DateTime.ParseExact(EMPLOYEE_BIRTHDAY, "yyyy-MM-dd", provider);
            Assert.AreNotEqual(false, employeeManager.AddEmployee(EMPLOYEE_FNAME, EMPLOYEE_LNAME, birthday, EMPLOYEE_PHONE, EMPLOYEE_TYPE, "", EMPLOYEE_EMAIL));
        }
        [TestMethod]
        [ExpectedException(typeof(EmailFormatException))]
        public void TestEmailException()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            CultureInfo provider = CultureInfo.InvariantCulture;

            string incorrectEmail = "test";
            DateTime birthday = DateTime.ParseExact(EMPLOYEE_BIRTHDAY, "yyyy-MM-dd", provider);
            employeeManager.AddEmployee(EMPLOYEE_FNAME, EMPLOYEE_LNAME, birthday, EMPLOYEE_PHONE, EMPLOYEE_TYPE, "", incorrectEmail);
        }

        [TestMethod]
        [ExpectedException(typeof(PhoneFormatException))]
        public void TestPhoneException()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            CultureInfo provider = CultureInfo.InvariantCulture;

            string incorrectPhone = "+310541024";
            DateTime birthday = DateTime.ParseExact(EMPLOYEE_BIRTHDAY, "yyyy-MM-dd", provider);
            employeeManager.AddEmployee(EMPLOYEE_FNAME, EMPLOYEE_LNAME, birthday, incorrectPhone, EMPLOYEE_TYPE, "", EMPLOYEE_EMAIL);
        }
        [TestMethod]
        public void TestGetEmployeeDepartment()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            List<Employee> temp = new List<Employee>();
            foreach (Employee employee in employeeManager.employees)
            {
                if (employee.Department == "Phones and Tablets")
                {
                    temp.Add(employee);
                }
            }
            List<Employee> employees = new List<Employee>();
            employees.AddRange(employeeManager.GetEmployeeDepartment("Phones and Tablets"));

            Assert.AreEqual(temp[1].Department, employees[1].Department);
        }
        [TestMethod]
        public void TestGetEmployeeInformation()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.employees.Add(DEFAULT_EMPLOYEE);

            string expectedInfo = $"{EMPLOYEE_FNAME} {EMPLOYEE_LNAME}({1}) - {EMPLOYEE_TYPE} \n Contact Information: {EMPLOYEE_EMAIL} / {EMPLOYEE_PHONE}";

            Assert.AreEqual(expectedInfo, employeeManager.GetEmployeeInformation(DEFAULT_EMPLOYEE));
        }
        [TestMethod]
        public void TestGetEmployeeInformationUnsuccessful()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.employees.Add(DEFAULT_EMPLOYEE);

            string expectedInfo = $"{"Fname"} {"Lname"}({1}) - {EMPLOYEE_TYPE} \n Contact Information: {EMPLOYEE_EMAIL} / {EMPLOYEE_PHONE}";

            Assert.AreNotEqual(expectedInfo, employeeManager.GetEmployeeInformation(DEFAULT_EMPLOYEE));
        }
        [TestMethod]
        public void TestChangePassword()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.employees.Add(DEFAULT_EMPLOYEE);

            string newPassword = "test";
            string oldPasswordMD5 = "test";
            byte[] source;
            byte[] hash;
            source = ASCIIEncoding.ASCII.GetBytes(oldPasswordMD5);
            hash = new MD5CryptoServiceProvider().ComputeHash(source);
            string input = BitConverter.ToString(hash).ToLower().Replace("-", "");
            employeeManager.EmployeeChangePassword(EMPLOYEE_EMAIL, oldPasswordMD5, newPassword);


            Assert.AreEqual(newPassword, DEFAULT_EMPLOYEE.Password);
        }
        [TestMethod]
        public void TestRemoveEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            Employee employee = employeeManager.GetEmployee(employeeManager.employees[employeeManager.employees.Count - 1].Id.ToString());
            employeeManager.RemoveEmployee(employee.Id.ToString());
        }
        [TestMethod]
        public void TestAddMethod()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            employeeManager.Add(DEFAULT_EMPLOYEE);

            Assert.IsTrue(employeeManager.employees.Contains(employeeManager.GetEmployee(DEFAULT_EMPLOYEE.Id.ToString())));
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestGetEmployeeException()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            employeeManager.GetEmployee("dsad");
        }
    }
}
