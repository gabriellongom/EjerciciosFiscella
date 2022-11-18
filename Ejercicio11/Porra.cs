using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Porra
    {
        public static int costoJornada = 1;
        public static int numeroJornadas = 40;

        double bote;

        public Porra()
        {
            bote = 0;
        }

        public void AumentarBote(double dinero)
        {
            bote += dinero;
        }

        public void VacirBote()
        {
            bote = 0;
        }

        public void jornadas()
        {

            Partido resPartido = new Partido();
            string[] partidos;

            for (int i = 0; i < numeroJornadas; i++)
            {
                for (int j = 0; j < Jugador.jugadores.Length; j++)
                {
                    if (Jugador.jugadores[j].PuedePagar())
                    {
                        Jugador.jugadores[j].PonerEnElBote();
                        Jugador.jugadores[j].GenerarResultados();
                        AumentarBote(costoJornada);
                    }
                    else
                    {
                        Jugador.jugadores[j].ReiniciarResultados();
                    }

                }

                resPartido.generarResultados();
                partidos = resPartido.Partidos;

                for (int j = 0; j < Jugador.jugadores.Length; j++)
                {
                    if (Jugador.jugadores[j].AcertadoPorra(partidos))
                    {
                        Jugador.jugadores[j].GanarBote(bote);
                        VacirBote();
                    }
                }
            }
        }
    }
}

