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
    public class PreferenceManager
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
        private EmployeeManager em = new EmployeeManager();
        public bool AddPreference(int id, string date, string availability)
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "INSERT INTO `preferences`(`EmployeeId`, `Date`, `Availability`) VALUES (@id, @date, @availability)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@availability", availability);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
        }
        public Preference[] GetAllPreferences(string department)
        {
            List<Preference> temp = new List<Preference>();
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "Select * From preferences";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    foreach (Employee employee in em.GetEmployeeDepartment(department))
                    {
                        if ((int)dr[0] == employee.Id)
                        {
                            DateTime date = DateTime.Parse(dr[1].ToString());
                            Preference preference = new Preference((int)dr[0], date, dr[2].ToString());
                            temp.Add(preference);
                        }
                    }
                }
                return temp.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }

        }
        public string[] GetEmployeePreferences(int id)
        {
            List<string> temp = new List<string>();
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                string sql = "Select * From preferences where EmployeeId = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string info = $"{(int)dr[0]} - {dr[1]} - {dr[2]}";
                    temp.Add(info);
                }
                return temp.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
