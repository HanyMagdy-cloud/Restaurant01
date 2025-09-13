namespace Restaurant01.Models;

public class Reservation
{
    public int Id { get; set; }
    public string? CustomerName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int PartySize { get; set; }
    public DateTime ReservationTime { get; set; }
    public string? SpecialRequests { get; set; }
}
