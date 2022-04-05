namespace MealSharingApp.Models;
public class Meal
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime When { get; set; }
    public string Location { get; set; }
    public int MaxReservations { get; set; }
    public DateTime CreatedDate { get; set; }

}