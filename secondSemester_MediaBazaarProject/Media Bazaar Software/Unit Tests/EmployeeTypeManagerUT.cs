using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.DatabaseLoad;
using Media_Bazaar_Software.ManagerClasses;

namespace Unit_Tests
{
    [TestClass]
    public class EmployeeTypeManagerUT
    {

        private const string DEFAULT_NAME = "Software";
        private const decimal DEFAULT_WAGE = 30;

        private readonly EmployeeType DEFAULT_TYPE = new EmployeeType(DEFAULT_NAME, DEFAULT_WAGE);

        [TestMethod]
        public void TestAdd()
        {
            EmployeeTypeManager employeeTypeManager = new EmployeeTypeManager();

            employeeTypeManager.Add(DEFAULT_TYPE);

            Assert.AreEqual(DEFAULT_TYPE.Type, employeeTypeManager.employeeTypes[employeeTypeManager.employeeTypes.Count - 1].Type);
            Assert.AreEqual(DEFAULT_TYPE.WagePerHour, employeeTypeManager.employeeTypes[employeeTypeManager.employeeTypes.Count - 1].WagePerHour);
        }
        public void TestAddUnsuccessful()
        {
            EmployeeTypeManager employeeTypeManager = new EmployeeTypeManager();

            employeeTypeManager.Add(DEFAULT_TYPE);

            Assert.AreEqual("Administrator", employeeTypeManager.employeeTypes[employeeTypeManager.employeeTypes.Count - 1].Type);
            Assert.AreEqual("20", employeeTypeManager.employeeTypes[employeeTypeManager.employeeTypes.Count - 1].WagePerHour);
        }
        [TestMethod]
        public void TestGetType()
        {
            EmployeeTypeManager employeeTypeManager = new EmployeeTypeManager();

            EmployeeType employeeType = new EmployeeType("Depot", 10);

            Assert.AreEqual(employeeType.Type, employeeTypeManager.GetEmployeeType("Depot").Type);
            Assert.AreEqual(employeeType.WagePerHour, employeeTypeManager.GetEmployeeType("Depot").WagePerHour);

        }
        [TestMethod]
        public void TestGetTypeUnsuccessful()
        {
            EmployeeTypeManager employeeTypeManager = new EmployeeTypeManager();

            EmployeeType employeeType = new EmployeeType("Administrator", 30);

            Assert.AreNotEqual(employeeType.Type, employeeTypeManager.GetEmployeeType("Depot").Type);
            Assert.AreNotEqual(employeeType.WagePerHour, employeeTypeManager.GetEmployeeType("Depot").WagePerHour);

        }
        [TestMethod]
        public void TestEditETWage()
        {
            EmployeeTypeManager employeeTypeManager = new EmployeeTypeManager();

            employeeTypeManager.EditEmployeeTypeWage(employeeTypeManager.GetEmployeeType("Software"), 25);

            Assert.AreEqual(25, employeeTypeManager.GetEmployeeType("Software").WagePerHour);
        }
        [TestMethod]
        public void TestRemoveEmployeeType()
        {
            EmployeeTypeManager employeeTypeManager = new EmployeeTypeManager();

            employeeTypeManager.RemoveEmployeeType(employeeTypeManager.GetEmployeeType("Software"));

            Assert.IsFalse(employeeTypeManager.employeeTypes.Contains(employeeTypeManager.GetEmployeeType("Software")));
        }
    }
}
