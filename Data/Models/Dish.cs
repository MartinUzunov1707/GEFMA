using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Model for the Dish class. Database uses this model. (Code first approach)
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// Constructor for dish class. This constructor fills every field in the class.
        /// </summary>
        /// <param name="DishName"></param>
        /// <param name="DishPrice"></param>
        /// <param name="DishDesc"></param>
        /// <param name="DishImage"></param>
        /// <param name="DishIsVegetarian"></param>
        /// <param name="DishIsVegan"></param>
        /// <param name="DishIsGlutenFree"></param>
        /// <param name="DishIsHalal"></param>
        /// <param name="DishEstimatedTimeToComplete"></param>
        public Dish(string DishName, decimal DishPrice, string DishDesc, byte[] DishImage, bool DishIsVegetarian, bool DishIsVegan, bool DishIsGlutenFree, bool DishIsHalal, float DishEstimatedTimeToComplete)
        {
            Name = DishName;
            Price = DishPrice;
            Description = DishDesc;
            Image = DishImage;
            IsVegetarian = DishIsVegetarian;
            IsVegan = DishIsVegan;
            IsGlutenFree = DishIsGlutenFree;
            IsHalal = DishIsHalal;
            EstimatedTimeToComplete = DishEstimatedTimeToComplete;
        }
        /// <summary>
        /// Empty constructor for the class. Used in Testing.
        /// </summary>
        public Dish()
        { }
        /// <summary>
        /// Public fields that the class and database contain.
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsHalal { get; set; }
        public float EstimatedTimeToComplete { get; set; }
    }
}
