using EquipoTutorialLista1.Context;
using EquipoTutorialLista1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EquipoTutorialLista1.Controllers
{
    public class EquipoController : Controller
    {
        private readonly EquipoDbContext _db;
        public EquipoController(EquipoDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var equipos = await _db.Equipos.Include(d => d.Entrenador).ToListAsync();
            return View(equipos);
        }
        public async Task<IActionResult> Crear()
        {
            var vm = new EquipoCrearViewModel();

            var entrenadoresSelectLista = await _db.Entrenadores.Select(e => new
            {
                Id = e.EntrenadorId,
                Valor = e.EntrenadorNombre
            }).ToListAsync();

            vm.ListaEntrenadores = new SelectList(entrenadoresSelectLista, "Id", "Valor");

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(EquipoCrearViewModel vm)
        {
            var entrenador = await _db.Entrenadores.SingleOrDefaultAsync(c => c.EntrenadorId == vm.Entrenador.EntrenadorId);
            vm.Equipo.Entrenador = entrenador;
            _db.Add(vm.Equipo);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
