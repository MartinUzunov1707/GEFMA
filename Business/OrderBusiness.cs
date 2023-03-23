using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;

/// <summary>
/// This class keeps all the business logic for the order database.
/// The class implements all the CRUD operations.
/// </summary>
public class OrderBusiness
{
    
    private OrderContext OrderContext;
    /// <summary>
    /// The GetAll function returns all of the databases content in a list.
    /// </summary>
    public List<Order> GetAll()
    {
        using (OrderContext = new OrderContext())
        {
            return OrderContext.Orders.ToList();
        }
    }

    /// <summary>
    /// The Get function returns an object of Order type by its ID.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Order Get(int id)
    {
        using (OrderContext = new OrderContext())
        {
            return OrderContext.Orders.Find(id);
        }
    }
    /// <summary>
    /// The Add function adds an Order to the Order Database.
    /// </summary>
    /// <param name="dish"></param>
    public void Add(Order dish)
    {
        using (OrderContext = new OrderContext())
        {
            OrderContext.Orders.Add(dish);
            OrderContext.SaveChanges();
        }
    }
    /// <summary>
    /// The Update function Updates a preexisting Order with new values.
    /// </summary>
    /// <param name="dish"></param>
    public void Update(Order dish)
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
    /// <summary>
    /// The Delete function deletes an item from the Order Database by its ID.
    /// </summary>
    /// <param name="id"></param>
    public void Delete(int id)
    {
        using (OrderContext = new OrderContext())
        {
            Order item = OrderContext.Orders.Find(id);
            if (item != null)
            {
                OrderContext.Orders.Remove(item);
                OrderContext.SaveChanges();
            }
        }
    }
}
