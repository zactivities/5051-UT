﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ReportViewModel();
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange
            var testReportViewModel = new ReportViewModel();
            // Act
            int numUsers = testReportViewModel.NumberOfUsers;
            // Assert
            Assert.AreEqual(0, numUsers);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange
            var testReportViewModel = new ReportViewModel();
            // Act
            testReportViewModel.NumberOfUsers = 11;
            // Assert
            Assert.AreEqual(11, testReportViewModel.NumberOfUsers);
        }


    }
}
