using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto1.Models.GameLogic
{
    public class LogicaTorneo
    {
        public Tablero encuentro = new Tablero(false);

        public string nombreTorneo { get; set; } = "Torneo";
        public string[] dieciseis { get; set; } = new string[16];
        public string[] ocho { get; set; } = new string[8];
        public string[] cuatro { get; set; } = new string[4];
        public string[] dos { get; set; } = new string[2];
        public string ganador { get; set; } = "campeon";
        public int tamaño { get; set; } = 16;

        public LogicaTorneo()
        {
            initPosiciones();
        }
        public LogicaTorneo(string[] valores)
        {
            initPosiciones();
            participantes(valores);
        }

        public void initPosiciones()
        {
            for (int i = 0; i < 16; i++)
            {
                dieciseis[i] = i.ToString();
            }
            for (int i = 0; i < 8; i++)
            {
                ocho[i] = (i * 2).ToString();
            }
            for (int i = 0; i < 4; i++)
            {
                cuatro[i] = (i * 4).ToString();
            }
            for (int i = 0; i < 2; i++)
            {
                dos[i] = (i * 8).ToString();
            }
        }

        public void participantes(string[] valores)
        {
            string[] equipos = valores[0].Split(",");
            tamaño = equipos.Length - 1;
            for (int i = 0; i < tamaño; i++)
            {
                switch (tamaño)
                {
                    case 4:
                        cuatro[i] = equipos[i];
                        break;
                    case 8:
                        ocho[i] = equipos[i];
                        break;
                    case 16:
                        dieciseis[i] = equipos[i];
                        break;
                    default: break;
                }
            }
            nombreTorneo = valores[1];
        }

        public void resultados4()
        {
            dos[0] = cuatro[0];
            dos[1] = cuatro[2];
            ganador = dos[1];
        }

        public void resultados8()
        {
            for(int i= 0; i<4; i++)
            {
                cuatro[i] = ocho[i * 2];
            }
        }

        public void resultados16()
        {
            for (int i = 0; i < 8; i++)
            {
                ocho[i] = dieciseis[i * 2];
            }
        }


        public void quienGana()
        {
            switch (tamaño)
            {
                case 4:
                    resultados4();
                    break;
                case 8:
                    resultados8();
                    resultados4();

                    break;
                case 16:
                    resultados16();
                    resultados8();
                    resultados4();
                    break;
                default: break;
            }
        }



    }
}
