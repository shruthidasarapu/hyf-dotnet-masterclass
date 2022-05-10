using Microsoft.AspNetCore.Mvc;
using MealSharingApp.Models;
using MealSharingApp.Services;

namespace MealSharingApp.Controllers;
[ApiController]
[Route("api/meals")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("")]
    // public async Task<IEnumerable<Meal>> ListAllMeals([FromQuery] MealSearch mealSearch)
    // {

    //     return await _repo.ListMeals(mealSearch);
    // }
    public async Task<IEnumerable<Meal>> ListAllMeals()
    {

        return await _repo.ListMeals();
    }
    [HttpGet("{id}")]
    public async Task<Meal> GetMeal(int id)
    {
        var meal = await _repo.FindMealById(id);
        return meal;
    }
    [HttpPost("")]
    public async Task AddMeal([FromBody] Meal m)
    {
        await _repo.AddMeal(m);
    }

    [HttpDelete("")]
    public async Task DeleteMeal(int id)
    {
        await _repo.DeleteMeal(id);
    }
    [HttpGet("reservation/{id}")]
    public async Task<IEnumerable<MealReservation>> ListMealReservations(int id)
    {

        return await _repo.ListMealReservations(id);
    }
}