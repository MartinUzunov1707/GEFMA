using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using Data.Models;
using Business;

namespace UnitTests
{
    /// <summary>
    /// A TestClass that contains UnitTests for the OrderBusiness class.
    /// </summary>
    [TestClass]
    public class OrderBussinessTests
    {
        /// <summary>
        /// A TestMethod that tests the Add method in the OrderBusiness class.
        /// </summary>
        [TestMethod]
        public void TestAddMethod()
        {
            OrderBusiness business = new OrderBusiness();
            RestaurantBusiness resbusiness = new RestaurantBusiness();
            List<Data.Dish> List = resbusiness.GetAll();
            Data.Models.Order order = new Data.Models.Order(List, 10, 10);
            int Length = business.GetAll().Count();
            business.Add(order);
            bool AreEqual = business.GetAll().Count() == Length + 1;
            Assert.IsTrue(AreEqual);
            business.Delete(order.ID);
        }
        /// <summary>
        /// A TestMethod that tests the Delete method in the OrderBusiness class.
        /// </summary>
        [TestMethod]
        public void TestDeleteMethod()
        {
            OrderBusiness business = new OrderBusiness();
            int Length = business.GetAll().Count();
            RestaurantBusiness resbusiness = new RestaurantBusiness();
            List<Data.Dish> List = resbusiness.GetAll();
            Data.Models.Order order = new Data.Models.Order(List, 10, 10);
            business.Add(order);
            business.Delete(business.GetAll().Count - 1);
            Assert.IsTrue(Length == business.GetAll().Count - 1);
            business.Delete(order.ID);
        }
        /// <summary>
        /// A TestMethod that tests the Update method in the OrderBusiness class.
        /// </summary>
        [TestMethod]
        public void TestUpdateMethod()
        {
            OrderBusiness business = new OrderBusiness();
            RestaurantBusiness resbusiness = new RestaurantBusiness();
            List<Data.Dish> List = resbusiness.GetAll();
            Data.Models.Order order = new Data.Models.Order(List, 10, 10);
            Data.Models.Order updated = order;
            updated.Price = 100;
            business.Add(order);
            business.Update(updated);
            Assert.IsTrue(business.GetAll().LastOrDefault().Price == 100);
            business.Delete(order.ID);
        }
        /// <summary>
        /// A TestMethod that tests the Get method in the OrderBusiness class.
        /// </summary>
        [TestMethod]
        public void TestGetMethod()
        {
            OrderBusiness business = new OrderBusiness();
            RestaurantBusiness resbusiness = new RestaurantBusiness();
            List<Data.Dish> List = resbusiness.GetAll();
            Data.Models.Order order = new Data.Models.Order(List, 10, 10);
            business.Add(order);
            Assert.IsTrue(business.GetAll().LastOrDefault().ID == business.Get(order.ID).ID);
            business.Delete(order.ID);
        }
    }
}
