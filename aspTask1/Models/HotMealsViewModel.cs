using aspTask1.Entities;
using System.Collections;
using System.Collections.Generic;

namespace aspTask1.Models
{
    public class HotMealsViewModel
    {
        public static List<HotMeal> HotMeals { get; set; } = new List<HotMeal>
{
    new HotMeal
    {
        Id = 1,
        Name = "Spaghetti Bolognese",
        Description = "Classic Italian spaghetti with a rich, meaty Bolognese sauce.",
        Price = 12.99
    },
    new HotMeal
    {
        Id = 2,
        Name = "Beef Stroganoff",
        Description = "Tender beef strips in a creamy mushroom sauce, served over egg noodles.",
        Price = 14.49
    },
    new HotMeal
    {
        Id = 3,
        Name = "Chicken Parmesan",
        Description = "Breaded chicken breast topped with marinara sauce and melted mozzarella cheese.",
        Price = 13.49
    },
    new HotMeal
    {
        Id = 4,
        Name = "Vegetable Stir-Fry",
        Description = "A mix of fresh vegetables stir-fried with tofu in a savory soy-ginger sauce.",
        Price = 11.99
    },
    new HotMeal
    {
        Id = 5,
        Name = "Lamb Curry",
        Description = "Slow-cooked lamb in a spicy, aromatic curry sauce, served with rice.",
        Price = 15.99
    }
};


    }
}
