using aspTask1.Interfaces;
using System;

namespace aspTask1.Entities
{
    public class HotMeal : IProduct
    {
        // public properties :
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        // default constructor :
        public HotMeal() { }

        // parametric construnctor : 
        public HotMeal(string name,string description,double price)
        {
            Id = new Random().Next(1, 10000);
            Name = name;
            Description = description;
            Price = price;
        }

        // to string override - method : 
        public override string ToString() =>
$@"
ID : {Id}
Name : {Name}
Description : {Description}
Price : ${Price}
";           
    }

}
