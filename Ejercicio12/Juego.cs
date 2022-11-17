using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Juego
    {
        static Random r = new Random();

        Jugador[] jugadores;
        Revolver revolver = new Revolver();

        public Juego(int cantJugadores)
        {
            if (cantJugadores < 7 && cantJugadores > 0)
            {
                jugadores = new Jugador[cantJugadores];
            }
            else
            {
                jugadores = new Jugador[6];
            }
            for (int i = 0; i < jugadores.Length; i++)
            {
                jugadores[i] = new Jugador(i);
            }
        }

        public bool FinJuego()
        {
            for (int i = 0; i < jugadores.Length; i++)
            {
                if (!jugadores[i].Vivo)
                {
                    return true;
                }
            }
            return false;
        }

        public void ronda()
        {

            for (int i = 0; i < jugadores.Length; i++)
            {

                jugadores[i].Disparar(revolver);
            }

        }

        public Jugador[] Jugadores
        {
            get
            {
                return jugadores;
            }
        }
    }
}
