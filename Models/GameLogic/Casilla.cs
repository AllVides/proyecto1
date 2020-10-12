using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto1.Models.GameLogic
{
    public class Casilla
    {
        
        public Casilla(string identificacion , int columna , int fila ,int estado)
        {
            this.identificacion = identificacion;
            this.columna = this.letra(columna);
            this.fila = fila;
            this.estado = estado;
        }

        public string letra(int i)
        {
            return (i == 1) ? "A" :
                (i == 2) ? "B" :
                (i == 3) ? "C" :
                (i == 4) ? "D" :
                (i == 5) ? "E" :
                (i == 6) ? "F" :
                (i == 7) ? "G" :
                (i == 8) ? "H" : null;
        }
        public string identificacion { get; set; }
        public string columna { get; set; }
        public int fila { get; set; }
        public int estado { get; set; }
    }
}
