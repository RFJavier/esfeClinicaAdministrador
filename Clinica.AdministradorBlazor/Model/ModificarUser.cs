using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Clinica.AdministradorBlazor.Model
{
    public class ModificarUser
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Rol")]
        [Required(ErrorMessage = "Rol es obligatorio")]
        [Display(Name = "Rol")]
        public int IdRol { get; set; }

        [Required(ErrorMessage = "Nombre es obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido es obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Login es obligatorio")]
        [StringLength(25, ErrorMessage = "Maximo 25 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Estatus es obligatorio")]
        public byte Estatus { get; set; }


        [Display(Name = "Fecha registro")]
        public DateTime FechaRegistro { get; set; }

        public Roles Rol { get; set; }

    }
}
