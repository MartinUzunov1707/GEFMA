using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Dish
    {
        public Dish(string DishName, decimal DishPrice, string DishDesc, byte[] DishImage, bool DishIsVegetarian, bool DishIsVegan, bool DishIsGlutenFree, bool DishIsKosher, float DishEstimatedTimeToComplete)
        {
            Name = DishName;
            Price = DishPrice;
            Description = DishDesc;
            Image = DishImage;
            IsVegetarian = DishIsVegetarian;
            IsVegan = DishIsVegan;
            IsGlutenFree = DishIsGlutenFree;
            IsKosher = DishIsKosher;
            EstimatedTimeToComplete = DishEstimatedTimeToComplete;
        }
        public Dish()
        { }
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsKosher { get; set; }
        public float EstimatedTimeToComplete { get; set; }
    }
}
