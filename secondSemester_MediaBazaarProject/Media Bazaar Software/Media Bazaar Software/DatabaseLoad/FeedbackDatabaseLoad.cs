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
    public class FeedbackDatabaseLoad : IDatabaseReader
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;;database=dbi451508;uid=dbi451508;password=mediabazaar;");

        public Object ReadAll()
        {
            List<Feedback> feedbacks = new List<Feedback>();
            try
            {
                string sql = "SELECT f.Date, f.EmployeeId, f.Feedback, e.Department FROM `feedback` as f inner join employee as e on e.Id = f.EmployeeId"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Feedback newFeedback = new Feedback((int)dr[1], dr[2].ToString(), dr[0].ToString(), dr[3].ToString());
                    feedbacks.Add(newFeedback);
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
            return feedbacks;
        }
        public void Insert(object obj)
        {
            Feedback feedback = (Feedback)obj;
            try
            {
                string sql = "INSERT INTO `feedback`(`Date`, `EmployeeId`, `Feedback`) VALUES (@Date,@EmployeeId,@Feedback)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Date", feedback.DateSent);
                cmd.Parameters.AddWithValue("@EmployeeId", feedback.SenderId);
                cmd.Parameters.AddWithValue("@Feedback", feedback.Message);

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
                string sql = "Delete f.* from Feedback as f inner join employee as e on e.Id = f.EmployeeId inner join department as d on d.Name = e.Department where (d.ManagerId = @id)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("id", id);


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
