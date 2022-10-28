using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Raices raices = new Raices(2, 4, 2);
            raices.Calcular();
            if(raices.Calcular() == 2)
            {
                Console.WriteLine("La formula tiene dos raices: " + raices.raiz1 + " y " + raices.raiz2);
            }
            else if (raices.Calcular() == 1)
            {
                Console.WriteLine("La formula solo tiene una raiz: "+raices.raiz1);
            }
            else
            {
                Console.WriteLine("La formula no tiene solucion");
            }
            Console.ReadKey();
        }
    }
}
