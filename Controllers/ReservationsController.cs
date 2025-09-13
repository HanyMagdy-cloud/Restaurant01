using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant01.Models;

namespace Restaurant01.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly RestaurantDbContext _db;
        public ReservationsController(RestaurantDbContext db) => _db = db;

        // GET: /Reservations/Create  (Book a table)
        public IActionResult Create() => View();

        // POST: /Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            // no validation — keep it simple
            _db.Reservations.Add(reservation);
            await _db.SaveChangesAsync();
            // simple thank-you page
            return RedirectToAction(nameof(Thanks), new { id = reservation.Id });
        }

        // GET: /Reservations/Thanks/5
        public async Task<IActionResult> Thanks(int id)
        {
            var r = await _db.Reservations.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (r == null) return NotFound();
            return View(r);
        }
    }
}
