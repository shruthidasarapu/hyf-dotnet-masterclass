namespace MealSharingApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using MealSharingApp.Models;
using MySql.Data.MySqlClient;
public class ReservationRepository : IReservationRepository
{


    public async Task AddReservation(Reservation reserve)
    {

        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reserveId = await connection.ExecuteAsync("INSERT INTO Reservation (ID, number_of_guests,meal_id,created_date,contact_phonenumber,contact_name,contact_email) VALUES (@ID, @NumberOfPersons,@MealID, @Date,@PhoneNumber, @Name, @Email )", reserve);
    }
    public async Task DeleteReservation(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("DELETE FROM Reservation WHERE id=@ID", new { ID = id });
    }
    public async Task<Reservation> FindReservationById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservation = await connection.QueryFirstAsync<Reservation>("SELECT * FROM Reservation WHERE ID=@ReserveId", new { ReserveId = id });
        return reservation;
    }

    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.QueryAsync<Reservation>("SELECT * FROM Reservation");
        return reservations;
    }

}