using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto1.Models
{
    public class Participante
    {
        public string posicion { get; set; }

        [Key]
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [Key]
        public int IdTorneo { get; set; }
        public Torneo Torneo { get; set; }
    }
}
