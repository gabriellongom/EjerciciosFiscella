using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego(6);

            while (juego.FinJuego() == false)
            {
                juego.ronda();
                for(int i = 0; i < juego.Jugadores.Length; i++)
                {
                    if (juego.Jugadores[i].Vivo == true)
                    {
                        Console.WriteLine("El jugador "+juego.Jugadores[i].Id+" sigue vivo");
                    }
                    else
                    {
                        Console.WriteLine("El jugador " + juego.Jugadores[i].Id + " esta muerto");
                    }
                }
            }

            if(juego.FinJuego() == true)
            {
                Console.WriteLine("Se termino el juego");
            }

            Console.ReadKey();
        }
    }
}
