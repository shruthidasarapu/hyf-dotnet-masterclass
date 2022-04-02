namespace MealSharingApp.Services;
using MealSharingApp.Models;
public interface IMealRepository
{
    Task AddMeal(Meal meal);
    Task<IEnumerable<Meal>> ListMeals();
    Task<Meal> FindMealById(int id);
    Task DeleteMeal(int id);

}