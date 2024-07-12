using RestauranttSimulator.Entities;

namespace RestauranttSimulator.BusinessLogic;

public class RestaurantServices
{
    public void AddDish(List<Dish> menu, Dish dish)
    {
        menu.Add(dish);
    }

    public void PlaceOrder(List<Order> orders, Order order)
    {
        orders.Add(order);
    }

    public Order? FindOrder(List<Order> orders, int id)
    {
        //foreach (Order order in orders)
        //{
        //    if(order.Id == id) 
        //        return order;
        //}
        //return null;

        Order? order = orders.Find(o => o.Id == id);
        return order;
    }
}
