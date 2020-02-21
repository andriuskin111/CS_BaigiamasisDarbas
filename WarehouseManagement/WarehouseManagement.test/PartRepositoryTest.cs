using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BusinesLogic;

namespace WarehouseManagement.test
{
    [TestClass]
    public class PartRepositoryTest
    {
        [TestMethod]
        public void TestAddNewPart()
        {
            // Arrange
            PartRepository partRepository = new PartRepository();

            partRepository.AddNewPart(new Part(1, "111", "Audi", "A6", "Brake disc front", new PartCategory(1, "1", "Brakes"), new PartLocation(1, "A1", "Green")));

            int expected = 9;

            // Act
            int actual = partRepository.Retrieve().Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRemovePart()
        {
            // Arrange
            PartRepository partRepository = new PartRepository();

            partRepository.RemovePart(1);

            int expected = 7;

            // Act
            int actual = partRepository.Retrieve().Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRemoveRetrieve()
        {
            // Arrange
            PartRepository partRepository = new PartRepository();

            int expected = 8;

            // Act
            int actual = partRepository.Retrieve().Count;


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRemoveRetrieveWithPartCode()
        {
            // Arrange
            PartRepository partRepository = new PartRepository();
            Part part = partRepository.Retrieve("111");

            string expected = "A6";

            // Act
            string actual = part.Model;


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
