using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Media_Bazaar_Software.DatabaseLoad;
using MySql.Data;

namespace Media_Bazaar_Software.Classes
{
    public class Item
    {
        //Instance variables
        private static int IdSeeder = 1;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int InStock { get; private set; }
        public int MinimumAmount { get; private set; }
        public string Department { get; private set; }

        private ItemDatabaseLoad ItemDatabaseLoad = new ItemDatabaseLoad();
        //Class Constructor
        public Item(string name, decimal price, int minimumAmount, string department)
        {
            Name = name;
            Price = price;
            MinimumAmount = minimumAmount;
            Department = department;
        }
        public Item(int id, string name, decimal price, int inStock, int minimumAmount, string department)
        {
            Id = id;
            Name = name;
            InStock = inStock;
            MinimumAmount = minimumAmount;
            Price = price;
            Department = department;
        }

        //Class Methods
        public override string ToString()
        {
            return $"{Name}({Id}) - ({Department}) - {InStock}/ {MinimumAmount} min";
        }
        public bool OrderItem(int amount)
        {
            InStock += amount;
            ItemDatabaseLoad.OrderItem(amount, Id);
            return true;
        }
        public bool SellItem(int amount)
        {
            if (InStock > amount)
            {
                InStock -= amount;
                ItemDatabaseLoad.SellItem(amount, Id);
                return true;
            }
            return false;
        }
        public string CheckAvailability()
        {
            if (InStock > MinimumAmount)
            {
                return "Complete!";
            }
            else { return $"{Name} is running out of stock"; }
        }

    }
}
