using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// RestaurantContext class. Inherits from DbContext. (Code first approach)
    /// </summary>
    public class RestaurantContext : DbContext
    {
        /// <summary>
        /// A constructor for the class that passes the name of the context to the DbContext constructor.
        /// </summary>
        public RestaurantContext() : base("name=RestaurantContext") { }
        /// <summary>
        /// A public field of the DbSet type that stores dishes.
        /// </summary>
        public DbSet<Dish> Dishes { get; set; }
    }
 }
