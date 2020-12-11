using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RoomBookingApp.UnitTests
{
    [TestClass]
    public class EMPLOYEETest
    {
        [TestMethod]
        public void InsertEmployee_NullValuse_ReturnsFalse()
        {
            // Arrange
            var Employees = new EMPLOYEE();

            // Act
            String Fname = null;
            String Lname = null;
            String Email = null;

            var Result = Employees.InsertEmployee(Fname, Lname, Email);

            // Assert
            Assert.IsFalse(Result);
        }
        
        [TestMethod]
        public void EditEmployee_NullValues_returnsFalse()
        {
            // Arange
            var Employees = new EMPLOYEE();

            // Act
            int id = -1;
            String Fname = null;
            String Lname = null;
            String Email = null;

            var Result = Employees.EditEmployee(id, Fname, Lname, Email);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void EditEmployee_InvalidValues_returnsFalse()
        {
            // Arange
            var Employees = new EMPLOYEE();

            // Act
            int id = 2147483647;
            String Fname = "qwerty";
            String Lname = "qwerty";
            String Email = "qwerty";

            var Result = Employees.EditEmployee(id, Fname, Lname, Email);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void DeleteEmployee_NegativeValues_ReturnsFalse()
        {
            // Arange
            var Employees = new EMPLOYEE();

            // Act
            int id = -1;

            var Result = Employees.DeleteEmployee(id);

            // Assert
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void DeleteEmployee_InvalidValues_ReturnsFalse()
        {
            // Arange
            var Employees = new EMPLOYEE();

            // Act
            int id = 2147483647;

            var Result = Employees.DeleteEmployee(id);

            // Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void GetEmployee_validValues_IsNotNull()
        {
            // Arange
            var Employees = new EMPLOYEE();

            // Act
            DataTable Result = Employees.GetEmployee();

            // Assert
            Assert.IsNotNull(Result);
        }
    }
}
