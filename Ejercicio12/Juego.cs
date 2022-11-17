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
        Revolver revolver;

        public Juego(int cantJugadores)
        {
            for(int i = 0; i < cantJugadores;)
            {
                jugadores[i] = new Jugador();
            }
        }

        public bool FinJuego()
        {

        }

        public void ronda()
        {

        }
    }
}
