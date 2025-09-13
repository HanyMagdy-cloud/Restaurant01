using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;

namespace Restaurant01.Controllers;

public class MenuController : Controller
{
    private readonly RestaurantDbContext _db;
    public MenuController(RestaurantDbContext db) => _db = db;

    // GET: /Menu
    public async Task<IActionResult> Index()
    {
        var items = await _db.MenuItems.AsNoTracking().ToListAsync();
        return View(items);
    }
}
