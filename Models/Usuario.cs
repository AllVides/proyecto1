using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto1.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        
        [Display(Name ="Nombres")]
        [Required(ErrorMessage = "Required")]
        public string nombre { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Required")]
        public string apellido { get; set; }

        [Display(Name = "Nombre Usuario")]
        [Required(ErrorMessage = "Required")]
        public string username { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        public DateTime nac { get; set; }

        [Display(Name = "Contraseña")]
        [StringLength(8, ErrorMessage = "Longitud entre 2 y 8 caracteres.",
                      MinimumLength = 2)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required")]
        public string contraseña { get; set; }

        [Display(Name = "Correo Electronico")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [Required(ErrorMessage = "Required")]
        public string email { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "Required")]
        public string pais { get; set; }

        public List<Partida> Partidas { get; set; }
    }
}
