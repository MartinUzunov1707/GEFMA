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
    [TestClass]
    public class DishModelTests
    {
        [TestMethod]
        public void DishModelKeepsNameValue()
        {
            string name = "TestName";
            decimal dishPrice = 12.2m;
            string description = "Test Description";
            byte[] testImage = new byte[64];
            Dish testDish = new Dish(name,dishPrice,description,testImage,true,true,true,true,15.2f);
            Assert.AreEqual(name, testDish.Name);
        }
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
