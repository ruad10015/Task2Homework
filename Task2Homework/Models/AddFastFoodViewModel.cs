using Task2Homework.Entities;
namespace Task2Homework.Models
{
    public class AddFastFoodViewModel
    {
        // public properties : 
        public FastFood FastFood {get;set;}

        // default constructor : 
        public AddFastFoodViewModel(){}

        // parametric constructor : 
        public AddFastFoodViewModel(FastFood fastFood)
        {
            FastFood = fastFood;
        }
    }
}
