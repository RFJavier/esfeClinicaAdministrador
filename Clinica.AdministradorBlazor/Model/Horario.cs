using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Clinica.AdministradorBlazor.Model
{
    public class Horario
    {
        [Key]
        public int Id { get; set; }

        public int IdMedico { get; set; }

        [Required(ErrorMessage = "Entrada es Obligatorio")]
        public DateTime Entrada { get; set; }

        [Required(ErrorMessage = "Salida es Obligatorio")]
        public DateTime Salida { get; set; }

        public Medico Medico { get; set; }
    }
}
