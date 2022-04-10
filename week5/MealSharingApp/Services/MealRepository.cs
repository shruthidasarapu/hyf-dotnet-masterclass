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
        var mealId = await connection.ExecuteAsync("INSERT INTO Meal (ID, Title,image_url, Description, Price, `When`, Location, max_reservations, created_date) VALUES (@ID, @Title,@ImageUrl, @Description, @Price, @When, @Location,@MaxReservations, @CreatedDate)", meal);
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


    public async Task<IEnumerable<MealReservation>> ListMealReservations(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var mealreservations = await connection.QueryAsync<MealReservation>("SELECT meal.ID, Title,Name, NumberOfPersons FROM meal inner join reservation where meal.ID = @MealId", new { MealId = id });
        return mealreservations;
    }
    // public async Task<IEnumerable<Meal>> ListMeals(MealSearch mealSearch)
    // {
    //     var query = "select * from meal";

    //     if (!string.IsNullOrWhiteSpace(mealSearch?.Title))
    //     {
    //         query += " where title like @title";
    //     }
    //     await using var connection = new MySqlConnection(Shared.ConnectionString);
    //     var meals = await connection.QueryAsync<Meal>(query, new { Title = "%" + mealSearch.Title + "%" });

    //     return meals;
    // }
    public async Task<IEnumerable<Meal>> ListMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        Console.Write(connection);
        var meals = await connection.QueryAsync<Meal>("SELECT * FROM meal");
        return meals;
    }
}


