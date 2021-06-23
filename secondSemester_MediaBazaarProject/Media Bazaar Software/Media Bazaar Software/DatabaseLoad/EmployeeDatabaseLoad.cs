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
    public class EmployeeDatabaseLoad : IDatabaseReader
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");

        public Object ReadAll()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                string sql = "SELECT * FROM employee"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[7] == null)
                    {
                        Employee employee = new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(),dr[6].ToString(), dr[8].ToString(), dr[9].ToString() ) ;
                        employees.Add(employee);
                    }
                    else
                    {
                        Employee employee = new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString(),dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                        employees.Add(employee);
                    }
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
            return employees;
        }


        public void Insert(object obj)
        {
            Employee employee = (Employee)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "INSERT INTO `employee`(`FirstName`, `LastName`, `Birthday`, `PhoneNumber`,`HoursWorked` ,`EmployeeType`, `Department`, `Email`, `Password`, `YearsInCompany`) VALUES (@fname, @lname, @birthday, @phonenumber,0, @emptype,@dep, @email, @password, 1)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fname", employee.FirstName);
                cmd.Parameters.AddWithValue("@lname", employee.LastName);
                cmd.Parameters.AddWithValue("@birthday", employee.Birthday);
                cmd.Parameters.AddWithValue("@phonenumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@emptype", employee.EmployeeType);
                cmd.Parameters.AddWithValue("@dep", employee.Department);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@password", employee.Password);

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
                string sql = "DELETE FROM `employee` WHERE id = @id";
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
        public void Update(object obj)
        {
            Employee employee = (Employee)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "UPDATE `employee` SET `Password` = @password WHERE `Email`= @email";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@password", employee.Password);
                cmd.Parameters.AddWithValue("@email", employee.Email);

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
        public void LogOut(int id, string amount)
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");
            try
            {
                int Amount = Convert.ToInt32(amount);
                string sql = "UPDATE `employee` SET HoursWorked= (HoursWorked + @amount) where id = @id"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@amount", Amount);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (FormatException) { MessageBox.Show("Incorrect hours value. Please try again.", "Error"); }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again", "Error");
            }
            finally { conn.Close(); }

        }
    }
}
