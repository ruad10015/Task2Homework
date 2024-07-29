using Task2Homework.Entities;
using Task2Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Task2Homework.Controllers
{
    public class FastFoodController : Controller
    {
        static FastFoodsViewModel FastFoodsViewModel { get; set; } = new FastFoodsViewModel
        {
            FastFoods =
            {
                new FastFood(1, "Cheeseburger", "Burger with cheese, meal and etc.", 10, 20),
                new FastFood(2, "Chicken Nuggets", "Crispy chicken nuggets served with dipping sauce.", 4, 30),
                new FastFood(3, "Pepperoni Pizza", "Classic Italian pizza with pepperoni", 15, 15),
                new FastFood(4, "Margaritta Pizza", "Classic Italian pizza with a low of cheese", 12, 15),
                new FastFood(5, "Hot-Dog", "A tasty hot dog with your choice of toppings.", 4, 50),
                new FastFood(6, "French Fries", "Golden crispy French fries.", 5, 2),
                new FastFood(7, "Chips", "Made by potato", 7, 35),
                new FastFood(8, "Club Sandwich", "Grilled chicken sandwich with omelette and etc.", 8, 28),
                new FastFood(9, "Döner", "A doner kebab typically includes ingredients such as sliced lamb, pita bread, lettuce, etc.", 5, 5),
                new FastFood(10, "shawarma in lavash", "A shawarma in lavash typically includes ingredients such as sliced chicken, lavash bread, lettuce, etc.", 15, 20)

            }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(FastFoodsViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            FastFoodsViewModel.DeleteFastFoodById(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var currentFastFood = FastFoodsViewModel.FastFoods.FirstOrDefault(f => f.Id == id);
            var newFastFood = new FastFood(currentFastFood.Id,currentFastFood.Name,currentFastFood.Description,currentFastFood.Price,currentFastFood.Discount);
            var vm = new EditFastFoodViewModel(newFastFood);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditFastFoodViewModel vm)
        {
            if (ModelState.IsValid) {
                var oldFastFood = FastFoodsViewModel.FastFoods.FirstOrDefault( f=> f.Id == vm.FastFood.Id);
                var index = FastFoodsViewModel.FastFoods.IndexOf(oldFastFood);
                FastFoodsViewModel.FastFoods[index] = vm.FastFood;
                return RedirectToAction(nameof(Index));
            }
            else return View(vm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new AddFastFoodViewModel(new FastFood());
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(AddFastFoodViewModel vm) {
            if (ModelState.IsValid) {
                vm.FastFood.Id = FastFoodsViewModel.FastFoods.Count + 1;
                FastFoodsViewModel.AddNewFastFood(vm.FastFood);
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }
    }
}
