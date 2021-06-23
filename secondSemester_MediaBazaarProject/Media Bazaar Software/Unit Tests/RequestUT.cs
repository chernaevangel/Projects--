using Media_Bazaar_Software.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaBazaarSoftware_UnitTestsProject.ClassesUnitTests
{
    [TestClass]
    public class RequestClassUnitTests
    {

        private const int DEFAULT_AMOUNT = 10;
        private const string DEFAULT_REQUESTMESSAGE = "Shuriken";

        //Employee
        private const string DEFAULT_FIRSTNAME = "Peter";
        private const string DEFAULT_LASTNAME = "Jakson";
        private const string DEFAULT_BIRTHDAY = "23-02-2021";
        private const string DEFAULT_PHONENUMBER = "+23223244";
        private const string DEFAULT_EMPLOYEETYPE = "+23223244";
        private const string DEFAULT_DEPARTMENT = "+23223244";
        private const string DEFAULT_EMAIL = "peterjakson@media-bazaar.com";
        private readonly Employee employee = new Employee(DEFAULT_FIRSTNAME, DEFAULT_LASTNAME, DEFAULT_BIRTHDAY, DEFAULT_PHONENUMBER, DEFAULT_EMPLOYEETYPE, DEFAULT_DEPARTMENT, DEFAULT_EMAIL);

        //Item
        private const string DEFAULT_NAME = "laptop";
        private const decimal DEFAULT_PRICE = 2;
        private const int DEFAULT_INSTOCK = 12;
        private const int DEFAULT_MINIMUMAMOUNT = 2;
        private const string DEFAULT_DEPARTMENTITEM = "Depo";
        private readonly Item item = new Item(DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_MINIMUMAMOUNT, DEFAULT_DEPARTMENT);

        [TestMethod]
        public void InitializeRequestWithEmployeeSuccessfully()
        {
            Request request = new Request(employee, DEFAULT_REQUESTMESSAGE);
            Assert.AreEqual(request.Requester, employee);
            Assert.AreEqual(request.RequestMessage, DEFAULT_REQUESTMESSAGE);
        }

        [TestMethod]
        public void InitializeRequestWithItemSuccessfully()
        {
            Request request = new Request(item, DEFAULT_AMOUNT);
            Assert.AreEqual(request.RequestedItem, item);
            Assert.AreEqual(request.Amount, DEFAULT_AMOUNT);
        }

        [TestMethod]
        public void ToStringIfMassageNullSuccessfully()
        {
            Request request = new Request(item, DEFAULT_AMOUNT);
            Assert.AreEqual(request.ToString(), $"Restock Request: {request.Amount} {request.RequestedItem.Name}");
        }

        [TestMethod]
        public void ToStringWithMassageSuccessfully()
        {
            Request request = new Request(employee, DEFAULT_REQUESTMESSAGE);
            Assert.AreEqual(request.ToString(), $"{request.Requester.FirstName}({request.Requester.Department}) requests {request.RequestMessage}");
        }
    }
}
