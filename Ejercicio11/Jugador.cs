using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Jugador
    {
        public static Jugador[] jugadores = { new Jugador("Jose"), new Jugador("Pepe"), new Jugador("Pablo"), new Jugador("Hernan"), new Jugador("Juan"), new Jugador("Ignacio"), new Jugador("Ezequiel"), new Jugador("Martin"), new Jugador("Fernando"), new Jugador("Alberto"), new Jugador("Cesar"), new Jugador("Gabriel"), new Jugador("Maximo"), new Jugador("Agustin"), new Jugador("Roberto"), new Jugador("Josefina"), new Jugador("Penelope"), new Jugador("Maria"), new Jugador("Martina"), new Jugador("Aylen"), };

        static Random r = new Random();


        string nombre;
        double dinero;
        int porrasGanadas;
        string[] resultados;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.dinero = 40;
            this.porrasGanadas = 0;
            this.resultados = new string[Partido.partidosJugados];
            ReiniciarResultados();
        }

        public void ReiniciarResultados()
        {

            for (int i = 0; i < resultados.Length; i++)
            {
                resultados[i] = "";
            }

        }

        public bool PuedePagar()
        {
            return dinero >= Porra.costoJornada;
        }

        public void PonerEnElBote()
        {
            dinero -= Porra.costoJornada;
        }

        public void GanarBote(double bote)
        {
            dinero += bote;
            porrasGanadas++;
        }

        public void GenerarResultados()
        {

            int Local; 
            int Visitante;

            for (int i = 0; i < resultados.Length; i++)
            {
                Local = r.Next(Partido.resMin, Partido.resMax);
                Visitante = r.Next(Partido.resMin, Partido.resMax);

                resultados[i] = Local + " - " + Visitante;

            }
        }

        public bool AcertadoPorra(string[] resultados_partidos)
        {

            for (int i = 0; i < resultados.Length; i++)
            {
                if (resultados[i] != resultados_partidos[i])
                {
                    return false;
                }
            }
            return true;

        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public double Dinero
        {
            get
            {
                return dinero;
            }
        }

        public string[] Resultado
        {
            get
            {
                return resultados;
            }
        }
    }
}
