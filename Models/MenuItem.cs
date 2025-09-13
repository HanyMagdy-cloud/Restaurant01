namespace Restaurant01.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }   // e.g., "Pasta", "Burger"
    public decimal Price { get; set; }
    public string? ImageFileName { get; set; }
}
