using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        public Order(List<Dish> OrderDishes, float OrderPrice, float OrderETA)
        {
            this.OrderedDishes = OrderDishes;
            this.Price= OrderPrice;
            this.ETA= OrderETA;
        }
        public List<Dish> OrderedDishes { get; set; }
        public float Price{ get; set; }
        public float ETA { get; set; }
    }
  
        
}
