using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.ManagerClasses;
using Media_Bazaar_Software.DatabaseLoad;

namespace Unit_Tests
{
    [TestClass]
    public class FeedbackManagerUT
    {
        [TestMethod]
        public void TestConstructor()
        {
            FeedbackManager feedbackManager = new FeedbackManager();

            Assert.IsNotNull(feedbackManager.FeedbackDatabaseManager);
        }
        [TestMethod]
        public void TestConstructorUnsuccessful()
        {
            FeedbackManager feedbackManager = new FeedbackManager();

            Assert.AreNotEqual(null, feedbackManager.FeedbackDatabaseManager);
        }
        [TestMethod]
        public void TestLoadDatafromDatabase()
        {
            FeedbackManager feedbackManager = new FeedbackManager();

            Assert.IsNotNull(feedbackManager.Feedbacks);
        }
        [TestMethod]
        public void TestLoadDatafromDatabaseUnsuccessful()
        {
            FeedbackManager feedbackManager = new FeedbackManager();

            Assert.AreNotEqual(null, feedbackManager.Feedbacks);
        }
        [TestMethod]
        public void TestGiveFeedback()
        {
            FeedbackManager feedbackManager = new FeedbackManager();
            EmployeeManager employeeManager = new EmployeeManager();
            feedbackManager.GiveFeedback(employeeManager.GetEmployee("29"), "FeedbackTest");

            Assert.AreEqual("FeedbackTest", feedbackManager.GetFeedbacks("Computers")[0].Message);
        }
        [TestMethod]
        public void TestGetFeedback()
        {
            FeedbackManager feedbackManager = new FeedbackManager();

            List<Feedback> temp = new List<Feedback>();
            temp.AddRange(feedbackManager.GetFeedbacks("Computers"));

            Assert.AreEqual("Computers", temp[temp.Count - 1].Department);
        }
        [TestMethod]
        public void TestRemoveFeedback()
        {
            FeedbackManager feedbackManager = new FeedbackManager();

            feedbackManager.RemoveFeedback(1);

            Assert.AreEqual(0, feedbackManager.GetFeedbacks("Phones and Tablets").Length);
        }
    }
}
