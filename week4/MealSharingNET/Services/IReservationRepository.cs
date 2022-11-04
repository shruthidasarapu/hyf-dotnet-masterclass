namespace MealSharingNET.Services;
using MealSharingNET.Models;
public interface IReservationRepository

{
    IEnumerable<Reservation> ListReservations();

    void Add(Reservation r);

    void Delete(int ID);
}