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
    }
}
