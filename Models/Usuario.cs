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
        [Required(ErrorMessage = "Required")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Required")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "Required")]
        public string username { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        public DateTime nac { get; set; }
        [Required(ErrorMessage = "Required")]
        public string contraseña { get; set; }
        [Required(ErrorMessage = "Required")]
        public string email { get; set; }
        [Required(ErrorMessage = "Required")]
        public string pais { get; set; }

        public List<Partida> Partidas { get; set; }
    }
}
