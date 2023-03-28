using System.ComponentModel.DataAnnotations;

namespace EquipoTutorialLista1.Models
{
    public class Entrenador
    {
        [Key]
        public int EntrenadorId { get; set; }
        public string EntrenadorNombre { get; set; }
    }
}
