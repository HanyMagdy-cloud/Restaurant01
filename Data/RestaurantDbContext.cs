using Microsoft.EntityFrameworkCore;
using Restaurant01.Models;
using Restaurant01.Models;
using System.Collections.Generic;

namespace Restaurant.Data;

public class RestaurantDbContext : DbContext
{
    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) { }

    public DbSet<MenuItem> MenuItems => Set<MenuItem>();
    public DbSet<Reservation> Reservations => Set<Reservation>();
}
