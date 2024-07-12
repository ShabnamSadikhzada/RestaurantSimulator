using RestauranttSimulator.Entities;
using System.Security.Cryptography;

namespace RestauranttSimulator.Entities;

public class Dish : BaseEntity
{
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }

    public Dish(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;        
    }
}
