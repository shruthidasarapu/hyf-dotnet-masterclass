using Microsoft.AspNetCore.Mvc;
using MealSharingNET.Models;
using MealSharingNET.Services;

namespace MealSharingNET.Controllers;
[ApiController]
[Route("reservations")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public List<Reservation> ListAllReservations()
    {

        return _repo.ListReservations().ToList();
    }

    [HttpPost("Add")]
    public void AddReservation([FromBody] Reservation r)
    {
        _repo.Add(r);
    }

    [HttpDelete("Delete")]
    public void DeleteReservation(int ID)
    {
        _repo.Delete(ID);
    }

}