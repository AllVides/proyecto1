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
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public List<Ruta> Rutas { get; set; }
    }
}
