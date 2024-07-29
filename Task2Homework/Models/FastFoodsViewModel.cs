using Task2Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2Homework.Models
{
    public class FastFoodsViewModel
    {
        // public properties : 
        public List<FastFood> FastFoods { get; set; } = new List<FastFood>();

        // other methods : 
        public void DeleteFastFoodById(int id)
        {
            var fastFood = FastFoods.FirstOrDefault(ff => ff.Id == id);
            if (fastFood != null)
            {
                FastFoods.Remove(fastFood);
            }
        }

        public void AddNewFastFood(FastFood fastFood)
        {
            FastFoods.Add(fastFood);
        }
    }
}
