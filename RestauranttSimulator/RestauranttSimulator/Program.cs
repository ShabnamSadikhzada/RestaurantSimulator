using RestauranttSimulator.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace RestauranttSimulator;

public class Program
{
    static void Main(string[] args)
    {
        Dish dish1 = new Dish(1, "yemek adi1", 9.99);
        Dish dish2 = new Dish(2, "yemek adi2", 19.99);
        Dish dish3 = new Dish(3, "yemek adi3", 29.99);
        Dish dish4 = new Dish(4, "yemek adi4", 29.99);

        Category category1 = new Category(1, "ana yemek");
        Category category2 = new Category(2, "baslangic");
        Category category3 = new Category(3, "datli");

        dish1.Category = category1;
        dish2.Category = category2;
        dish3.Category = category3;
        dish4.Category = category2;

        category1.Dishes.Add(dish1);
        category2.Dishes.Add(dish2);
        category2.Dishes.Add(dish4);
        category3.Dishes.Add(dish3);

        Order order = new Order(1);
        order.Dishes.Add(dish1);
        order.Dishes.Add(dish3);
        order.Dishes.Add(dish4);

        List<Dish> foundDishes = Dish.FindDishesByCategory(order.Dishes, category1);
        List<Dish> foundDishesByID = Dish.FindDishesByCategory(order.Dishes, category2.Id);

        Restaurant restaurant = new Restaurant("restoran adi");
        restaurant.AddDish(dish1);
        restaurant.AddDish(dish2);
        restaurant.AddDish(dish3);
        restaurant.PlaceOrder(order);
        Order? foundOrder = restaurant.FindOrder(order.Id);

        #region cw
        Console.WriteLine("Dishes:");
        Console.WriteLine($"Dish 1: Id = {dish1.Id}, Name = {dish1.Name}, Price = {dish1.Price}, Category = {dish1.Category.Name}");
        Console.WriteLine($"Dish 2: Id = {dish2.Id}, Name = {dish2.Name}, Price = {dish2.Price}, Category = {dish2.Category.Name}");
        Console.WriteLine($"Dish 3: Id = {dish3.Id}, Name = {dish3.Name}, Price = {dish3.Price}, Category = {dish3.Category.Name}");
        Console.WriteLine($"Dish 4: Id = {dish4.Id}, Name = {dish4.Name}, Price = {dish4.Price}, Category = {dish4.Category.Name}");

        Console.WriteLine("\nCategories:");
        Console.WriteLine($"Category 1: Id = {category1.Id}, Name = {category1.Name}");
        Console.WriteLine($"Category 2: Id = {category2.Id}, Name = {category2.Name}");
        Console.WriteLine($"Category 3: Id = {category3.Id}, Name = {category3.Name}");

        Console.WriteLine("\nOrders:");
        Console.WriteLine($"Order 1: Id = {order.Id}, Total Amount = {order.TotalAmount}");
        foreach (var dish in order.Dishes)
        {
            Console.WriteLine($" - Dish: Id = {dish.Id}, Name = {dish.Name}, Price = {dish.Price}, Category = {dish.Category.Name}");
        }

        Console.WriteLine("\nFound Dishes by Category1:");
        foreach (var dish in foundDishes)
        {
            Console.WriteLine($" - Dish: Id = {dish.Id}, Name = {dish.Name}, Price = {dish.Price}, Category = {dish.Category.Name}");
        }

        Console.WriteLine("\nFound Dishes by Category2 Id:");
        foreach (var dish in foundDishesByID)
        {
            Console.WriteLine($" - Dish: Id = {dish.Id}, Name = {dish.Name}, Price = {dish.Price}, Category = {dish.Category.Name}");
        }

        Console.WriteLine("\nRestaurant:");
        Console.WriteLine($"Restaurant: Name = {restaurant.Name}");
        Console.WriteLine("Menu:");
        foreach (var dish in restaurant.Menu)
        {
            Console.WriteLine($" - Dish: Id = {dish.Id}, Name = {dish.Name}, Price = {dish.Price}, Category = {dish.Category.Name}");
        }
        Console.WriteLine("Orders:");
        foreach (var ord in restaurant.Orders)
        {
            Console.WriteLine($" - Order: Id = {ord.Id}, Total Amount = {ord.TotalAmount}");
        }
        if (foundOrder != null)
        {
            Console.WriteLine($"Found Order: Id = {foundOrder.Id}, Total Amount = {foundOrder.TotalAmount}");
        }

        #endregion

    }
}
