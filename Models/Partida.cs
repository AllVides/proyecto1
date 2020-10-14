using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto1.Models
{
    public class Partida
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPartida { get; set; }
        
        [Display(Name = "Numero de Turnos Jugados")]
        [Required(ErrorMessage = "Required")]
        public int numTurnos { get; set; }
        [Display(Name = "Resultado Partida")]
        [Required(ErrorMessage = "Required")]
        public string resultado { get; set; }

        [Display(Name = "Tipo de Juego")]
        [Required(ErrorMessage = "Required")]
        public string adversario { get; set; }
        
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }


    }
}
