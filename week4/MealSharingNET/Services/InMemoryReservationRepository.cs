namespace MealSharingNET.Services;
using MealSharingNET.Models;
public class InMemoryReservationRepository : IReservationRepository
{

    private List<Reservation> Reservations { get; set; } = new List<Reservation>(){
        new Reservation(){ ID=0, Name="", Email="",NumberOfPersons=2,MealID=1},
        new Reservation(){ID=1, Name="", Email="",NumberOfPersons=2,MealID=2},
        new Reservation(){ID=2, Name="", Email="",NumberOfPersons=2,MealID=3}
    };

    public IEnumerable<Reservation> ListReservations()
    {
        return Reservations;
    }

    public void Add(Reservation r)
    {
        Reservations.Add(r);
    }

    public void Delete(int ID)
    {
        Reservations.RemoveAll(r => r.ID == ID);
    }
}
