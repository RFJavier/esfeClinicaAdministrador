using System.ComponentModel.DataAnnotations;

namespace Clinica.AdministradorBlazor.Model
{
    public class Anexos
    {
        [Key]
        public int Id { get; set; }

        [StringLength(1500, ErrorMessage = "Maximo de 1500 Caracteres")]
        public string Anexo { get; set; }

    }

}