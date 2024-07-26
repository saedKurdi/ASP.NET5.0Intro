using aspTask1.Interfaces;
using System;

namespace aspTask1.Entities
{
    public class FastFood : IProduct
    {
        // public properties : 
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Ccal { get; set; }

        // parametric constructor : 
        public FastFood(string name,string description,double price,double ccal)
        {
            Id = new Random().Next(0,10000);
            Name = name;
            Description = description;
            Price = price;
            Ccal = ccal;
        }

        // default constructor : 
        public FastFood() { }

        // to string override : 
        public override string ToString()
        {
            return
@$"
ID : {Id}
Name : {Name}
Description : {Description}
Price : ${Price}
Ccals (per 100 gr) : {Ccal}ccals
";
        }

    }
}
