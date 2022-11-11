using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Pelicula
    {
        private string titulo;
        private int duracion;
        private int edad_minima;
        private string director;

        public Pelicula(string titulo, int duracion, int edad_minima, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edad_minima = edad_minima;
            this.director = director;
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        public int Duracion
        {
            get
            {
                return duracion;
            }
            set
            {
                duracion = value;
            }
        }

        public int EdadMinima
        {
            get
            {
                return edad_minima;
            }
            set
            {
                edad_minima = value;
            }
        }

        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }
    }
}
