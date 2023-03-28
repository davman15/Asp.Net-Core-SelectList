using EquipoTutorialLista1.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipoTutorialLista1.Context
{
    public class EquipoDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public EquipoDbContext(DbContextOptions<EquipoDbContext> options) : base(options)
        {

        }
    }
}
