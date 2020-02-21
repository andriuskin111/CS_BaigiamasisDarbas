using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BusinesLogic;

namespace WarehouseManagement.test
{
    [TestClass]
    public class ReportGeneratorTest
    {
        [TestMethod]
        public void TestGenerateReportGeneral()
        {
            // Arrange
            OrderController orderController = new OrderController();
            PartRepository partRepository = new PartRepository();
            List<Part> parts = partRepository.Retrieve();
            ReportGenerator reportGenerator = new ReportGenerator(orderController);

            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB Rasmitas");
            orderController.CreateNewOrder(3, "UAB TRT Shop");

            orderController.AddPart(1, parts[1]);
            orderController.AddPart(1, parts[2]);
            orderController.AddPart(2, parts[3]);
            orderController.AddPart(2, parts[4]);
            orderController.AddPart(3, parts[5]);
            orderController.AddPart(3, parts[0]);

            int expected = 3;

            // Act
            int actual = reportGenerator.GenerateReport().Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGenerateReportByOrderId()
        {
            // Arrange
            OrderController orderController = new OrderController();
            PartRepository partRepository = new PartRepository();
            List<Part> parts = partRepository.Retrieve();
            ReportGenerator reportGenerator = new ReportGenerator(orderController);

            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB Rasmitas");
            orderController.CreateNewOrder(3, "UAB TRT Shop");

            orderController.AddPart(1, parts[1]);
            orderController.AddPart(1, parts[2]);
            orderController.AddPart(2, parts[3]);
            orderController.AddPart(2, parts[4]);
            orderController.AddPart(3, parts[5]);
            orderController.AddPart(3, parts[0]);

            int expected = 1;

            // Act
            int actual = reportGenerator.GenerateReport(2).Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGenerateReporByDate()
        {
            // Arrange
            OrderController orderController = new OrderController();
            ReportGenerator reportGenerator = new ReportGenerator(orderController);

            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB Rasmitas");
            orderController.CreateNewOrder(3, "UAB TRT Shop");

            int expected = 3;

            // Act
            int actual = reportGenerator.GenerateReport(new DateTime(2020,02,21)).Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGenerateReporByCustomer()
        {
            // Arrange
            OrderController orderController = new OrderController();
            ReportGenerator reportGenerator = new ReportGenerator(orderController);

            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB Rasmitas");
            orderController.CreateNewOrder(3, "UAB TRT Shop");
            orderController.CreateNewOrder(4, "UAB TRT Shop");

            int expected = 2;

            // Act
            int actual = reportGenerator.GenerateReport("UAB TRT Shop").Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
