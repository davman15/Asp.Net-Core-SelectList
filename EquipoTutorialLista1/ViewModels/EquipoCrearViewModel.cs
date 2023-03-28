using EquipoTutorialLista1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EquipoTutorialLista1.ViewModels
{
    public class EquipoCrearViewModel
    {
        public Equipo Equipo { get; set; }
        public Entrenador Entrenador { get; set; }
        public SelectList ListaEntrenadores { get; set; }
    }
}
