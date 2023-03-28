namespace EquipoTutorialLista1.Models
{
    public class Equipo
    {
        public int EquipoId { get; set; }
        public string EquipoNombre { get; set; }
        public virtual Entrenador Entrenador { get; set; }
    }
}
