using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;

namespace UnitTests
{
    /// <summary>
    /// A TestClass that contains UnitTests for the Dish model.
    /// </summary>
    [TestClass]
    public class DishModelTests
    {
        /// <summary>
        /// A TestMethod that tests the Name field in the Dish model.
        /// </summary>
        [TestMethod]
        public void DishModelKeepsNameValue()
        {
            string name = "TestName";
            decimal dishPrice = 12.2m;
            string description = "Test Description";
            byte[] testImage = new byte[64];
            Dish testDish = new Dish(name, dishPrice, description, testImage, true, true, true, true, 15.2f);
            Assert.AreEqual(name, testDish.Name);
        }
        /// <summary>
        /// A TestMethod that tests the Price field in the Dish model.
        /// </summary>
        [TestMethod]
        public void DishModelKeepsPriceValue()
        {
            string name = "TestName";
            decimal dishPrice = 12.2m;
            string description = "Test Description";
            byte[] testImage = new byte[64];
            Dish testDish = new Dish(name, dishPrice, description, testImage, true, true, true, true, 15.2f);
            Assert.AreEqual(dishPrice, testDish.Price);
        }
        /// <summary>
        /// A TestMethod that tests the Description field in the Dish model.
        /// </summary>
        [TestMethod]
        public void DishModelKeepsDescriptionValue()
        {
            string name = "TestName";
            decimal dishPrice = 12.2m;
            string description = "Test Description";
            byte[] testImage = new byte[64];
            Dish testDish = new Dish(name, dishPrice, description, testImage, true, true, true, true, 15.2f);
            Assert.AreEqual(description, testDish.Description);
        }
        /// <summary>
        /// A TestMethod that tests the Image field in the Dish model.
        /// </summary>
        [TestMethod]
        public void DishModelKeepsImageValue()
        {
            string name = "TestName";
            decimal dishPrice = 12.2m;
            string description = "Test Description";
            byte[] testImage = new byte[64];
            Dish testDish = new Dish(name, dishPrice, description, testImage, true, true, true, true, 15.2f);
            Assert.AreEqual(testImage, testDish.Image);
        }
        /// <summary>
        /// A TestMethod that tests the ETA field in the Dish model.
        /// </summary>
        [TestMethod]
        public void DishModelKeepsETAValue()
        {
            string name = "TestName";
            decimal dishPrice = 12.2m;
            string description = "Test Description";
            byte[] testImage = new byte[64];
            float ETA = 15.2f;
            Dish testDish = new Dish(name, dishPrice, description, testImage, true, true, true, true, ETA);
            Assert.AreEqual(ETA, testDish.EstimatedTimeToComplete);
        }
    }
}
