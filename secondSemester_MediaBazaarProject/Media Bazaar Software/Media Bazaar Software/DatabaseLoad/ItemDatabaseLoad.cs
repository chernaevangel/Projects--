using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Interfaces;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.Exceptions;
using Media_Bazaar_Software.ManagerClasses;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Media_Bazaar_Software.DatabaseLoad
{
    public class ItemDatabaseLoad : IDatabaseReader
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
        public Object ReadAll()
        {
            List<Item> items = new List<Item>();
            try
            {
                string sql = "SELECT * FROM item"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Item newItem = new Item(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToDecimal(dr[2]), Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]), dr[5].ToString());
                    items.Add(newItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
            return items;
        }


        public void Insert(object obj)
        {
            Item item = (Item)obj;
            try
            {
                string sql = "INSERT INTO `item`(`Name`, `Price`,`inStock`,`MinimumAmount`, `Department`) VALUES (@name, @price,0, @min, @Department)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name",item.Name );
                cmd.Parameters.AddWithValue("@price",item.Price );
                cmd.Parameters.AddWithValue("@min",item.MinimumAmount );
                cmd.Parameters.AddWithValue("@Department",item.Department );

                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM `item` WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public bool SellItem(int amount, int id)
        {
            ItemManager ItemManager = new ItemManager();
            Item item = ItemManager.GetItem(id.ToString());
                MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
                try
                {

                    string sql = "UPDATE `item` SET `InStock`='" + item.InStock + "' where Id = '" + item.Id + "'"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally { conn.Close(); }
                MessageBox.Show(item.CheckAvailability());
            return true;
        }
        public bool OrderItem(int amount, int id)
        {
            ItemManager ItemManager = new ItemManager();
            Item item = ItemManager.GetItem(id.ToString());
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {

                string sql = "UPDATE `item` SET `InStock`='" + item.InStock + "' where Id = '" + item.Id + "'"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { conn.Close(); }
            return true;
        }
    }
}
