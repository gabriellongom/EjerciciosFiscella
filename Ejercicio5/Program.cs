using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public interface Entregado
    {
        void Entregar();
        void Devolver();
        bool IsEntregado();
        Entregado CompareTo(Entregado e);
    }

    public class Serie : Entregado
    {
        private string titulo;
        private int numTemporadas = 3;
        private bool entregado = false;
        private string genero;
        private string creador;

        public Serie()
        {

        }
        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }
        public Serie(string titulo, int numTemporadas, string genero, string creador)
        {
            this.titulo=titulo;
            this.numTemporadas = numTemporadas;
            this.genero = genero;
            this.creador = creador;
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
        public int NumTemporadas
        {
            get
            {
                return numTemporadas;
            }
            set
            {
                numTemporadas = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public string Creador
        {
            get
            {
                return creador;
            }
            set
            {   
                creador = value;
            }
        }
        public void Entregar()
        {
            entregado = true;
        }
        public void Devolver()
        {
            entregado = false;
        }
        public bool IsEntregado()
        {
            return entregado;
        }
        public Entregado CompareTo(Entregado e)
        {
            Serie S = (Serie)e;
            if (NumTemporadas <= S.NumTemporadas)
            {
                return S;
            }
            else
            {
                return this;
            }
        }
    }
    public class Videojuego : Entregado
    {
        private string titulo;
        private int horasEstimadas = 10;
        private bool entregado = false;
        private string genero;
        private string compañia;

        public Videojuego()
        {

        }
        public Videojuego(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
        }
        public Videojuego(string titulo, int horasEstimadas, string genero, string compañia)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            this.genero = genero;
            this.compañia = compañia;
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
        public int HorasEstimadas
        {
            get
            {
                return horasEstimadas;
            }
            set 
            { 
                horasEstimadas = value; 
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public string Compañia
        {
            get
            {
                return compañia;
            }
            set
            {
                compañia = value;
            }
        }

        public void Entregar()
        {
            entregado = true;
        }
        public void Devolver()
        {
            entregado = false;
        }
        public bool IsEntregado()
        {
            return entregado;
        }
        public Entregado CompareTo(Entregado e)
        { 
            Videojuego V = (Videojuego)e;
            if (HorasEstimadas < V.HorasEstimadas)
            {
                return V;
            }
            else
            {
                return this;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int CantSeriesEnt = 0;
            int CantJuegosEnt = 0;

            Serie serie1 = new Serie("Supernatural", 15,"Accion","Eric Kripke");
            Serie serie2 = new Serie("X-Files", 11, "Ficion", "Cris Carter");
            Serie serie3 = new Serie("First Wave", 3, "Ficion", "Cris Brancato");
            Serie serie4 = new Serie("Star Trek", 37, "Ficion", "Gene Roddenberry");
            Serie serie5 = new Serie("Millenium", 3, "Ficion", "Cris Carter");
            Serie[] arrayseries = { serie1, serie2, serie3, serie4, serie5 };

            Videojuego juego1 = new Videojuego("The Curse", 20, "Terror", "TMG");
            Videojuego juego2 = new Videojuego("Chrono Trigger", 15, "RPG", "Square Enix");
            Videojuego juego3 = new Videojuego("Forager", 10, "Sandbox", "");
            Videojuego juego4 = new Videojuego("Cave Story", 8, "Metroidvania", "Nicalis");
            Videojuego juego5 = new Videojuego("The Binding of Issac Repeteance", 250, "Rougelike", "Nicalis");
            Videojuego[] arrayjuegos = { juego1, juego2, juego3, juego4, juego5 };

            serie2.Entregar();
            serie4.Entregar();
            juego2.Entregar();
            juego4.Entregar();
            juego5.Entregar();

            for(int i = 0; i < arrayseries.Length; i++)
            {
                if(arrayseries[i].IsEntregado() == true)
                {
                    CantSeriesEnt += 1;
                    arrayseries[i].Devolver();
                }
            }

            Console.WriteLine("Hay " + CantSeriesEnt + " Series entregadas");

            for(int i = 0; i < arrayjuegos.Length; i++)
            {
                if (arrayjuegos[i].IsEntregado() == true)
                {
                    CantJuegosEnt += 1;
                    arrayjuegos[i].Devolver();
                }
            }

            Console.WriteLine("Hay " + CantJuegosEnt + " Juegos entregados");

            Serie serieMayor = arrayseries[0];
            Videojuego juegoMayor = arrayjuegos[0];

            for (int i = 1; i < arrayseries.Length; i++)
            {
                serieMayor = (Serie)arrayseries[i].CompareTo(serieMayor);
            }

            Console.WriteLine("La serie con mas temporadas es "+ serieMayor.Titulo);

            for (int i = 1; i < arrayjuegos.Length; i++)
            {
                juegoMayor = (Videojuego)arrayjuegos[i].CompareTo(juegoMayor);
            }

            Console.WriteLine("El juego con mas horas estimadas es " + juegoMayor.Titulo);

            Console.ReadKey();
        }
    }
}
