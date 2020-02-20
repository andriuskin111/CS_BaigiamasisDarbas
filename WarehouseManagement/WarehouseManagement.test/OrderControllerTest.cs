using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BusinesLogic;

namespace WarehouseManagement.test
{
    [TestClass]
    public class OrderControllerTest
    {
        [TestMethod]
        public void TestCreateOrder()
        {
            // Arrange
            OrderController orderController = new OrderController();

            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB Rasmitas");
            orderController.CreateNewOrder(3, "UAB TRT Shop");

            int expected = 3;

            // Act
            int actual = orderController.Retrieve().Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRetrieveWhithOrderId()
        {
            // Arrange
            OrderController orderController = new OrderController();

            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB Rasmitas");
            orderController.CreateNewOrder(3, "UAB TRT Shop");

            string expected = "UAB Rasmitas";

            // Act
            string actual = orderController.Retrieve(2).Customer;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddPart()
        {
            // Arrange
            Part part;
            Order order;
            PartCategory partCategory;
            OrderController orderController = new OrderController();
            PartRepository partRepository = new PartRepository();
            List<Part> parts = partRepository.Retrieve();
            
            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB Rasmitas");
            orderController.CreateNewOrder(3, "UAB TRT Shop");

            orderController.AddPart(2, parts[1]);
            order = orderController.Retrieve(2);

            List<Part> orderedPart = order.Parts;

            part = orderedPart[0];
            partCategory = part.Category;

            string expected = "Brakes";


            // Act
            string actual = partCategory.Decription;

            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRemovePart()
        {
            // Arrange
            Order order;
            OrderController orderController = new OrderController();
            PartRepository partRepository = new PartRepository();
            List<Part> parts = partRepository.Retrieve();

            orderController.CreateNewOrder(1, "UAB EAMV");
            orderController.CreateNewOrder(2, "UAB Rasmitas");
            orderController.CreateNewOrder(3, "UAB TRT Shop");

            orderController.AddPart(2, parts[1]);
            orderController.AddPart(2, parts[1]);
            orderController.RemovePart(2, 2);
            order = orderController.Retrieve(2);

            List<Part> orderedPart = order.Parts;

            int expected = 1;

            // Act
            int actual = orderedPart.Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
