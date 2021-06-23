using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Interfaces;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.Exceptions;
using Media_Bazaar_Software.DatabaseLoad;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Media_Bazaar_Software.ManagerClasses
{
    public class ItemManager : IManager
    {
        private ItemDatabaseLoad itemDatabaseLoad;
        public ItemDatabaseLoad ItemDatabaseLoad { get { return itemDatabaseLoad; } set { itemDatabaseLoad = value; } }
        public List<Item> Items { get; private set; }
        public ItemManager()
        {
            ItemDatabaseLoad = new ItemDatabaseLoad();
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            Items = new List<Item>();
            foreach (Item item in (List<Item>)ItemDatabaseLoad.ReadAll())
            {
                Items.Add(item);
            }
        }
        public void Add(object obj)
        {
            try
            {
                ItemDatabaseLoad.Insert(obj);
                LoadDataFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Object GetAllObjects()
        {
            return Items;
        }
        public bool AddItem(string name, string price, string minimumAmount, string department)
        {
            try
            {
                decimal Price = Convert.ToDecimal(price);
                int minAmount = Convert.ToInt32(minimumAmount);
                Item item = new Item(name, Price, minAmount, department);
                Items.Add(item);
                ItemDatabaseLoad.Insert(item);
                Items = (List<Item>)GetAllObjects();
                return true;
            }
            catch (FormatException) { throw new FormatException(); return false; }
        }
        public Item[] GetItemsDepartment(string department)
        {
            List<Item> temp = new List<Item>();
            foreach (Item item in Items)
            {
                if (item.Department == department)
                {
                    temp.Add(item);
                }
            }
            return temp.ToArray();
        }
        public Item GetItem(string id)
        {
            try
            {
                int Id = Convert.ToInt32(id);
                foreach (Item item in Items)
                {
                    if (item.Id == Id)
                    {
                        return item;
                    }
                }
                return null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Id. Please try again!", "Error");
                return null;
            }
        }
        public void RemoveItem(string id)
        {
            try
            {
                int Id = Convert.ToInt32(id);
                ItemDatabaseLoad.Delete(Id);
                LoadDataFromDatabase();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Id. Please try again!", "Error");
            }
        }
    }
}
