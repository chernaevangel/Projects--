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

namespace Media_Bazaar_Software.DatabaseLoad
{
    public class EmployeeTypeDatabaseLoad : IDatabaseReader
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");

        public Object ReadAll()
        {
            List<EmployeeType> employeeTypes = new List<EmployeeType>();
            try
            {
                string sql = "SELECT * FROM employeetype"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EmployeeType employeeType = new EmployeeType(dr[0].ToString(), Convert.ToDecimal(dr[1]));
                    employeeTypes.Add(employeeType);
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
            return employeeTypes;
        }


        public void Insert(object obj)
        {
            EmployeeType employeeType = (EmployeeType)obj;
            try
            {
                Console.WriteLine(employeeType.ToString());
                // make sure in your table the id in auto-incremented
                string sql = "INSERT INTO employeetype (type, wageperhour) VALUES (@type, @wagePerHour)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", employeeType.Type);
                cmd.Parameters.AddWithValue("@wagePerHour", employeeType.WagePerHour);

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
                string sql = "DELETE FROM `employeetype` WHERE # = @id";
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

        public void Delete(string type)
        {
            try
            {
                string sql = "DELETE FROM `employeetype` WHERE Type = @type";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", type);
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

        public void Update(string type, decimal wagePerHour)
        {
            try
            {
                string sql = "UPDATE EmployeeType SET WagePerHour = @wagePerHour WHERE Type = @type";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@wagePerHour", wagePerHour);
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
    }
}
