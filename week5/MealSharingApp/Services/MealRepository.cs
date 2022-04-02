namespace MealSharingApp.Services;
using System.Collections.Generic;
using Dapper;
using MealSharingApp.Models;
using MySql.Data.MySqlClient;
public class MealRepository : IMealRepository
{
    public async Task AddMeal(Meal meal)
    {

        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var mealId = await connection.ExecuteAsync("INSERT INTO Meal (ID, Title, Description, Price, `When`, Location, max_reservations, created_date) VALUES (@ID, @Title, @Description, @Price, @When, @Location,@MaxReservations, @CreatedDate)", meal);
    }

    public async Task DeleteMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("DELETE FROM Meal WHERE id=@ID", new { ID = id });
    }

    public async Task<Meal> FindMealById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryFirstAsync<Meal>("SELECT * FROM meal WHERE ID=@MealId", new { MealId = id });
        return meal;
    }

    public async Task<IEnumerable<Meal>> ListMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Meal>("SELECT * FROM meal");
        return meals;
    }

}


