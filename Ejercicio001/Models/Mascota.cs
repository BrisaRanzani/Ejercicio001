using System.ComponentModel.DataAnnotations;

namespace Ejercicio001.Models
{
    public class Mascota
    {
        public Mascota()
        {
                
        }
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Range(0, 20, ErrorMessage = "La edad debe estar entre 0 y 20.")]
        public int Edad { get; set; }
        public string NombreDuenio { get; set; }
        public int EspecieId { get; set; }

        public Especie? especie { get; set; }
    }
}
