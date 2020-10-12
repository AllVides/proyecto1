using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto1.Models.GameLogic
{
    public class Tablero
    {
        public Casilla[,] cuadricula { get; set; }
        public string colorTurno { get; set; }
        public int numeroTurno { get; set; }
        public int[] numeroPiezas { get; set; } = new int[2];
       
        
        public Tablero()
        {
            this.cuadricula = this.nuevoJuego();
            colorTurno = "negro";
            numeroTurno = 1;
        }
        public Tablero(string xml, string turno)
        {
            this.cuadricula = this.nuevoJuego();
            this.PreCarga(xml);
            colorTurno = turno; //ver como soluciono esto del turno
            numeroTurno = 1;

        }

        public void contador()
        {
            if (colorTurno == "blanco")
            {
                numeroTurno++;
                colorTurno = "negro";
            }
            else if(colorTurno == "negro"){ colorTurno = "blanco"; }
        }

        public void LimpiezaTablero()
        {
            for(int i = 1; i<9; i++)
            {
                for(int j = 1; j<9; j++)
                {
                    if(cuadricula[i,j].estado == 3)
                    {
                        cuadricula[i, j].estado = 0;
                    }
                }
            }
        }

        public void PiezasEnJuego()
        {
            numeroPiezas[0] = 0;
            numeroPiezas[1] = 0;
            for(int i = 1; i<9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (cuadricula[i, j].estado == 1)
                    {
                        numeroPiezas[0]++;
                        
                    }else if(cuadricula[i,j].estado == 2)
                    {
                        numeroPiezas[1]++;
                    }
                }
            }
        }

        public bool FinJuego()
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (cuadricula[i, j].estado == 3)
                    {
                        return false;
                    }
                    
                }
            }
            return true;
        }

        public void MovimientosPosibles()
        {
            string color = colorTurno;
            int turno = (color == "blanco") ? 1 : 2;
            int contra = (color == "blanco") ? 2 : 1;
            bool inicio = false;
            bool continuacion = false;
            
            //horizontal-derecha
            for(int i = 1; i < 9; i++)
            {
                for(int j = 1; j < 9; j++)
                {
                    if (turno == cuadricula[i,j].estado)
                    {
                        inicio = true;
                    }
                    if (inicio && cuadricula[i,j].estado == contra)
                    {
                        continuacion = true;
                    }
                    if(inicio && continuacion && cuadricula[i,j].estado == turno)
                    {
                        continuacion = false;
                    }
                    if(inicio && continuacion && cuadricula[i,j].estado == 0)
                    {
                        cuadricula[i, j].estado = 3;
                        break;
                    }
                }
                inicio = continuacion = false;
            }
            //horizontal-izquierda
            for (int i = 1; i < 9; i++)
            {
                for (int j = 8; j > 0; j--)
                {
                    if (turno == cuadricula[i, j].estado)
                    {
                        inicio = true;
                    }
                    if (inicio && cuadricula[i, j].estado == contra)
                    {
                        continuacion = true;
                    }
                    if (inicio && continuacion && cuadricula[i, j].estado == turno)
                    {
                        continuacion = false;
                    }
                    if (inicio && continuacion && cuadricula[i, j].estado == 0)
                    {
                        cuadricula[i, j].estado = 3;
                        break;
                    }
                }
                inicio = continuacion = false;
            }
            //vertical-abajo
            for (int j = 1; j < 9; j++)
            {
                for (int i = 1; i < 9; i++)
                {
                    if (turno == cuadricula[i, j].estado)
                    {
                        inicio = true;
                    }
                    if (inicio && cuadricula[i, j].estado == contra)
                    {
                        continuacion = true;
                    }
                    if (inicio && continuacion && cuadricula[i, j].estado == turno)
                    {
                        continuacion = false;
                    }
                    if (inicio && continuacion && cuadricula[i, j].estado == 0)
                    {
                        cuadricula[i, j].estado = 3;
                        break;
                    }
                }
                inicio = continuacion = false;
            }
            //vertical-arriba
            for (int j = 1; j < 9; j++)
            {
                for (int i = 8; i > 0; i--)
                {
                    if (turno == cuadricula[i, j].estado)
                    {
                        inicio = true;
                    }
                    if (inicio && cuadricula[i, j].estado == contra)
                    {
                        continuacion = true;
                    }
                    if (inicio && continuacion && cuadricula[i, j].estado == turno)
                    {
                        continuacion = false;
                    }
                    if (inicio && continuacion && cuadricula[i, j].estado == 0)
                    {
                        cuadricula[i, j].estado = 3;
                        break;
                    }
                }
                inicio = continuacion = false;
            }
        }

       
        public void AccionMovimiento(int fila, int columna)
        {
            List<int[]> fichas = new List<int[]>();
            List<int[]> preview = new List<int[]>();
            int[] coordenadas = new int[2];
            int efecto = (colorTurno == "blanco") ? 1 : 2;
            int afectado = (colorTurno == "blanco") ? 2 : 1;
            fichas.Add(new int[] { fila, columna });

            //derecha
            for(int j = columna+1; j<9; j++)
            {
                
                if (afectado == cuadricula[fila, j].estado)
                {
                    
                    preview.Add(new int[] { fila,j});
                    
                }else if (cuadricula[fila, j].estado == efecto)
                {
                    fichas.AddRange(preview);
                    break;
                }else if (cuadricula[fila, j].estado == 0)
                {
                    preview.Clear();
                    break;
                }
            }
            preview.Clear();
            //izquierda
            for (int j = columna-1; j > 0; j--)
            {
                if (afectado == cuadricula[fila, j].estado)
                {
                    preview.Add(new int[] { fila, j });
                }
                else
                if (cuadricula[fila, j].estado == efecto)
                {
                    fichas.AddRange(preview);
                    break;
                }
                else
                if (cuadricula[fila, j].estado == 0)
                {
                    preview.Clear();
                    break;
                }
            }
            preview.Clear();
            //arriba
            for (int i = fila-1; i > 0; i--)
            {
                if (afectado == cuadricula[i, columna].estado)
                {
                    preview.Add(new int[] { i, columna });
                }
                else
                if (cuadricula[i, columna].estado == efecto)
                {
                    fichas.AddRange(preview);
                    break;
                }
                else
                if (cuadricula[i, columna].estado == 0)
                {
                    preview.Clear();
                    break;
                }
            }
            preview.Clear();
            //abajo
            for (int i = fila+1; i < 9; i++)
            {
                if (afectado == cuadricula[i, columna].estado)
                {
                    preview.Add(new int[] { i, columna });
                }
                else
                if (cuadricula[i, columna].estado == efecto)
                {
                    fichas.AddRange(preview);
                    break;
                }
                else
                if (cuadricula[i, columna].estado == 0)
                {
                    preview.Clear();
                    break;
                }
            }
            preview.Clear();
            //arriba-derecha
            //arriba-izquierda
            //abajo-derecha
            //abajo-izuqierda
           
            
            //agregado de fichas
            foreach(int[] posicion in fichas)
            {
                cuadricula[posicion[0], posicion[1]].estado = efecto;
            }

        }
        
        public int[] Posicion(string nombre)
        {
            int[] posicion = new int[2];
            for(int i=0; i<9; i++)
            {
                for(int j = 0; j<9; j++)
                {
                    if(cuadricula[i,j].identificacion == nombre)
                    {
                        posicion[0] = i;
                        posicion[1] = j;
                        return posicion;
                    }
                }
            }
            return null;
        }
        public Casilla[,] nuevoJuego()
        {
            Casilla[,] cuadricula = new Casilla[9,9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == 4 && j == 4)
                    {
                        cuadricula[i,j] = new Casilla(i.ToString() + j.ToString(), j, i, 1);
                    }
                    else if (i == 5 && j == 5)
                    {
                        cuadricula[i,j] = new Casilla(i.ToString() + j.ToString(), j, i, 1);
                    }
                    else if (i == 4 && j == 5)
                    {
                        cuadricula[i,j] = new Casilla(i.ToString() + j.ToString(), j, i, 2);
                    }
                    else if (i == 5 && j == 4)
                    {
                        cuadricula[i,j] = new Casilla(i.ToString() + j.ToString(), j, i, 2);
                    }
                    else
                    {
                        cuadricula[i,j] = new Casilla(i.ToString() + j.ToString(), j, i, 0);
                    }
                    

                }
            }
            return cuadricula;
        }
        public void PreCarga(string posiciones)
        {
            string[] letras = posiciones.Split(";");
            string[] aux;
            foreach(string p in letras)
            {
                aux = p.Split(",");
                //color, letra, numero
                if (aux.Length < 3) { break; }
                int color = (aux[0] == "blanco")? 1:2;
                int col;
                switch (aux[1])
                {
                    case "A":
                        col = 1;
                        break;
                    case "B":
                        col = 2;
                        break;
                    case "C":
                        col = 3;
                        break;
                    case "D":
                        col = 4;
                        break;
                    case "E":
                        col = 5;
                        break;
                    case "F":
                        col = 6;
                        break;
                    case "G":
                        col = 7;
                        break;
                    case "H":
                        col = 8;
                        break;
                    default:
                        col = 0;
                        break;
                }
                int fila = int.Parse(aux[2]);
                string nombre = fila.ToString() + col.ToString();
                cuadricula[fila,col] = new Casilla(nombre, col, fila, color);
            }
            
        }
    }
}
