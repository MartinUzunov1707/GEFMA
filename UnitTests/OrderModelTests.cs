using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Windows.Forms;

namespace UnitTests
{
    [TestClass]
    public class OrderModelTests
    {
        public Dish TestDish1 = new Dish("testName", 15, "testDescription", new byte[64], true, true, true, true, 15.0f);
        public Dish TestDish2 = new Dish("testName2", 20, "testDescription2", new byte[64], true, false, true, false, 20.0f);
        [TestMethod]
        public void OrderModelKeepsDishListValue()
        {

            List<Dish> dishes = new List<Dish>();
            dishes.Add(TestDish1);
            dishes.Add(TestDish2);
            Order order = new Order(dishes,200.0m,25.5f);
            bool isEqual = (order.OrderedDishes.Split('-')[0] == TestDish1.Name) && (order.OrderedDishes.Split('-')[1] == TestDish2.Name);
            Assert.IsTrue(isEqual);
        }
        [TestMethod]
        public void OrderModelKeepsOrderPriceValue()
        {
            List<Dish> dishes = new List<Dish>();
            dishes.Add(TestDish1);
            dishes.Add(TestDish2);
            Order order = new Order(dishes, 200.0m, 25.5f);
            Assert.IsTrue(order.Price == 200.0m);
        }
        [TestMethod]
        public void OrderModelKeepsOrderETAValue()
        {
            List<Dish> dishes = new List<Dish>();
            dishes.Add(TestDish1);
            dishes.Add(TestDish2);
            Order order = new Order(dishes, 200.0m, 25.5f);
            Assert.IsTrue(order.ETA == 25.5f);
        }      
    }
}
