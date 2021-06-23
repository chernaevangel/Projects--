using Media_Bazaar_Software.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaBazaarSoftware_UnitTestsProject.ClassesUnitTests
{
    [TestClass]
    public class ItemClassUnitTests
    {

        private const int DEFAULT_ID = 2;
        private const string DEFAULT_NAME = "laptop";
        private const decimal DEFAULT_PRICE = 2;
        private const int DEFAULT_INSTOCK = 50;
        private const int DEFAULT_MINIMUMAMOUNT = 2;
        private const string DEFAULT_DEPARTMENT = "Depo";
        private const bool DEFAULT_DISCOUNTED = false;
        private const decimal DEFAULT_DISCOUNTPRICE = 2;

        [TestMethod]
        public void InitializeItemWithoutId()
        {
            Item item = new Item(DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_MINIMUMAMOUNT, DEFAULT_DEPARTMENT);
            Assert.AreEqual(DEFAULT_NAME, item.Name);
            Assert.AreEqual(DEFAULT_PRICE, item.Price);
            Assert.AreEqual(DEFAULT_MINIMUMAMOUNT, item.MinimumAmount);
            Assert.AreEqual(DEFAULT_DEPARTMENT, item.Department);
        }
        [TestMethod]
        public void InitializeItemWithoutIdUnsuccessfuly()
        {
            Item item = new Item("Keyboard", 21, 10, "Shop");
            Assert.AreNotEqual(DEFAULT_NAME, item.Name);
            Assert.AreNotEqual(DEFAULT_PRICE, item.Price);
            Assert.AreNotEqual(DEFAULT_MINIMUMAMOUNT, item.MinimumAmount);
            Assert.AreNotEqual(DEFAULT_DEPARTMENT, item.Department);
        }

        [TestMethod]
        public void InitializeItemWithId()
        {
            Item item = new Item(DEFAULT_ID, DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_INSTOCK, DEFAULT_MINIMUMAMOUNT, DEFAULT_DEPARTMENT);
            Assert.AreEqual(DEFAULT_ID, item.Id);
            Assert.AreEqual(DEFAULT_NAME, item.Name);
            Assert.AreEqual(DEFAULT_PRICE, item.Price);
            Assert.AreEqual(DEFAULT_INSTOCK, item.InStock);
            Assert.AreEqual(DEFAULT_MINIMUMAMOUNT, item.MinimumAmount);
            Assert.AreEqual(DEFAULT_DEPARTMENT, item.Department);
        }
        [TestMethod]
        public void InitializeItemWithIdUnsuccessfuly()
        {
            Item item = new Item(3, "Keyboard", 21, 16, 10, "Shop");
            Assert.AreNotEqual(DEFAULT_ID, item.Id);
            Assert.AreNotEqual(DEFAULT_NAME, item.Name);
            Assert.AreNotEqual(DEFAULT_PRICE, item.Price);
            Assert.AreNotEqual(DEFAULT_INSTOCK, item.InStock);
            Assert.AreNotEqual(DEFAULT_MINIMUMAMOUNT, item.MinimumAmount);
            Assert.AreNotEqual(DEFAULT_DEPARTMENT, item.Department);
        }

        [TestMethod]
        public void ToStringSuccessfully()
        {
            Item item = new Item(DEFAULT_ID, DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_INSTOCK, DEFAULT_MINIMUMAMOUNT, DEFAULT_DEPARTMENT);
            Assert.AreEqual(item.ToString(), $"{item.Name}({item.Id}) - ({item.Department}) - {item.InStock}/ {item.MinimumAmount} min");
        }

        [TestMethod]
        public void OrderItemSuccessfully()
        {
            Item item = new Item(DEFAULT_ID, DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_INSTOCK, DEFAULT_MINIMUMAMOUNT, DEFAULT_DEPARTMENT);
            item.OrderItem(7);
            Assert.AreEqual(item.OrderItem(7), true);
        }

        [TestMethod]
        public void SellItemSuccessfully()
        {
            Item item = new Item(DEFAULT_ID, DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_INSTOCK, DEFAULT_MINIMUMAMOUNT, DEFAULT_DEPARTMENT);
            item.SellItem(7);
            Assert.AreEqual(item.SellItem(7), true);
        }

        [TestMethod]
        public void CheckAvailabilitySuccessfully()
        {
            Item item = new Item(DEFAULT_ID, DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_INSTOCK, DEFAULT_MINIMUMAMOUNT, DEFAULT_DEPARTMENT);
            Assert.AreEqual(item.CheckAvailability(), "Complete!");
        }

        [TestMethod]
        public void CheckAvailabilityUnsuccessfully()
        {
            Item item = new Item(DEFAULT_ID, DEFAULT_NAME, DEFAULT_PRICE, DEFAULT_INSTOCK, 51, DEFAULT_DEPARTMENT);
            Assert.AreEqual(item.CheckAvailability(), $"{item.Name} is running out of stock");
        }







    }
}
