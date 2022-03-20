namespace MealSharingNET.Services;
using MealSharingNET.Models;
public class InMemoryMealRepository : IMealRepository
{

    private List<Meal> Meals { get; set; } = new List<Meal>(){
        new Meal(){ ID=0, Title="Sandwich", Description="Chicken",Cost=100,MaxReservations=2},
        new Meal(){ID=1, Title="Pizza", Description="vegeterian",Cost=100,MaxReservations=2},
        new Meal(){ID=2, Title="Burger", Description="double size",Cost=100,MaxReservations=2}
    };

    public IEnumerable<Meal> ListMeals()
    {
        return Meals;
    }

    public void Add(Meal m)
    {
        Meals.Add(m);
    }

    public void Delete(int ID)
    {
        Meals.RemoveAll(m => m.ID == ID);
    }
}
