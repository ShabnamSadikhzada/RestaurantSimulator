namespace RestauranttSimulator.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Dish> Dishes { get; set; }

    public Category(int id, string name) 
    {
        Id= id;
        Name= name;
        Dishes = new List<Dish>();
    }
}
