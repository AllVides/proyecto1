using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto1.Models.GameLogic
{
    public class LogicaTorneo
    {
        public Tablero encuentro = new Tablero(false);

        public string[] dieciseis = new string[16];
        public string[] ocho = new string[8];
        public string[] cuatro = new string[4];
        public string[] dos = new string[2];
        public string ganador;

        public void initPosiciones()
        {
            for(int i = 0; i<16; i++)
            {
                dieciseis[i] = "equipo";
            }
            for (int i = 0; i < 8; i++)
            {
                ocho[i] = "equipo";
            }
            for (int i = 0; i < 4; i++)
            {
                cuatro[i] = "equipo";
            }
        }

        public void quienGana(bool ganador)
        {
            if (ganador)
            {

            }
        }

    }
}
