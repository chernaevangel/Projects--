using Media_Bazaar_Software.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaBazaarSoftware_UnitTestsProject.ClassesUnitTests
{
    [TestClass]
    public class EmployeeClassUnitTests
    {
        private const int DEFAULT_ID = 3;
        private const string DEFAULT_FIRSTNAME = "Peter";
        private const string DEFAULT_LASTNAME = "Jakson";
        private const string DEFAULT_BIRTHDAY = "21-02-2012";
        private const string DEFAULT_PHONENUMBER = "+3238821234123";
        private const double DEFAULT_HOURSWORKED = 23;
        private const string DEFAULT_EMPLOYEETYPE = "Manager";
        private const string DEFAULT_DEPARTMENT = "Depo";
        private const string DEFAULT_EMAIL = "peterjakson@media-bazaar.com";
        private const string DEFAULT_PASSWORD = "dhsdds";

        [TestMethod]
        public void InitializeEmployeeSuccessful1()
        {
            Employee employee = new Employee(DEFAULT_FIRSTNAME, DEFAULT_LASTNAME, DEFAULT_BIRTHDAY, DEFAULT_PHONENUMBER, DEFAULT_EMPLOYEETYPE, DEFAULT_DEPARTMENT, DEFAULT_EMAIL);
            Assert.AreEqual(DEFAULT_FIRSTNAME, employee.FirstName);
            Assert.AreEqual(DEFAULT_LASTNAME, employee.LastName);
            Assert.AreEqual(DEFAULT_BIRTHDAY, employee.Birthday);
            Assert.AreEqual(DEFAULT_PHONENUMBER, employee.PhoneNumber);
            Assert.AreEqual(DEFAULT_EMPLOYEETYPE, employee.EmployeeType);
            Assert.AreEqual(DEFAULT_DEPARTMENT, employee.Department);
            Assert.AreEqual(DEFAULT_EMAIL, employee.Email);
        }

        [TestMethod]
        public void InitializeEmployeeUnsuccessful1()
        {
            Employee employee = new Employee("Damian", "Popov", "21-02-2013", "+3238821234113", "HR", "Shop", "damianpopov@media-bazaar.com");
            Assert.AreNotEqual(DEFAULT_FIRSTNAME, employee.FirstName);
            Assert.AreNotEqual(DEFAULT_LASTNAME, employee.LastName);
            Assert.AreNotEqual(DEFAULT_BIRTHDAY, employee.Birthday);
            Assert.AreNotEqual(DEFAULT_PHONENUMBER, employee.PhoneNumber);
            Assert.AreNotEqual(DEFAULT_EMPLOYEETYPE, employee.EmployeeType);
            Assert.AreNotEqual(DEFAULT_DEPARTMENT, employee.Department);
            Assert.AreNotEqual(DEFAULT_EMAIL, employee.Email);
        }

        [TestMethod]
        public void InitializeEmployeeSuccessful2()
        {
            Employee employee = new Employee(DEFAULT_FIRSTNAME, DEFAULT_LASTNAME, DEFAULT_BIRTHDAY, DEFAULT_PHONENUMBER, DEFAULT_EMPLOYEETYPE, DEFAULT_EMAIL);
            Assert.AreEqual(DEFAULT_FIRSTNAME, employee.FirstName);
            Assert.AreEqual(DEFAULT_LASTNAME, employee.LastName);
            Assert.AreEqual(DEFAULT_BIRTHDAY, employee.Birthday);
            Assert.AreEqual(DEFAULT_PHONENUMBER, employee.PhoneNumber);
            Assert.AreEqual(DEFAULT_EMPLOYEETYPE, employee.EmployeeType);
            Assert.AreEqual(DEFAULT_EMAIL, employee.Email);
        }
        [TestMethod]
        public void InitializeEmployeeUnsuccessful2()
        {
            Employee employee = new Employee("Damian", "Popov", "21-02-2013", "+3238821234113", "HR", "damianpopov@media-bazaar.com");
            Assert.AreNotEqual(DEFAULT_FIRSTNAME, employee.FirstName);
            Assert.AreNotEqual(DEFAULT_LASTNAME, employee.LastName);
            Assert.AreNotEqual(DEFAULT_BIRTHDAY, employee.Birthday);
            Assert.AreNotEqual(DEFAULT_PHONENUMBER, employee.PhoneNumber);
            Assert.AreNotEqual(DEFAULT_EMPLOYEETYPE, employee.EmployeeType);
            Assert.AreNotEqual(DEFAULT_EMAIL, employee.Email);
        }

        [TestMethod]
        public void InitializeEmployeeSuccessful3()
        {
            Employee employee = new Employee(DEFAULT_ID, DEFAULT_FIRSTNAME, DEFAULT_LASTNAME, DEFAULT_BIRTHDAY, DEFAULT_PHONENUMBER, DEFAULT_EMPLOYEETYPE, DEFAULT_EMAIL, DEFAULT_PASSWORD);
            Assert.AreEqual(DEFAULT_ID, employee.Id);
            Assert.AreEqual(DEFAULT_FIRSTNAME, employee.FirstName);
            Assert.AreEqual(DEFAULT_LASTNAME, employee.LastName);
            Assert.AreEqual(DEFAULT_BIRTHDAY, employee.Birthday);
            Assert.AreEqual(DEFAULT_PHONENUMBER, employee.PhoneNumber);
            Assert.AreEqual(DEFAULT_EMPLOYEETYPE, employee.EmployeeType);
            Assert.AreEqual(DEFAULT_EMAIL, employee.Email);
            Assert.AreEqual(DEFAULT_PASSWORD, employee.Password);
        }
        [TestMethod]
        public void InitializeEmployeeUnsuccessful3()
        {
            Employee employee = new Employee(2, "Damian", "Popov", "21-02-2013", "+3238821234113", "HR", "damianpopov@media-bazaar.com", "adfdf");
            Assert.AreNotEqual(DEFAULT_ID, employee.Id);
            Assert.AreNotEqual(DEFAULT_FIRSTNAME, employee.FirstName);
            Assert.AreNotEqual(DEFAULT_LASTNAME, employee.LastName);
            Assert.AreNotEqual(DEFAULT_BIRTHDAY, employee.Birthday);
            Assert.AreNotEqual(DEFAULT_PHONENUMBER, employee.PhoneNumber);
            Assert.AreNotEqual(DEFAULT_EMPLOYEETYPE, employee.EmployeeType);
            Assert.AreNotEqual(DEFAULT_EMAIL, employee.Email);
            Assert.AreNotEqual(DEFAULT_PASSWORD, employee.Password);
        }

        [TestMethod]
        public void InitializeEmployeeSuccessful4()
        {
            Employee employee = new Employee(DEFAULT_ID, DEFAULT_FIRSTNAME, DEFAULT_LASTNAME, DEFAULT_BIRTHDAY, DEFAULT_PHONENUMBER, DEFAULT_EMPLOYEETYPE, DEFAULT_DEPARTMENT, DEFAULT_EMAIL, DEFAULT_PASSWORD);
            Assert.AreEqual(DEFAULT_ID, employee.Id);
            Assert.AreEqual(DEFAULT_FIRSTNAME, employee.FirstName);
            Assert.AreEqual(DEFAULT_LASTNAME, employee.LastName);
            Assert.AreEqual(DEFAULT_BIRTHDAY, employee.Birthday);
            Assert.AreEqual(DEFAULT_PHONENUMBER, employee.PhoneNumber);
            Assert.AreEqual(DEFAULT_EMPLOYEETYPE, employee.EmployeeType);
            Assert.AreEqual(DEFAULT_DEPARTMENT, employee.Department);
            Assert.AreEqual(DEFAULT_EMAIL, employee.Email);
            Assert.AreEqual(DEFAULT_PASSWORD, employee.Password);
        }
        [TestMethod]
        public void InitializeEmployeeUnsuccessful4()
        {
            Employee employee = new Employee(2, "Damian", "Popov", "21-02-2013", "+3238821234113", "HR", "Shop", "damianpopov@media-bazaar.com", "adfdf");
            Assert.AreNotEqual(DEFAULT_ID, employee.Id);
            Assert.AreNotEqual(DEFAULT_FIRSTNAME, employee.FirstName);
            Assert.AreNotEqual(DEFAULT_LASTNAME, employee.LastName);
            Assert.AreNotEqual(DEFAULT_BIRTHDAY, employee.Birthday);
            Assert.AreNotEqual(DEFAULT_PHONENUMBER, employee.PhoneNumber);
            Assert.AreNotEqual(DEFAULT_EMPLOYEETYPE, employee.EmployeeType);
            Assert.AreNotEqual(DEFAULT_DEPARTMENT, employee.Department);
            Assert.AreNotEqual(DEFAULT_EMAIL, employee.Email);
            Assert.AreNotEqual(DEFAULT_PASSWORD, employee.Password);
        }

        public void GeneratePassword()
        {

        }

        [TestMethod]
        public void ToStringSuccessful()
        {
            Employee employee = new Employee(DEFAULT_ID, DEFAULT_FIRSTNAME, DEFAULT_LASTNAME, DEFAULT_BIRTHDAY, DEFAULT_PHONENUMBER, DEFAULT_EMPLOYEETYPE, DEFAULT_DEPARTMENT, DEFAULT_EMAIL, DEFAULT_PASSWORD);
            Assert.AreEqual(employee.ToString(), $"{employee.FirstName} {employee.LastName}({employee.Id}) - {employee.EmployeeType}");
        }

        [TestMethod]
        public void GetFullInfoToStringWithoutDepartmentSuccessful()
        {
            Employee employee = new Employee(DEFAULT_ID, DEFAULT_FIRSTNAME, DEFAULT_LASTNAME, DEFAULT_BIRTHDAY, DEFAULT_PHONENUMBER, DEFAULT_EMPLOYEETYPE, DEFAULT_EMAIL, DEFAULT_PASSWORD);
            Assert.AreEqual(employee.GetFullInformation(), $"{employee.FirstName} {employee.LastName}({employee.Id}) - {employee.EmployeeType} \n Contact Information: {employee.Email} / {employee.PhoneNumber}");
        }

        [TestMethod]
        public void GetFullInfoToStringWithDepartmentSuccessful()
        {
            Employee employee = new Employee(DEFAULT_ID, DEFAULT_FIRSTNAME, DEFAULT_LASTNAME, DEFAULT_BIRTHDAY, DEFAULT_PHONENUMBER, DEFAULT_EMPLOYEETYPE, DEFAULT_DEPARTMENT, DEFAULT_EMAIL, DEFAULT_PASSWORD);
            Assert.AreEqual(employee.GetFullInformation(), $"{employee.FirstName} {employee.LastName}({employee.Id}) - {employee.EmployeeType} from {employee.Department} \n Contact Information: {employee.Email} / {employee.PhoneNumber}");
        }
    }
}
