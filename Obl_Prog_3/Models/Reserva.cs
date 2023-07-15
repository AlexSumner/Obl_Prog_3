using System.ComponentModel.DataAnnotations.Schema;

namespace Obl_Prog_3.Models
{
    public class Reserva
    {
        public int Id { get; set; }


        [ForeignKey("Funciones")]
        public Funcion? Funcion { get; set; }

        [ForeignKey("Personas")]
        public Usuario? Usuario { get; set; }

        public int Asientos { get; set; }

        public int Precio { get; set; } 


    }
}
