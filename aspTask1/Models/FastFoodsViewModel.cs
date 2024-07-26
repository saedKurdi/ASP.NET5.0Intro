using aspTask1.Entities;
using System.Collections;
using System.Collections.Generic;

namespace aspTask1.Models
{
    public class FastFoodsViewModel
    {
        public static List<FastFood> FastFoods { get; set; } = new List<FastFood>
{
    new FastFood
    {
        Name = "Cheeseburger",
        Description = "A juicy beef patty with melted cheese, lettuce, tomato, and pickles.",
        Price = 5.99,
        Ccal = 650
    },
    new FastFood
    {
        Name = "Chicken Nuggets",
        Description = "Crispy breaded chicken nuggets served with your choice of dipping sauce.",
        Price = 4.49,
        Ccal = 320
    },
    new FastFood
    {
        Name = "Fries",
        Description = "Golden, crispy fries seasoned with a touch of salt.",
        Price = 2.99,
        Ccal = 365
    },
    new FastFood
    {
        Name = "Milkshake",
        Description = "Creamy and rich milkshake made with real ice cream and topped with whipped cream.",
        Price = 3.49,
        Ccal = 450
    },
    new FastFood
    {
        Name = "Hot Dog",
        Description = "A classic hot dog served in a bun with mustard and ketchup.",
        Price = 3.29,
        Ccal = 250
    }
};

    }
}
