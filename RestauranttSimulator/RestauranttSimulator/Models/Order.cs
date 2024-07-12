﻿namespace RestauranttSimulator.Models;

public class Order
{
    public int Id { get; set; }
    public List<Dish> Dishes { get; set; }
    //public double TotalAmount { get { return Dishes.Sum(); } }
    public double TotalAmount => Dishes.Sum();

    public Order(int id)
    {
        Id = id;
        Dishes = new List<Dish>();
    }
}
