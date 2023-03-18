using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;

public class OrderBusiness
{
    private OrderContext orderContext;
    public List<Order> GetAll()
    {
        using (OrderContext = new OrderContext())
        {
            return OrderContext.Orders.ToList();
        }
    }
    public Order Get(int id)
    {
        using (OrderContext = new OrderContext())
        {
            return OrderContext.Orders.Find(id);
        }
    }
    public void Add(Order dish)
    {
        using (OrderContext = new OrderContext())
        {
            OrderContext.Orders.Add(dish);
            OrderContext.SaveChanges();
        }
    }
    public void Update(Dish dish)
    {
        using (OrderContext = new OrderContext())
        {
            Order item = OrderContext.Orders.Find(dish.ID);
            if (item != null)
            {
                OrderContext.Entry(item).CurrentValues.SetValues(dish);
                OrderContext.SaveChanges();
            }
        }
    }
}
