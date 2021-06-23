using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Interfaces;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.Exceptions;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Media_Bazaar_Software.ManagerClasses
{
    public class BundleManager
    {
        public bool CreateBundle(string firstId, string secondId, string price)
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                int Id1 = Convert.ToInt32(firstId);
                int Id2 = Convert.ToInt32(secondId);
                decimal Price = Convert.ToDecimal(price);
                string sql = "INSERT INTO `bundle`(`Item1Id`, `Item2Id`, `Price`) VALUES (@id1, @id2, @price)"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id1", Id1);
                cmd.Parameters.AddWithValue("@id2", Id2);
                cmd.Parameters.AddWithValue("@price", Price);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (FormatException)
            { MessageBox.Show("Invalid information. Please try again", "Error"); return false; }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"); return false;
            }
            finally { conn.Close(); }
        }
        public string[] GetBundles(string department)
        {
            List<string> temp = new List<string>();
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "SELECT b.Item1id, b.Item2id, b.Price from bundle as b inner JOIN item as i on b.Item1id = i.id where i.department = @department"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", department);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string bundle = $"{dr[0]} + {dr[1]} - {dr[2]}€";
                    temp.Add(bundle);
                }
                return temp.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again", "Error");
            }
            finally { conn.Close(); }
            return temp.ToArray();
        }
    }
}
