namespace RestauranttSimulator.Models;

public class Order
{
    public int Id { get; set; }
    public List<Dish> Dishes { get; set; }
    public double TotalAmount { get; set; }

    public Order(int id)
    {
        Id = id;
        Dishes = new List<Dish>();
    }
}
