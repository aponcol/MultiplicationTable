using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MultiplicationTable;
using MultiplicationTable.Controllers;
using static MultiplicationTable.Controllers.HomeController;

namespace MultiplicationTable.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void IndexTakesMatrixSizeAndMatrixBaseToReturnAProperTable()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = (ViewResult)controller.Index("8", "Decimal");

            // Assert
            int[,] table = result.ViewBag.Table;
            Assert.AreEqual(4, table[1, 1]);
        }
    }
}
