using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoomBookingApp.UnitTests
{
    [TestClass]
    public class MEETINGEMPLOYEESTest
    {

        [TestMethod]
        public void InsertMeetingEmployee_NegativeValues_ReturnsFalse()
        {
            // Arrange
            var MeetingEmployees = new MEETINGEMPLOYEES();

            // Act
            int Employee = -12; 
            int Meeting = -100; 


            bool Result = MeetingEmployees.InsertMeetingEmployee(Employee, Meeting);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void InsertMeetingEmployee_InvalidValues_ReturnsFalse()
        {
            // Arrange
            var MeetingEmployees = new MEETINGEMPLOYEES();

            // Act
            int Employee = 2147483647;
            int Meeting = 2147483647;


            bool Result = MeetingEmployees.InsertMeetingEmployee(Employee, Meeting);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void DeleteMeetingEmployee_NegativeValues_ReturnsFalse()
        {
            // Arrange
            var MeetingEmployees = new MEETINGEMPLOYEES();

            // Act
            int id = -1;
            
            bool Result = MeetingEmployees.DeleteMeetingEmployee(id);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void DeleteMeetingEmployee_InvalidValues_ReturnsFalse()
        {
            // Arrange
            var MeetingEmployees = new MEETINGEMPLOYEES();

            // Act
            int id = 2147483647;

            bool Result = MeetingEmployees.DeleteMeetingEmployee(id);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void GetMeetingEmployees_validValues_IsNotNull()
        {
            // Arange
            var MeetingEmployee = new MEETINGEMPLOYEES();

            // Act
            DataTable Result = MeetingEmployee.GetMeetingEmployees();

            // Assert
            Assert.IsNotNull(Result);
        }
    }
}
