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
    public class DepartmentDatabaseLoad : IDatabaseReader
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");

        public Object ReadAll()
        {
            List<Department> departments = new List<Department>();
            try
            {
                string sql = "SELECT * FROM department"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Department newDepartment = new Department(dr[0].ToString(), Convert.ToInt32(dr[1]));
                    departments.Add(newDepartment);
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
            return departments;
        }


        public void Insert(object obj)
        {
            Department department = (Department)obj;
            try
            {
                string sql = "INSERT INTO department (name, managerid) VALUES (@name, @managerid)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", department.Name);
                cmd.Parameters.AddWithValue("@managerid", department.ManagerId);

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
                string sql = "DELETE FROM `department` WHERE ManagerId = @id";
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
    }
}
