using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BackendAjsAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Debe indicar el email")]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe indicar la contraseña")]
        [StringLength(50)]
        public string Password { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debe declarar el sexo")]
        [StringLength(1)]
        public string Sexo { get; set; }

        [StringLength(150)]
        public string? Direccion { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio")]
        [StringLength(3)]
        public string Tipo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
    }
}
