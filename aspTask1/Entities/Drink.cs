using aspTask1.Interfaces;
using System;

namespace aspTask1.Entities
{
    public class Drink : IProduct
    {
        // public properties : 
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsHot { get; set; }

        // parametric constructor : 
        public Drink(string name , string description,double price,bool isHot) 
        {
            Id = new Random().Next(1, 10000);
            Name = name;
            Description = description;
            Price = price;
            IsHot = isHot;
        }

        // default constructor : 
        public Drink() { }

        // to string override : 
        public override string ToString()
        {
            return 
@$"
ID : {Id}
Name : {Name}
Description : {Description}
Price : ${Price}
{(IsHot ? "Hot" : "Not Hot")}
";
        }
    }
}
