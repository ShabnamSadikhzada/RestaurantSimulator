using RestauranttSimulator.Entities;

namespace RestauranttSimulator;

public static class ExtensionMethods
{
    public static double Sum(this List<Dish> dishes)
    {
        double sum = 0;
        foreach (Dish dish in dishes)
        {
            sum += dish.Price;
        }

        return sum;
    }
}
