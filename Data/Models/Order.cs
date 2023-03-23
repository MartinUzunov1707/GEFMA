using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Model for the Order class. Database uses this model. (Code first approach)
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Enum used to declare Order states.
        /// </summary>
        public enum OrderStates : int
        {
            Ordered = 0,
            InProgress,
            Completed
        }
        /// <summary>
        /// Constructor for Order class. This constructor fills every field in the class. By default the OrderState is "Ordered";
        /// </summary>
        /// <param name="OrderDishes"></param>
        /// <param name="OrderPrice"></param>
        /// <param name="OrderETA"></param>
        public Order(List<Dish> OrderDishes, decimal OrderPrice, float OrderETA)
        {
            OrderDishes.ForEach(x => OrderedDishes += x.Name + "-");
            OrderedDishes = OrderedDishes.Substring(0, OrderedDishes.Length - 1);
            Price = OrderPrice;
            ETA = OrderETA;
            OrderState = OrderStates.Ordered;
        }
        /// <summary>
        /// Empty constructor for the class. Used in testing.
        /// </summary>
        public Order() 
        { }
        /// <summary>
        /// Public fields that the class and database contain. Includes a field of the OrderStates enum.
        /// </summary>
        public int ID { get; set; }
        public string OrderedDishes { get; set; }
        public decimal Price{ get; set; }
        public float ETA { get; set; }
        public OrderStates OrderState { get; set; }
    }  
}
