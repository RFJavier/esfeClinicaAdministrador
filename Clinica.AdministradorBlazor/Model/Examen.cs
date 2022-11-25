using System.ComponentModel.DataAnnotations;

namespace Clinica.AdministradorBlazor.Model
{
    public class Examenes
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Examen es Obligatorio")]
        [StringLength(1500, ErrorMessage = "Maximo de 1500 Caracteres")]
        public string Examen { get; set; }

    }
}
