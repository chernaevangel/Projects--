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
    public class RequestManager
    {
        private ItemManager im = new ItemManager();
        public void CreateRequest(Item item, decimal amount)
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "INSERT INTO `request`(`ItemId`, `Amount`) VALUES (@item, @amount)"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@item", item.Id);
                cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(amount));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { conn.Close(); }
        }
        public Request[] GetRequestsDepartment(string department)
        {
            List<Request> temp = new List<Request>();
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "SELECT r.Amount, i.Id from item as i inner join request as r on i.id = r.ItemId where i.Department = @department"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", department);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Request newRequest = new Request(im.GetItem(dr[1].ToString()), Convert.ToInt32(dr[0]));
                    temp.Add(newRequest);
                }
                return temp.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return temp.ToArray();
            }
            finally { conn.Close(); }
        }
        public void CompleteRequest(int id)
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "DELETE FROM `request` WHERE Itemid = @id"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { conn.Close(); }
        }
    }
}
