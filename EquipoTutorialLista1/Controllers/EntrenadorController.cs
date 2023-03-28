using EquipoTutorialLista1.Context;
using EquipoTutorialLista1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EquipoTutorialLista1.Controllers
{
    public class EntrenadorController : Controller
    {
        private readonly EquipoDbContext _context;

        public EntrenadorController(EquipoDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return _context.Entrenadores != null ?
                        View(await _context.Entrenadores.ToListAsync()) :
                        Problem("Entity set 'EquipoDbContext.Entrenadores'  is null.");
        }

        public IActionResult Crear()
        {
            return View();
        }

        // POST: Entrenadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Crear(Entrenador entrenador)
        {
            _context.Add(entrenador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
