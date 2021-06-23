using Media_Bazaar_Software.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaBazaarSoftware_UnitTestsProject.ClassesUnitTests
{
    [TestClass]
    public class DepartmentClassUnitTests
    {
        private const string DEFAULT_NAME = "Depo";
        private const int DEFAULT_MANAGERID = 4;

        //Constructor with only name
        [TestMethod]
        public void InitializationsDepartmentWithNameSuccessfull()
        {
            Department department = new Department(DEFAULT_NAME);
            Assert.AreEqual(DEFAULT_NAME, department.Name);
        }

        [TestMethod]
        public void InitializationsDepartmentWithNameUnsuccessfull()
        {
            Department department = new Department("Manager");
            Assert.AreNotEqual(DEFAULT_NAME, department.Name);
        }

        //Constructor with name and Man.ID
        [TestMethod]
        public void InitializationsDepartmentWithNameAndManIdSuccessfull()
        {
            Department department = new Department(DEFAULT_NAME, DEFAULT_MANAGERID);
            Assert.AreEqual(DEFAULT_NAME, department.Name);
            Assert.AreEqual(DEFAULT_MANAGERID, department.ManagerId);
        }

        [TestMethod]
        public void InitializationsDepartmentWithNameAndManIdUnsuccessfull()
        {
            Department department = new Department("Manager", 3);
            Assert.AreNotEqual(DEFAULT_NAME, department.Name);
            Assert.AreNotEqual(DEFAULT_MANAGERID, department.ManagerId);
        }

        [TestMethod]
        public void ToStringSuccessful()
        {
            Department department = new Department(DEFAULT_NAME);
            Assert.AreEqual(department.ToString(), department.Name);
        }

        [TestMethod]
        public void ToStringUnsuccessful()
        {
            Department department = new Department(DEFAULT_NAME);
            Assert.AreNotEqual(department.ToString(), "Manager");
        }
    }
}
