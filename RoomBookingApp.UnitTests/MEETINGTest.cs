using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoomBookingApp.UnitTests
{
    [TestClass]
    public class MEETINGTest
    {
        [TestMethod]
        public void InsertMeeting_NegativeValues_ReturnsFalse()
        {
            // Arange
            var Meeting = new MEETINGS();

            // Act
            int id = -1;
            DateTime start = new DateTime(2020, 12, 25);
            DateTime End = new DateTime(2020, 12, 26);
            String Desc = null;

            var Result = Meeting.InsertMeeting(id, start, End, Desc);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void InsertMeeting_InvalidValues_ReturnsFalse()
        {
            // Arange
            var Meeting = new MEETINGS();

            // Act
            int id = 2147483647;
            DateTime start = new DateTime(9132, 10, 10);
            DateTime End = new DateTime(2132, 10, 10);
            String Desc = "test";

            var Result = Meeting.InsertMeeting(id, start, End, Desc);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void EditMeeting_NegativeValues_ReturnsFalse()
        {
            // Arange
            var Meeting = new MEETINGS();

            // Act
            int id = -1;
            DateTime start = new DateTime(2020, 12, 25);
            DateTime End = new DateTime(2020, 12, 26);
            String Desc = null;

            var Result = Meeting.InsertMeeting(id, start, End, Desc);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void EditMeeting_InvalidValues_ReturnsFalse()
        {
            // Arange
            var Meeting = new MEETINGS();

            // Act
            int id = 2147483647;
            DateTime start = new DateTime(4040, 12, 25);
            DateTime End = new DateTime(4040, 12, 26);
            String Desc = "test";

            var Result = Meeting.InsertMeeting(id, start, End, Desc);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void DeleteMeeting_NegativeValues_ReturnsFalse()
        {
            // Arange
            var Meeting = new MEETINGS();

            // Act
            int id = -1;

            var Result = Meeting.DeleteMeeting(id);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void DeleteMeeting_InvalidValues_ReturnsFalse()
        {
            // Arange
            var Meeting = new MEETINGS();

            // Act
            int id = 2147483647;

            var Result = Meeting.DeleteMeeting(id);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void GetMeetings_validValues_IsNotNull()
        {
            // Arange
            var Meetings = new MEETINGS();

            // Act
            DataTable Result = Meetings.GetMeetings();

            // Assert
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void RoomTypeList_validValues_IsNotNull()
        {
            // Arange
            var Meetings = new MEETINGS();

            // Act
            DataTable Result = Meetings.RoomTypeList();

            // Assert
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void GetMeetingsFromID_validValues_IsNotNull()
        {
            // Arange
            var Meetings = new MEETINGS();

            // Act
            int id = 40; //enter a valid meeting. 40 was valid from 12/11/2020 1.05AM

            DataTable Result = Meetings.GetMeetingsFromID(id);

            // Assert
            Assert.IsNotNull(Result);
        }
        [TestMethod]
        public void GetMeetingsFromID_NegativeValues_IsNotNull()
        {
            // Arange
            var Meetings = new MEETINGS();

            // Act
            int id = -1; //enter a valid meeting. 40 was valid from 12/11/2020 1.05AM

            DataTable Result = Meetings.GetMeetingsFromID(id);

            // Assert
            Assert.IsNull(Result);
        }
    }
}
