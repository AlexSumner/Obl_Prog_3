using System.ComponentModel.DataAnnotations.Schema;

namespace Obl_Prog_3.Models
{
    public class Funcion
    {
        public int Id { get; set; }

        [ForeignKey("Peliculas")]
        public Pelicula? Pelicula { get; set; }

        [ForeignKey("Salas")]
        public Sala? Sala { get; set; }

        public string? Fecha { get; set; }
        public string? Horario { get; set; }    


    }
}
