using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        public Order(List<Dish> OrderDishes, decimal OrderPrice, float OrderETA)
        {
            OrderedDishes = OrderDishes;
            Price = OrderPrice;
            ETA = OrderETA;
        }
        public Order() 
        { }
        public int ID { get; set; }
        public List<Dish> OrderedDishes { get; set; }
        public decimal Price{ get; set; }
        public float ETA { get; set; }
    }  
}
