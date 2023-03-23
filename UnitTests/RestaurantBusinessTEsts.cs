using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTests
{
    /// <summary>
    /// A TestClass that contains UnitTests for the RestaurantBusiness class.
    /// </summary>
    [TestClass]
    public class RestaurantBusinessTests
    {
        /// <summary>
        /// A TestMethod that tests the Add method in the RestaurantBusiness class.
        /// </summary>
        [TestMethod]
        public void TestAddMethod()
        {
            Business.RestaurantBusiness business = new Business.RestaurantBusiness();
            Data.Dish dish = new Data.Dish("TestName", 2, "TestDesc", new byte[64], true, true, true, true, 2f);
            int Length = business.GetAll().Count();
            business.Add(dish);
            bool AreEqual = business.GetAll().Count() == Length + 1;
            Assert.IsTrue(AreEqual);
            business.Delete(dish.ID);
        }
        /// <summary>
        /// A TestMethod that tests the Delete method in the RestaurantBusiness class.
        /// </summary>
        [TestMethod]
        public void TestDeleteMethod()
        {
            Business.RestaurantBusiness business = new Business.RestaurantBusiness();
            int Length = business.GetAll().Count();
            Data.Dish dish = new Data.Dish("TestName", 2, "TestDesc", new byte[64], true, true, true, true, 2f);
            business.Add(dish);
            business.Delete(business.GetAll().Count - 1);
            Assert.IsTrue(Length == business.GetAll().Count - 1);
            business.Delete(dish.ID);
        }
        /// <summary>
        /// A TestMethod that tests the Update method in the RestaurantBusiness class.
        /// </summary>
        [TestMethod]
        public void TestUpdateMethod()
        {
            Business.RestaurantBusiness business = new Business.RestaurantBusiness();
            Data.Dish dish = new Data.Dish("TestName", 2, "TestDesc", new byte[64], true, true, true, true, 2f);
            Data.Dish updated = dish;
            updated.Price = 100;
            business.Add(dish);
            business.Update(updated);
            Assert.IsTrue(business.GetAll().LastOrDefault().Price == 100);
            business.Delete(dish.ID);
        }
        /// <summary>
        /// A TestMethod that tests the Get method in the RestaurantBusiness class.
        /// </summary>
        [TestMethod]
        public void TestGetMethod()
        {
            Business.RestaurantBusiness business = new Business.RestaurantBusiness();
            Data.Dish dish = new Data.Dish("TestName", 2, "TestDesc", new byte[64], true, true, true, true, 2f);
            business.Add(dish);
            Assert.IsTrue(business.GetAll().LastOrDefault().ID == business.Get(dish.ID).ID);
            business.Delete(dish.ID);
        }
    }
}
