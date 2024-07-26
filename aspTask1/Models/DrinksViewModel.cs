using aspTask1.Entities;
using System.Collections;
using System.Collections.Generic;

namespace aspTask1.Models
{
    public class DrinksViewModel
    {
        public static List<Drink> Drinks { get; set; } = new List<Drink>()
        {
            new Drink
            {
                Id = 1,
                Name = "Coca-Cola",
                Price = 2,
                Description = "This is the coca cola",
                IsHot = false,
            },
             new Drink
            {
                Id = 2,
                Name = "Fanta",
                Price = 1.8,
                Description = "This is the fanta",
                IsHot = false,
            },
              new Drink
            {
                Id = 3,
                Name = "Coffee",
                Price = 0.8,
                Description = "This is the coffee",
                IsHot = true,
            },
               new Drink
            {
                Id = 4,
                Name = "Smuzzy",
                Price = 4.5,
                Description = "This is the fresh Smoozy",
                IsHot = false,
            },
                new Drink
            {
                Id = 5,
                Name = "Pop",
                Price = 3.5,
                Description = "This is the 'POP sireleri' ",
                IsHot = false,
            }
        };
    }
}
