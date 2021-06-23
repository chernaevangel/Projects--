using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.DatabaseLoad;
using Media_Bazaar_Software.ManagerClasses;

namespace Unit_Tests
{
    [TestClass]
    public class ItemManagerUT
    {
        private const string ITEM_NAME = "Nokia";
        private const decimal ITEM_PRICE = 50;
        private const int ITEM_MIN = 5;
        private const string ITEM_DEPARTMENT = "Phones and Tablets";

        private readonly Item DEFAULT_ITEM = new Item(ITEM_NAME, ITEM_PRICE, ITEM_MIN, ITEM_DEPARTMENT);

        [TestMethod]
        public void TestConstructor()
        {
            ItemManager itemManager = new ItemManager();

            Assert.IsNotNull(itemManager.ItemDatabaseLoad);
        }
        [TestMethod]
        public void TestConstructorUnsuccessful()
        {
            ItemManager itemManager = new ItemManager();

            Assert.AreNotEqual(null, itemManager.ItemDatabaseLoad);
        }
        [TestMethod]
        public void TestAddItem()
        {
            ItemManager itemManager = new ItemManager();

            itemManager.AddItem(ITEM_NAME, ITEM_PRICE.ToString(), ITEM_MIN.ToString(), ITEM_DEPARTMENT);

            Assert.AreEqual(ITEM_NAME, itemManager.Items[itemManager.Items.Count - 1].Name);
            Assert.AreEqual(ITEM_PRICE, itemManager.Items[itemManager.Items.Count - 1].Price);
            Assert.AreEqual(ITEM_MIN, itemManager.Items[itemManager.Items.Count - 1].MinimumAmount);
            Assert.AreEqual(ITEM_DEPARTMENT, itemManager.Items[itemManager.Items.Count - 1].Department);
        }
        [TestMethod]
        public void TestAddItemUnsuccessful()
        {
            ItemManager itemManager = new ItemManager();

            itemManager.AddItem(ITEM_NAME, ITEM_PRICE.ToString(), ITEM_MIN.ToString(), ITEM_DEPARTMENT);

            Assert.AreNotEqual("Samsung", itemManager.Items[itemManager.Items.Count - 1].Name);
            Assert.AreNotEqual(10, itemManager.Items[itemManager.Items.Count - 1].Price);
            Assert.AreNotEqual(1, itemManager.Items[itemManager.Items.Count - 1].MinimumAmount);
            Assert.AreNotEqual("Phones", itemManager.Items[itemManager.Items.Count - 1].Department);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestAddItemException()
        {
            ItemManager itemManager = new ItemManager();

            itemManager.AddItem("newItem", "twelve", "min", "Phones and Tablets");

        }
        [TestMethod]
        public void TestGetItemsDepartment()
        {
            ItemManager itemManager = new ItemManager();

            List<Item> items = new List<Item>();
            items.AddRange(itemManager.GetItemsDepartment("Phones and Tablets"));

            Assert.AreEqual("Phones and Tablets", items[1].Department);
        }
        [TestMethod]
        public void TestGetItemsDepartmentUnsuccessful()
        {
            ItemManager itemManager = new ItemManager();

            List<Item> items = new List<Item>();
            items.AddRange(itemManager.GetItemsDepartment("Phones and Tablets"));

            Assert.AreNotEqual("Computers", items[1].Department);
        }
        [TestMethod]
        public void TestGetItem()
        {
            ItemManager itemManager = new ItemManager();

            Assert.AreEqual("Laptop HP", itemManager.GetItem("2").Name);
        }
        [TestMethod]
        public void TestGetItemUnsuccessful()
        {
            ItemManager itemManager = new ItemManager();

            Assert.AreNotEqual("Macbook Pro", itemManager.GetItem("2").Name);
        }
        [TestMethod]
        public void TestRemoveItem()
        {
            ItemManager itemManager = new ItemManager();
            Item item = itemManager.Items[itemManager.Items.Count - 1];
            itemManager.RemoveItem(item.Id.ToString());

            Assert.IsFalse(itemManager.Items.Contains(itemManager.GetItem(item.Id.ToString())));
        }
    }
}
