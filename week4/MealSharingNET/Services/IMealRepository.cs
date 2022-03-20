namespace MealSharingNET.Services;
using MealSharingNET.Models;
public interface IMealRepository
{
    IEnumerable<Meal> ListMeals();

    void Add(Meal m);

    void Delete(int ID);
}