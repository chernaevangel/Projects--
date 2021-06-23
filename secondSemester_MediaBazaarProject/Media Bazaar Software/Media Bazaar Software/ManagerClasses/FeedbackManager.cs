using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Interfaces;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.Exceptions;
using Media_Bazaar_Software.DatabaseLoad;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Media_Bazaar_Software.ManagerClasses
{
    public class FeedbackManager : IManager
    {
        public List<Feedback> Feedbacks = new List<Feedback>();
        private FeedbackDatabaseLoad feedbackDatabaseManager;
        public FeedbackDatabaseLoad FeedbackDatabaseManager { get { return feedbackDatabaseManager; } set { feedbackDatabaseManager = value; } }

        public FeedbackManager()
        {
            FeedbackDatabaseManager = new FeedbackDatabaseLoad();
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            Feedbacks = new List<Feedback>();
            foreach (Feedback feedback in (List<Feedback>)FeedbackDatabaseManager.ReadAll())
            {
                Feedbacks.Add(feedback);
            }
        }
        public void Add(object obj)
        {
            try
            {
                FeedbackDatabaseManager.Insert(obj);
                LoadDataFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Object GetAllObjects()
        {
            return Feedbacks;
        }

        public void RemoveFeedback(int id)
        {
            FeedbackDatabaseManager.Delete(id);
        }
        public void GiveFeedback(Employee employee, string message)
        {
            Feedback feedback = new Feedback(employee.Id, message, DateTime.Now.ToString("yyyy-MM-dd"));
            Add(feedback);
        }
        public Feedback[] GetFeedbacks(string department)
        {
            List<Feedback> temp = new List<Feedback>();
            foreach (Feedback feedback in Feedbacks)
            {
                if (feedback.Department == department)
                {
                    temp.Add(feedback);
                }
            }
            return temp.ToArray();
        }
    }
}

