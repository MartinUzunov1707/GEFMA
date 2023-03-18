using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

public class OrderContext : DbContext
{
    public OrderContext() : base("name=OrderContext") { }
    public DbSet<Order> Orders { get; set; }
}