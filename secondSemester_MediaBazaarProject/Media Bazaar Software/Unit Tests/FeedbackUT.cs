using Media_Bazaar_Software.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaBazaarSoftware_UnitTestsProject.ClassesUnitTests
{
    [TestClass]
    public class FeedbackClassUnitTests
    {

        private const int DEFAULT_SENDERID = 2;
        private const string DEFAULT_MESSAGE = "Hello";
        private const string DEFAULT_DATESENT = "22-02-2021";
        private const string DEFAULT_DEPARTMENT = "Depo";

        [TestMethod]
        public void InitializeFeedbackSuccessfullyWithoutDepartment()
        {
            Feedback feedback = new Feedback(DEFAULT_SENDERID, DEFAULT_MESSAGE, DEFAULT_DATESENT);
            Assert.AreEqual(DEFAULT_SENDERID, feedback.SenderId);
            Assert.AreEqual(DEFAULT_MESSAGE, feedback.Message);
            Assert.AreEqual(DEFAULT_DATESENT, feedback.DateSent);
        }
        [TestMethod]
        public void InitializeFeedbackUnsuccessfullyWithoutDepartment()
        {
            Feedback feedback = new Feedback(4, "Bye", "21-03-2032");
            Assert.AreNotEqual(DEFAULT_SENDERID, feedback.SenderId);
            Assert.AreNotEqual(DEFAULT_MESSAGE, feedback.Message);
            Assert.AreNotEqual(DEFAULT_DATESENT, feedback.DateSent);
        }

        [TestMethod]
        public void InitializeFeedbackSuccessfullyWithDepartment()
        {
            Feedback feedback = new Feedback(DEFAULT_SENDERID, DEFAULT_MESSAGE, DEFAULT_DATESENT, DEFAULT_DEPARTMENT);
            Assert.AreEqual(DEFAULT_SENDERID, feedback.SenderId);
            Assert.AreEqual(DEFAULT_MESSAGE, feedback.Message);
            Assert.AreEqual(DEFAULT_DATESENT, feedback.DateSent);
            Assert.AreEqual(DEFAULT_DEPARTMENT, feedback.Department);
        }
        [TestMethod]
        public void InitializeFeedbackUnsuccessfullyWithDepartment()
        {
            Feedback feedback = new Feedback(4, "Bye", "21-03-2032", "Show");
            Assert.AreNotEqual(DEFAULT_SENDERID, feedback.SenderId);
            Assert.AreNotEqual(DEFAULT_MESSAGE, feedback.Message);
            Assert.AreNotEqual(DEFAULT_DATESENT, feedback.DateSent);
            Assert.AreNotEqual(DEFAULT_DEPARTMENT, feedback.Department);
        }

        [TestMethod]
        public void ToStringSuccessfuly()
        {
            Feedback feedback = new Feedback(DEFAULT_SENDERID, DEFAULT_MESSAGE, DEFAULT_DATESENT, DEFAULT_DEPARTMENT);
            Assert.AreEqual(feedback.ToString(), $"{feedback.DateSent} - {feedback.SenderId} : {feedback.Message}");
        }
    }
}
