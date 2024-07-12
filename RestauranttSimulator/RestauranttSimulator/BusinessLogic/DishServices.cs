using RestauranttSimulator.Entities;

namespace RestauranttSimulator.BusinessLogic;

public class DishServices
{
    public static List<Dish> FindDishesByCategory(List<Dish> dishes, Category category)
    {
        List<Dish> newList = new List<Dish>();
        foreach (Dish dish in dishes)
        {
            if (dish.Category.Id == category.Id)
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
