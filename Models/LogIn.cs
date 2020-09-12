using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace proyecto1.Models
{
    public class LogIn
    {
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string User { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(8, ErrorMessage = "Longitud entre 2 y 8 caracteres.",
                      MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Recordarme")]
        public bool RememberMe { get; set; }
    }
}
