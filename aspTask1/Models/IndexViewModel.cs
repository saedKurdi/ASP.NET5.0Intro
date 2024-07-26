using aspTask1.Entities;
using System.Collections;
using System.Collections.Generic;

namespace aspTask1.Models
{
    public class IndexViewModel
    {
        public List<HotMeal> HotMeals { get; set; } = HotMealsViewModel.HotMeals;
        public List<FastFood> FastFoods { get; set; }  = FastFoodsViewModel.FastFoods;
        public List<Drink> Drinks { get; set; } = DrinksViewModel.Drinks;

    }
}
