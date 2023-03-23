using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        public enum OrderStates : int
        {
            Ordered = 0,
            InProgress,
            Completed
        }
        public Order(List<Dish> OrderDishes, decimal OrderPrice, float OrderETA)
        {
            OrderDishes.ForEach(x => OrderedDishes += x.Name + "-");
            OrderedDishes = OrderedDishes.Substring(0, OrderedDishes.Length - 1);
            Price = OrderPrice;
            ETA = OrderETA;
            OrderState = OrderStates.Ordered;
        }
        public Order() 
        { }
        public int ID { get; set; }
        public string OrderedDishes { get; set; }
        public decimal Price{ get; set; }
        public float ETA { get; set; }
        public OrderStates OrderState { get; set; }
    }  
}
