using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    /// <summary>
    /// The RestaurantBusiness class handles all of the business logic for the RestaurantDB Database.
    /// </summary>
    public class RestaurantBusiness
    {
        private RestaurantContext RestaurantContext;
        /// <summary>
        /// The GetAll Function returns the content of the Restaurant Database in the form of a List.
        /// </summary>
        /// <returns></returns>
        public List<Dish> GetAll()
        {
            using (RestaurantContext = new RestaurantContext())
            {
                return RestaurantContext.Dishes.ToList();
            }
        }
        /// <summary>
        /// The Get Function returns a Dish from the Restaurant Database by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Dish Get(int id)
        {
            using (RestaurantContext = new RestaurantContext())
            {
                return RestaurantContext.Dishes.Find(id);
            }
        }
        /// <summary>
        /// The Add function adds an item to the Restaurant Database.
        /// </summary>
        /// <param name="dish"></param>
        public void Add(Dish dish)
        {
            using (RestaurantContext = new RestaurantContext())
            {
                RestaurantContext.Dishes.Add(dish);
                RestaurantContext.SaveChanges();
            }
        }
        /// <summary>
        /// The Update function updates a preexisting item from the Restaurant Database with new values.
        /// </summary>
        /// <param name="dish"></param>
        public void Update(Dish dish)
        {
            using (RestaurantContext = new RestaurantContext())
            {
                Dish item = RestaurantContext.Dishes.Find(dish.ID);
                if (item != null)
                {
                    RestaurantContext.Entry(item).CurrentValues.SetValues(dish);
                    RestaurantContext.SaveChanges();
                }
            }
        }
        /// <summary>
        /// The Delete function deletes an item from the Restaurant Database by its ID.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            using (RestaurantContext = new RestaurantContext())
            {
                Dish item = RestaurantContext.Dishes.Find(id);
                if (item != null)
                {
                    RestaurantContext.Dishes.Remove(item);
                    RestaurantContext.SaveChanges();
                }
            }
        }
    }
}
