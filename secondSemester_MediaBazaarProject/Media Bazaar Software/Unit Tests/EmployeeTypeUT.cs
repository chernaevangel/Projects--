using Media_Bazaar_Software.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaBazaarSoftware_UnitTestsProject.ClassesUnitTests
{
    [TestClass]
    public class EmployeeTypeClassUnitTests
    {
        private const string DEFAULT_TYPE = "Depo-worker";
        private const decimal DEFAULT_WAGEPERHOUR = 2;

        [TestMethod]
        public void InitializeEmployeeTypeSuccessful()
        {
            EmployeeType employeeType = new EmployeeType(DEFAULT_TYPE, DEFAULT_WAGEPERHOUR);
            Assert.AreEqual(DEFAULT_TYPE, employeeType.Type);
            Assert.AreEqual(DEFAULT_WAGEPERHOUR, employeeType.WagePerHour);
        }

        [TestMethod]
        public void InitializeEmployeeTypeÜnsuccessful()
        {
            EmployeeType employeeType = new EmployeeType("HR", 4);
            Assert.AreNotEqual(DEFAULT_TYPE, employeeType.Type);
            Assert.AreNotEqual(DEFAULT_WAGEPERHOUR, employeeType.WagePerHour);
        }

        [TestMethod]
        public void InitializeEmployeeTypeOnlyTypeSuccessful()
        {
            EmployeeType employeeType = new EmployeeType(DEFAULT_TYPE);
            Assert.AreEqual(DEFAULT_TYPE, employeeType.Type);
        }

        [TestMethod]
        public void InitializeEmployeeTypeOnlyTypeUnsuccessful()
        {
            EmployeeType employeeType = new EmployeeType("HR");
            Assert.AreNotEqual(DEFAULT_TYPE, employeeType.Type);
        }

        [TestMethod]
        public void ToStringSuccessful()
        {
            EmployeeType employeeType = new EmployeeType(DEFAULT_TYPE, DEFAULT_WAGEPERHOUR);
            Assert.AreEqual(employeeType.ToString(), $"{employeeType.Type} - {employeeType.WagePerHour}€/h");
        }



    }
}
