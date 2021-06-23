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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Media_Bazaar_Software.ShiftGenerator
{
    public class ShiftManager
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
        private EmployeeManager em;

        public ShiftManager() 
        {
            em = new EmployeeManager();
        }
        public void DeleteShifts()
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "Delete from shift"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }
        public void CreateShift(string id, string day, string shiftTime)
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                int Id = Convert.ToInt32(id);

                string sql = "INSERT INTO `shift`(`Date`, `ShiftTime`, `EmployeeId`) VALUES ('" + day + "', '" + shiftTime + "','" + Id + "')"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { conn.Close(); }
        }
        public Shift[] GetShifts(int id)
        {
            List<Shift> temp = new List<Shift>();
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "SELECT * FROM shift where EmployeeId = '" + id + "'"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    temp.Add(new Shift(dr[0].ToString(), dr[1].ToString(), em.GetEmployee(dr[2].ToString())));
                }
                return temp.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
            finally { conn.Close(); }
        }
        public Shift[] GetAllShifts()
        {
            List<Shift> temp = new List<Shift>();
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "SELECT * FROM shift"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    temp.Add(new Shift(dr[0].ToString(), dr[1].ToString(), em.GetEmployee(dr[2].ToString())));
                }
                return temp.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
            finally { conn.Close(); }
        }
    }
}
