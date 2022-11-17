using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();

            Console.WriteLine("\n Actualmente hay " + baraja.CartasDisponibles() + " cartas en el mazo \n");

            baraja.DarCartas(6);

            Console.WriteLine("\n Actualmente hay " + baraja.CartasDisponibles() + " cartas en el mazo \n");

            baraja.SiguienteCarta();
            baraja.SiguienteCarta();
            baraja.SiguienteCarta();
            baraja.SiguienteCarta();

            Console.WriteLine("\n Actualmente hay " + baraja.CartasDisponibles() + " cartas en el mazo \n");

            Console.WriteLine("\n Cartas en el mazo \n");

            foreach (Carta carta in baraja.MostrarBaraja())
            {
                Console.WriteLine(carta.Valor+" de "+carta.Palo);
            }

            Console.WriteLine("\n Cartas en el monton \n");

            foreach (Carta carta in baraja.CartasMonton())
            {
                Console.WriteLine(carta.Valor + " de " + carta.Palo);
            }

            Console.ReadKey();

        }
    }
}
