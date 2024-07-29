using Task2Homework.Entities;
namespace Task2Homework.Models
{
    public class EditFastFoodViewModel
    {
        // public properties : 
        public FastFood  FastFood { get; set; }

        // default constructor : 
        public EditFastFoodViewModel(){}

        // parametric constructor : 
        public EditFastFoodViewModel(FastFood fastFood)
        {
            FastFood = fastFood;
        }
    }
}
