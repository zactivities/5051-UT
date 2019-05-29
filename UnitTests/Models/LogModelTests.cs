using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace ModelUnitTests
{
    [TestClass]
    public class LogModelUnitTests
    {
        [TestMethod]
        public void LogModel_Default_Should_Pass()
        {

            // Arange

            // Act
            var result = new LogModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogModel_Update_Valid_Data_Should_Pass()
        {

            // Arange
            var myTest = new LogModel();
            var myUpdate = new LogModel
            {
                PhoneID = "Phone id"
            };

            // Act
            var result = myTest.Update(myUpdate);

            // Assert
            Assert.AreEqual(myUpdate.PhoneID, myTest.PhoneID);
        }


        [TestMethod]
        public void LogModel_Update_Invalid_Null_Data_Should_Pass()
        {

            // Arange
            var myTest = new LogModel(); 
            var myUpdate = new LogModel
            {
                PhoneID = "Phone id"
            };

            // Act
            var result = myTest.Update(null);

            // Assert
            Assert.AreEqual(myUpdate.PhoneID, myTest.PhoneID);
        }
    }
}
