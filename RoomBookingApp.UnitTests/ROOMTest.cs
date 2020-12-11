using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoomBookingApp.UnitTests
{
    [TestClass]
    public class ROOMTest
    {
        [TestMethod]
        public void InsertRoom_NegativeValues_ReturnsFalse()
        {
            // Arange
            var Room = new ROOM();

            // Act
            String Name = "test";
            int cap = -1;

            var Result = Room.InsertRoom(Name, cap);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void InsertRoom_InvalidValues_ReturnsFalse()
        {
            // Arange
            var Room = new ROOM();

            // Act
            String Name = "dsads";
            int cap = 2147483647;

            var Result = Room.InsertRoom(Name, cap);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void EditRooms_NegativeValues_ReturnsFalse()
        {
            // Arange
            var Room = new ROOM();

            // Act
            int id = 14;
            String Name = "test";
            int cap = -1;

            var Result = Room.EditRooms(id, Name, cap);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void EditRooms_InvalidValues_ReturnsFalse()
        {
            // Arange
            var Room = new ROOM();

            // Act
            int id = 2147483647;
            String Name = "dsads";
            int cap = 2147483647;

            var Result = Room.EditRooms(id, Name, cap);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void GetMeetings_validValues_IsNotNull()
        {
            // Arange
            var Room = new ROOM();

            // Act
            DataTable Result = Room.GetRooms();

            // Assert
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void RoomCap_validValues_AreNotSame()
        {
            // Arange
            var Room = new ROOM();

            // Act
            int cap = 1;

            var Result = Room.RoomCap(cap);

            // Assert
            Assert.AreNotSame(0, Result);
        }
        [TestMethod]
        public void RoomCap_NegativeValues_AreEqual()
        {
            // Arange
            var Room = new ROOM();

            // Act
            int cap = -1;

            var Result = Room.RoomCap(cap);

            // Assert
            Assert.AreEqual(0, Result);
        }
        [TestMethod]
        public void RoomCap_InvalidValues_AreEqual()
        {
            // Arange
            var Room = new ROOM();

            // Act
            int cap = 101;

            var Result = Room.RoomCap(cap);

            // Assert
            Assert.AreEqual(0, Result);
        }
    }
}
