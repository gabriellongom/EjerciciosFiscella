using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Porra porra = new Porra();
            porra.jornadas();

            for (int i = 0; i < Porra.numeroJornadas; i++)
            {
                Console.WriteLine("\nJornada " + (i + 1));
                Console.WriteLine("\nJugadores:\n");
                for (int j = 0; j < Jugador.jugadores.Length; j++)
                {
                    Console.WriteLine("\n"+Jugador.jugadores[j].Nombre);
                    Console.WriteLine(Jugador.jugadores[j].Dinero + "\n");
                    for (int k = 0; k < Jugador.jugadores[j].Resultado.Length; k++)
                    {
                        Console.WriteLine(Jugador.jugadores[j].Resultado[k]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
