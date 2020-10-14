using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto1.Models
{
    public class Torneo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTorneo { get; set; }

        [Display(Name = "Nombre Torneo")]
        [Required(ErrorMessage = "Required")]
        public string nombre { get; set; }

        [Display(Name = "Tamaño Torneo")]
        [Required(ErrorMessage = "Required")]
        public int tamaño { get; set; }

        public List<Participante> Participantes { get; set; }
    }
}
