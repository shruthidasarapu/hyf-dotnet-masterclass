namespace MealSharingApp.Models;
public class Reservation
{
    public int ID { get; set; }
    public int MealID { get; set; }

    public DateTime Date { get; set; }
    public int NumberOfPersons { get; set; }
    public int PhoneNumber { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

}