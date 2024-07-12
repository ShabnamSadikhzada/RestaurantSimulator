using System.Security.Cryptography;

namespace RestauranttSimulator.Models;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }

    public Dish(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;        
    }

    public static List<Dish> FindDishesByCategory(List<Dish> dishes, Category category)
    {
        List<Dish> newList = new List<Dish>();
        foreach (Dish dish in dishes)
        {
            if(dish.Category.Id == category.Id)
                newList.Add(dish);
        }

        return newList;
    }

    public static List<Dish> FindDishesByCategory(List<Dish> dishes, int categoryId)
    {
        List<Dish> newList = new List<Dish>();
        foreach (Dish dish in dishes)
        {
            if (dish.Category.Id == categoryId)
                newList.Add(dish);
        }

        return newList;
    }
}
