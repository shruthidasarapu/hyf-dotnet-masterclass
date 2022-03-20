using Microsoft.AspNetCore.Mvc;
using MealSharingNET.Models;
using MealSharingNET.Services;

namespace MealSharingNET.Controllers;
[ApiController]
[Route("meals")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public List<Meal> ListAllMeals()
    {

        return _repo.ListMeals().ToList();
    }

    [HttpPost("Add")]
    public void AddMeal([FromBody] Meal m)
    {
        _repo.Add(m);
    }

    [HttpDelete("Delete")]
    public void DeleteMeal(int ID)
    {
        _repo.Delete(ID);
    }

}