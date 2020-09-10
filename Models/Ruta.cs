using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto1.Models
{
    public class Ruta
    {
        [Key]
        public int IdPartida { get; set; }

        public string ruta { get; set; }
    }
}
