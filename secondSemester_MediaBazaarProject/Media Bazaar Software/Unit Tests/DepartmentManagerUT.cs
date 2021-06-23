using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Media_Bazaar_Software.ManagerClasses;
using Media_Bazaar_Software.DatabaseLoad;
using Media_Bazaar_Software.Exceptions;
using Media_Bazaar_Software.Classes;

namespace Unit_Tests
{
    [TestClass]
    public class DepartmentManagerUT
    {
        [TestMethod]
        public void TestConstructor()
        {
            DepartmentManager departmentManager = new DepartmentManager();

            Assert.IsNotNull(departmentManager.DepartmentDatabaseManager);
        }
        [TestMethod]
        public void TestConstructorUnsuccessful()
        {
            DepartmentManager departmentManager = new DepartmentManager();

            Assert.AreNotEqual(null, departmentManager.DepartmentDatabaseManager);
        }
        [TestMethod]
        public void TestAddDepartment()
        {
            DepartmentManager departmentManager = new DepartmentManager();

            departmentManager.AddDepartment("Software", 20);

            Assert.AreEqual("Software", departmentManager.Departments[departmentManager.Departments.Count - 1].Name);
            Assert.AreEqual(20, departmentManager.Departments[departmentManager.Departments.Count - 1].ManagerId);
        }
        [TestMethod]
        public void TestAddDepartmentUnsuccessful()
        {
            DepartmentManager departmentManager = new DepartmentManager();

            departmentManager.AddDepartment("Software", 20);

            Assert.AreNotEqual("Test", departmentManager.Departments[departmentManager.Departments.Count - 1].Name);
            Assert.AreNotEqual(2, departmentManager.Departments[departmentManager.Departments.Count - 1].ManagerId);
        }
        [TestMethod]
        public void TestGetDepartment()
        {
            DepartmentManager departmentManager = new DepartmentManager();

            Assert.AreEqual("Phones and Tablets", departmentManager.GetDepartment("Phones and Tablets").Name);
        }
        [TestMethod]
        public void TestGetDepartmentUnsuccessful()
        {
            DepartmentManager departmentManager = new DepartmentManager();

            Assert.AreNotEqual("Software", departmentManager.GetDepartment("Phones and Tablets").Name);
        }
        [TestMethod]
        public void TestRemoveDepartment()
        {
            DepartmentManager departmentManager = new DepartmentManager();
            departmentManager.AddDepartment("new", 10);
            departmentManager.RemoveDepartment(departmentManager.GetDepartment("new"));

            Assert.IsFalse(departmentManager.Departments.Contains(departmentManager.GetDepartment("new")));
        }
        [TestMethod]
        public void TestAddMethod()
        {
            DepartmentManager departmentManager = new DepartmentManager();

            Department department = new Department("Audio");

            departmentManager.Add(department);

            Assert.IsTrue(departmentManager.Departments.Contains(departmentManager.GetDepartment("Audio")));
        }
    }
}
