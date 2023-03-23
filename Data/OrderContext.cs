using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data
{
    /// <summary>
    /// OrderContext class. Inherits from DbContext. (Code first approach)
    /// </summary>
    public class OrderContext : DbContext
    {
        /// <summary>
        /// A constructor for the class that passes the name of the context to the DbContext constructor.
        /// </summary>
        public OrderContext() : base("name=OrderContext") { }
        /// <summary>
        /// A public field of the DbSet type that stores orders.
        /// </summary>
        public DbSet<Order> Orders { get; set; }
    }
}
