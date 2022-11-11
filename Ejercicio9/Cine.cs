using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Cine
    {
        private Pelicula pelicula;
        private double precio;
        private Asiento[][] asientos;

        public Cine(int filas, int columnas, double precio, Pelicula pelicula)
        {
            asientos = new Asiento[filas][];
            for (int c = 0; c < filas; c++)
            {
                asientos[c] = new Asiento[columnas];
            }
            this.precio = precio;
            this.pelicula = pelicula;
            Butacas();
        }

        public Pelicula Pelicula
        {
            get
            {
                return pelicula;
            }
            set
            {
                pelicula = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }

        public Asiento[][] Asientos
        {
            get
            {
                return asientos;
            }
            set
            {
                asientos = value;
            }
        }

        public int Filas
        {
            get
            {
                return asientos.Length;
            }
        }

        public int Columnas
        {
            get
            {
                return asientos[0].Length;
            }
        }

        public Asiento GetAsientoEspecifico(int fila, char letra)
        {
            return asientos[fila][letra - 'A'];
        }

        public void Butacas()
        {
            int fila = asientos.Length;
            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[0].Length; j++)
                {
                    asientos[i][j] = new Asiento((char)('A' + j), fila);
                }
                fila--;
            }
        }

        public bool haySitio()
        {
            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[0].Length; j++)
                {
                    if (!asientos[i][j].AsientoOcupado())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool haySitioButaca(int fila, char letra)
        {
            if (GetAsientoEspecifico(fila, letra).AsientoOcupado() == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool SePuedeSentar(Espectador e)
        {
            if (e.EdadSuficiente(pelicula.EdadMinima) == true && e.DineroSuficiente(precio) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Sentar(int fila, char letra, Espectador e)
        {
            GetAsientoEspecifico(fila, letra).Espectador = e;
        }
    }
}