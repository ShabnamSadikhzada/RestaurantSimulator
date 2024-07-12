namespace RestauranttSimulator.Models;

public class Restaurant
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dish> Menu { get; set; }
    public List<Order> Orders { get; set; }

    public Restaurant(string name)
    {
        Name = name;
        Menu = new List<Dish>();
        Orders = new List<Order>();
    }

    public void AddDish(Dish dish)
    {
        Menu.Add(dish);
    }

    public void PlaceOrder(Order order)
    {
        Orders.Add(order);
    }

    public Order? FindOrder(int id)
    {
        //foreach (Order order in Orders)
        //{
        //    if(order.Id == id) 
        //        return order;
        //}
        //return null;

        Order? order = Orders.Find(o => o.Id == id);
        return order;
    }
}
